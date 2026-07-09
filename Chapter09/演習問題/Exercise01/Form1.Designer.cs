namespace Exercise01 {
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
            btButton1 = new Button();
            tbOut1 = new TextBox();
            tbButton2 = new Button();
            tbOut2 = new TextBox();
            tbButton3 = new Button();
            tbOut3 = new TextBox();
            SuspendLayout();
            // 
            // btButton1
            // 
            btButton1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton1.Location = new Point(51, 56);
            btButton1.Name = "btButton1";
            btButton1.Size = new Size(96, 50);
            btButton1.TabIndex = 0;
            btButton1.Text = "①";
            btButton1.UseVisualStyleBackColor = true;
            btButton1.Click += btButton1_Click;
            // 
            // tbOut1
            // 
            tbOut1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut1.Location = new Point(191, 62);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(413, 39);
            tbOut1.TabIndex = 1;
            // 
            // tbButton2
            // 
            tbButton2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbButton2.Location = new Point(51, 145);
            tbButton2.Name = "tbButton2";
            tbButton2.Size = new Size(96, 50);
            tbButton2.TabIndex = 0;
            tbButton2.Text = "②";
            tbButton2.UseVisualStyleBackColor = true;
            tbButton2.Click += tbButton2_Click;
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(191, 151);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(413, 39);
            tbOut2.TabIndex = 1;
            // 
            // tbButton3
            // 
            tbButton3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbButton3.Location = new Point(51, 234);
            tbButton3.Name = "tbButton3";
            tbButton3.Size = new Size(96, 50);
            tbButton3.TabIndex = 0;
            tbButton3.Text = "③";
            tbButton3.UseVisualStyleBackColor = true;
            tbButton3.Click += tbButton3_Click;
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(191, 240);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(413, 39);
            tbOut3.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbButton3);
            Controls.Add(tbOut1);
            Controls.Add(tbButton2);
            Controls.Add(btButton1);
            Name = "Form1";
            Text = "問題9.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btButton1;
        private TextBox tbOut1;
        private Button tbButton2;
        private TextBox tbOut2;
        private Button tbButton3;
        private TextBox tbOut3;
    }
}
