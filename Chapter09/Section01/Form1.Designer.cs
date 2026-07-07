namespace Section01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ofdOpen = new OpenFileDialog();
            dtpDate = new DateTimePicker();
            btGet = new Button();
            tbOut2 = new TextBox();
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpbrith = new DateTimePicker();
            btBirthCalc = new Button();
            label2 = new Label();
            tbOut1 = new TextBox();
            label3 = new Label();
            tbOut3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(49, 50);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 0;
            // 
            // btGet
            // 
            btGet.Location = new Point(323, 50);
            btGet.Name = "btGet";
            btGet.Size = new Size(85, 39);
            btGet.TabIndex = 1;
            btGet.Text = "取得";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(49, 351);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(359, 39);
            tbOut2.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(49, 132);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 39);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(187, 139);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpbrith
            // 
            dtpbrith.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpbrith.Location = new Point(49, 194);
            dtpbrith.Name = "dtpbrith";
            dtpbrith.Size = new Size(200, 39);
            dtpbrith.TabIndex = 0;
            // 
            // btBirthCalc
            // 
            btBirthCalc.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btBirthCalc.Location = new Point(317, 190);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(91, 43);
            btBirthCalc.TabIndex = 5;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = true;
            btBirthCalc.Click += btBirthCalc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 333);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "経過日数";
            // 
            // tbOut1
            // 
            tbOut1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut1.Location = new Point(49, 281);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(359, 39);
            tbOut1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 263);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "年齢";
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(49, 426);
            tbOut3.Multiline = true;
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(359, 70);
            tbOut3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 408);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 6;
            label4.Text = "メモ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 618);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btBirthCalc);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut1);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(btGet);
            Controls.Add(dtpbrith);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut2;
        internal NumericUpDown nudDay;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dtpbrith;
        private Button btBirthCalc;
        private Label label2;
        private TextBox tbOut1;
        private Label label3;
        private TextBox tbOut3;
        private Label label4;
    }
}
