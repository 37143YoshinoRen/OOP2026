using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public static class Database {
        private static readonly string DatabasePath =
        　　Path.Combine(AppContext.BaseDirectory, "carreport.db");

        private static readonly string ConnectionString =
            $"Data Source={DatabasePath}";

        public static SqliteConnection GetConnection()
            => new SqliteConnection(ConnectionString);

        public static void Initialize() {
            //接続オブジェクトを生成する。
            using var connection = GetConnection();

            //DBを開く
            connection.Open();

            using var command = connection.CreateCommand();

            //Carreportテーブルを作るSQL
            //IF NOT EXISTSにより、既にテーブルがあってもエラーにならない
            command.CommandText =
                """
                CREATE TABLE IF NOT EXISTS CarReports (
                Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                Date    TEXT     NOT NULL,
                Author  TEXT     NOT NULL,
                Maker   INTEGER  NOT NULL,
                CarName TEXT     NOT NULL,
                Report  TEXT     NOT NULL,
                Picture BLOB
                );
                """;
            command.ExecuteNonQuery();
        }
    }
}
