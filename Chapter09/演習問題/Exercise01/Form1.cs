using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var s1 = dateTime.ToString("yyyy/MM/dd HH:mm");
            tbOut1.Text = s1;
        }

        private void tbButton2_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var s1 = dateTime.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b");
            tbOut2.Text = s1;
        }

        private void tbButton3_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var cul = new CultureInfo("ja-JP");
            cul.DateTimeFormat.Calendar = new JapaneseCalendar();
            var s1 = dateTime.ToString($"gg y”N MŒŽ d“ú (dddd)",cul);
            tbOut3.Text = s1;
        }
    }
}
