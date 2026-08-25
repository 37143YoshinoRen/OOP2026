namespace CarReportSystem {
    public class Settings {

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
    }
}
