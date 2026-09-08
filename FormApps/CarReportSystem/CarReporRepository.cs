using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public class CarReporRepository {

        public List<CarReport> GetAll() {

            var report = new List<CarReport>();

            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText =
                """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;
            using var reader = command.ExecuteReader();

            while (reader.Read()) {
                report.Add(new CarReport {
                    Id = reader.GetInt32(0),
                    Date = DateTime.ParseExact(reader.GetString(1),
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture),

                    Author = reader.GetString(2),
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    Picture = reader.IsDBNull(6) ? null :
                        BytesToImage(reader.GetFieldValue<byte[]>(6))
                });
            }
            return report;
        }

        public int Add(DateTime data, string author, MakerGroup maker, string carname, string report, string picture) {
            //接続オブジェクトを生成する。
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
            INSERT INTO CarReport 
            (Date, Author,Maker,CarName,Report,Picture)
            VALUES ($date, $author, $maker, $carName, $report, $picture,);
            SELECT last_insert_rowid();
            """;

            command.Parameters.AddWithValue("$date", data);
            command.Parameters.AddWithValue("$author", author);
            command.Parameters.AddWithValue("$maker", maker);
            command.Parameters.AddWithValue("$carName", carname);
            command.Parameters.AddWithValue("$report", report);
            command.Parameters.AddWithValue("$picture", picture);

            //結果行を返さないSQLを実行する
            var result = command.ExecuteScalar();

            if (result is null)
                throw new InvalidOperationException("登録した商品のIDが取得できませんでした。");

            //SQLiteのINTEGERはlongとして返るため、intへ変換する
            return Convert.ToInt32(result);
        }

        //更新
        public void Update(CarReport carreport) {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
            UPDATE CarReport
            SET Data = $date,Author = $author,Maker = $maker,
                CarName = $carName,Report = $report,Picture = $picture
            WHERE Id = $id;
            """;

            command.Parameters.AddWithValue("$id", carreport.Id);
            command.Parameters.AddWithValue("$date", carreport.Date);
            command.Parameters.AddWithValue("$author", carreport.Author);
            command.Parameters.AddWithValue("$maker", carreport.Maker);
            command.Parameters.AddWithValue("$carName", carreport.CarName);
            command.Parameters.AddWithValue("$report", carreport.Report);
            command.Parameters.AddWithValue("$picture", carreport.Picture);

            if (command.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
        }

        //削除
        public void Delete(int id) {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
            DELETE FROM Products
            WHERE Id = $id;
            """;

            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();

        }

        // ImageをSQLiteへ保存できるbyte[]へ変換する
        private static byte[]? ImageToBytes(Image? image) {
            if (image is null) return null;

            using var stream = new MemoryStream();
            // DBへはPNG形式で保存
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        // SQLiteのBLOB（byte[]）をImageへ変換する
        private static Image BytesToImage(byte[] data) {
            using var stream = new MemoryStream(data);
            using var image = Image.FromStream(stream);
            // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
            return new Bitmap(image);
        }
    }
}

