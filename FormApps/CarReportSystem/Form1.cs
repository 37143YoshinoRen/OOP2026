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
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                picture = pbPicture.Image,

            };
            listCarReports.Add(carReport);

            //履歴登録
            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
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

            if (dgyRecords.CurrentRow is null) return;

            dtpDate.Value = (DateTime)dgyRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgyRecords.CurrentRow.Cells["Author"].Value;
            SetRadioButtonMaker((MakerGroup)dgyRecords.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgyRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgyRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgyRecords.CurrentRow.Cells["picture"].Value;
        }

        private void SetRadioButtonMaker(MakerGroup targetMekar) {
            switch (targetMekar) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //記録者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(string author) {
            //未登録なら登録
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDeleteRecord_Click(object sender, EventArgs e) {
            listCarReports.RemoveAt();
        }
    }
}

