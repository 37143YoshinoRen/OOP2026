using Microsoft.VisualBasic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing.Text;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgyRecords.DataSource = listCarReports;
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMassage.Text = String.Empty;

            //記入者と車名が未入力だった場合は追加しない
            if (cbAuthor.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMassage.Text = "記録者、または車名が未入力です。";  //メッセージ領域のクリア
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = GetRadioButtonMaker().ToString(),
                Report = tbReport.Text,
                picture = pbPicture.Image,

            };
            listCarReports.Add(carReport);

        }
        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return MakerGroup.日産;
            if (rbSubaru.Checked)
                return MakerGroup.スバル;
            if (rbHonda.Checked)
                return MakerGroup.ホンダ;
            if (rbImport.Checked)
                return MakerGroup.輸入車;

            return MakerGroup.その他;

        }

        private void btOpenPicture_Click(object sender, EventArgs e) {

            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            //    ImputItemsAllClear();
            // }
            // private void btnewInput Click() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = String.Empty;
            rbOther.Checked = true;
            cbCarName.Text = String.Empty;
            tbReport.Text = String.Empty;
            pbPicture.Image = null;

        }

        private void dgyRecords_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgyRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgyRecords.CurrentRow.Cells["Author"].Value;
            //GetRadioButtonMaker() = (string)dgyRecords.CurrentRow.Cells["CarName"].Value;
            cbCarName.Text = (string)dgyRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgyRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgyRecords.CurrentRow.Cells["picture"].Value;
        }
    }
}
