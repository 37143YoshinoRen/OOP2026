using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public class Settings {

        private const string FileName = "settings.xml";

        private static Settings instance = new Settings();

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
            = SystemColors.Control.ToArgb();

        //外部からnewできないようにする
        public static Settings _Instance {
            get { return instance; }
        }

        //外部からnewできないようにする
        private Settings() { }

        public void Load() {
            if (File.Exists(FileName))
                return;

            using var reader = XmlReader.Create(FileName) ;
                var serializer = new XmlSerializer(typeof(SettingsDate));

                if (serializer.Deserialize(reader) is SettingsDate date) {
                MainFormBackColor = date.MainFormBackColor;
                }
            }

        public void Save() {
            var date = new SettingsDate {
                MainFormBackColor = MainFormBackColor,
            };

            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(Settings));
            serializer.Serialize(writer, date);
        }
    }

    //XML保存用クラス
    public class SettingsDate {
        public int MainFormBackColor { get; set; }
    }
}
