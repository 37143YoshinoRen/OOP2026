using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;

            tbOut2.Text = date.AddDays((double)nudDay.Value).ToString();


        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpbrith.Value;   //ê∂Ç‹ÇÍÇΩì˙ït
            DateTime today = DateTime.Today;   //ç°ì˙ÇÃì˙ït


            //int age = today.Year - birth.Year;
            //if (today < birth.AddYears(age)) {
            //    age--;
            //}
            tbOut1.Text = ($"Ç†Ç»ÇΩÇÕ{GetAge(birth, today)}çŒÇ≈Ç∑").ToString();

            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = ($"{ts.Days}ì˙åoÇøÇ‹ÇµÇΩ").ToString();

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);

            tbOut3.Text = ($"ê∂Ç‹ÇÍÇΩ{birth.Month}åéÇÕ{birth.Day}ì˙ÇÕëÊ{NthWeek(birth.Date)}èTÇ≈{dayOfWeek}ójì˙Ç≈Ç∑Ç≈Ç∑").ToString();

            static int GetAge(DateTime birthday, DateTime targetDay) {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birthday.AddYears(age)) {
                    age--;
                }
                return age;
            }
        
        //éwíËÇµÇΩì˙Ç™ëÊâΩèTÇ©ãÅÇﬂÇÈ
        static int NthWeek(DateTime date) {
                var firstDay = new DateTime(date.Year, date.Month, 1);
                var firstDayOfWeek = (int)(firstDay.DayOfWeek);
                return (date.Day + firstDayOfWeek - 1) / 7 + 1;
            }
        }
    }
}
