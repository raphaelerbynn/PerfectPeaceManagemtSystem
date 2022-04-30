namespace Perfect_Peace_System.Pages
{
    partial class FeePaying
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.feePanel = new System.Windows.Forms.Panel();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.totalAmntLbl = new System.Windows.Forms.Label();
            this.remainAmntLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modeOfPaymentCb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.payFeesBtn = new System.Windows.Forms.Button();
            this.termCb = new System.Windows.Forms.ComboBox();
            this.amntTb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stntCheckBtn = new System.Windows.Forms.Button();
            this.feePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // feePanel
            // 
            this.feePanel.Controls.Add(this.stntCheckBtn);
            this.feePanel.Controls.Add(this.dateDob);
            this.feePanel.Controls.Add(this.label12);
            this.feePanel.Controls.Add(this.totalAmntLbl);
            this.feePanel.Controls.Add(this.remainAmntLbl);
            this.feePanel.Controls.Add(this.label11);
            this.feePanel.Controls.Add(this.label10);
            this.feePanel.Controls.Add(this.label9);
            this.feePanel.Controls.Add(this.modeOfPaymentCb);
            this.feePanel.Controls.Add(this.button2);
            this.feePanel.Controls.Add(this.payFeesBtn);
            this.feePanel.Controls.Add(this.termCb);
            this.feePanel.Controls.Add(this.amntTb);
            this.feePanel.Controls.Add(this.textBox1);
            this.feePanel.Controls.Add(this.label8);
            this.feePanel.Controls.Add(this.label7);
            this.feePanel.Controls.Add(this.label6);
            this.feePanel.Controls.Add(this.label5);
            this.feePanel.Controls.Add(this.label4);
            this.feePanel.Controls.Add(this.label3);
            this.feePanel.Controls.Add(this.label2);
            this.feePanel.Controls.Add(this.label1);
            this.feePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feePanel.Location = new System.Drawing.Point(0, 0);
            this.feePanel.Name = "feePanel";
            this.feePanel.Size = new System.Drawing.Size(950, 539);
            this.feePanel.TabIndex = 0;
            // 
            // dateDob
            // 
            this.dateDob.CustomFormat = "01/01/2000 12:00";
            this.dateDob.Location = new System.Drawing.Point(325, 363);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(343, 20);
            this.dateDob.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "----------------";
            // 
            // totalAmntLbl
            // 
            this.totalAmntLbl.AutoSize = true;
            this.totalAmntLbl.Location = new System.Drawing.Point(355, 215);
            this.totalAmntLbl.Name = "totalAmntLbl";
            this.totalAmntLbl.Size = new System.Drawing.Size(40, 13);
            this.totalAmntLbl.TabIndex = 23;
            this.totalAmntLbl.Text = "100.00";
            // 
            // remainAmntLbl
            // 
            this.remainAmntLbl.AutoSize = true;
            this.remainAmntLbl.Location = new System.Drawing.Point(357, 253);
            this.remainAmntLbl.Name = "remainAmntLbl";
            this.remainAmntLbl.Size = new System.Drawing.Size(40, 13);
            this.remainAmntLbl.TabIndex = 22;
            this.remainAmntLbl.Text = "100.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ghc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ghc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ghc";
            // 
            // modeOfPaymentCb
            // 
            this.modeOfPaymentCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeOfPaymentCb.FormattingEnabled = true;
            this.modeOfPaymentCb.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Mobile Money",
            "Debit/Credit Card"});
            this.modeOfPaymentCb.Location = new System.Drawing.Point(323, 285);
            this.modeOfPaymentCb.Name = "modeOfPaymentCb";
            this.modeOfPaymentCb.Size = new System.Drawing.Size(345, 21);
            this.modeOfPaymentCb.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // payFeesBtn
            // 
            this.payFeesBtn.Location = new System.Drawing.Point(385, 431);
            this.payFeesBtn.Name = "payFeesBtn";
            this.payFeesBtn.Size = new System.Drawing.Size(75, 23);
            this.payFeesBtn.TabIndex = 16;
            this.payFeesBtn.Text = "Pay Fees";
            this.payFeesBtn.UseVisualStyleBackColor = true;
            this.payFeesBtn.Click += new System.EventHandler(this.payFeesBtn_Click);
            // 
            // termCb
            // 
            this.termCb.FormattingEnabled = true;
            this.termCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.termCb.Location = new System.Drawing.Point(324, 324);
            this.termCb.Name = "termCb";
            this.termCb.Size = new System.Drawing.Size(345, 21);
            this.termCb.TabIndex = 15;
            // 
            // amntTb
            // 
            this.amntTb.Location = new System.Drawing.Point(325, 171);
            this.amntTb.Name = "amntTb";
            this.amntTb.Size = new System.Drawing.Size(344, 20);
            this.amntTb.TabIndex = 13;
            this.amntTb.TextChanged += new System.EventHandler(this.amntTb_TextChanged);
            this.amntTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amntTb_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Term: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mode of Payment: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount Paid: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Amount: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remaining Amount: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name: ";
            // 
            // stntCheckBtn
            // 
            this.stntCheckBtn.Location = new System.Drawing.Point(675, 92);
            this.stntCheckBtn.Name = "stntCheckBtn";
            this.stntCheckBtn.Size = new System.Drawing.Size(32, 23);
            this.stntCheckBtn.TabIndex = 26;
            this.stntCheckBtn.Text = ">";
            this.stntCheckBtn.UseVisualStyleBackColor = true;
            // 
            // FeePaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 539);
            this.Controls.Add(this.feePanel);
            this.Name = "FeePaying";
            this.Text = "FeePaying";
            this.feePanel.ResumeLayout(false);
            this.feePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel feePanel;
        private System.Windows.Forms.ComboBox modeOfPaymentCb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button payFeesBtn;
        private System.Windows.Forms.ComboBox termCb;
        private System.Windows.Forms.TextBox amntTb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalAmntLbl;
        private System.Windows.Forms.Label remainAmntLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button stntCheckBtn;
    }
}