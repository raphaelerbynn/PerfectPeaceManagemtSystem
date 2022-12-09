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
            this.getStudentDetailsBtn = new System.Windows.Forms.Button();
            this.classLbl = new System.Windows.Forms.Label();
            this.student_nameCb = new System.Windows.Forms.ComboBox();
            this.totalAmntLbl = new System.Windows.Forms.Label();
            this.paidAmntLbl = new System.Windows.Forms.Label();
            this.remainAmntLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modeOfPaymentCb = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.payFeesBtn = new System.Windows.Forms.Button();
            this.termCb = new System.Windows.Forms.ComboBox();
            this.amntTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.feePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // feePanel
            // 
            this.feePanel.Controls.Add(this.panel1);
            this.feePanel.Controls.Add(this.clearBtn);
            this.feePanel.Controls.Add(this.payFeesBtn);
            this.feePanel.Controls.Add(this.label13);
            this.feePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feePanel.Location = new System.Drawing.Point(0, 0);
            this.feePanel.Name = "feePanel";
            this.feePanel.Size = new System.Drawing.Size(950, 539);
            this.feePanel.TabIndex = 0;
            // 
            // getStudentDetailsBtn
            // 
            this.getStudentDetailsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.getStudentDetailsBtn.AutoSize = true;
            this.getStudentDetailsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getStudentDetailsBtn.BackColor = System.Drawing.Color.DarkRed;
            this.getStudentDetailsBtn.Enabled = false;
            this.getStudentDetailsBtn.FlatAppearance.BorderSize = 0;
            this.getStudentDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getStudentDetailsBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStudentDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.getStudentDetailsBtn.Location = new System.Drawing.Point(770, 26);
            this.getStudentDetailsBtn.Name = "getStudentDetailsBtn";
            this.getStudentDetailsBtn.Size = new System.Drawing.Size(27, 29);
            this.getStudentDetailsBtn.TabIndex = 26;
            this.getStudentDetailsBtn.Text = ">";
            this.getStudentDetailsBtn.UseVisualStyleBackColor = false;
            this.getStudentDetailsBtn.Click += new System.EventHandler(this.getStudentDetailsBtn_Click);
            // 
            // classLbl
            // 
            this.classLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classLbl.AutoSize = true;
            this.classLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLbl.Location = new System.Drawing.Point(459, 68);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(59, 19);
            this.classLbl.TabIndex = 25;
            this.classLbl.Text = "----------";
            // 
            // student_nameCb
            // 
            this.student_nameCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.student_nameCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.student_nameCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.student_nameCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_nameCb.FormattingEnabled = true;
            this.student_nameCb.Location = new System.Drawing.Point(186, 28);
            this.student_nameCb.Name = "student_nameCb";
            this.student_nameCb.Size = new System.Drawing.Size(578, 27);
            this.student_nameCb.TabIndex = 24;
            this.student_nameCb.TextChanged += new System.EventHandler(this.student_nameCb_TextChanged);
            // 
            // totalAmntLbl
            // 
            this.totalAmntLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalAmntLbl.AutoSize = true;
            this.totalAmntLbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmntLbl.Location = new System.Drawing.Point(488, 143);
            this.totalAmntLbl.Name = "totalAmntLbl";
            this.totalAmntLbl.Size = new System.Drawing.Size(65, 23);
            this.totalAmntLbl.TabIndex = 23;
            this.totalAmntLbl.Text = "100.00";
            // 
            // paidAmntLbl
            // 
            this.paidAmntLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paidAmntLbl.AutoSize = true;
            this.paidAmntLbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmntLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.paidAmntLbl.Location = new System.Drawing.Point(488, 177);
            this.paidAmntLbl.Name = "paidAmntLbl";
            this.paidAmntLbl.Size = new System.Drawing.Size(45, 23);
            this.paidAmntLbl.TabIndex = 22;
            this.paidAmntLbl.Text = "0.00";
            // 
            // remainAmntLbl
            // 
            this.remainAmntLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remainAmntLbl.AutoSize = true;
            this.remainAmntLbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainAmntLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.remainAmntLbl.Location = new System.Drawing.Point(488, 213);
            this.remainAmntLbl.Name = "remainAmntLbl";
            this.remainAmntLbl.Size = new System.Drawing.Size(45, 23);
            this.remainAmntLbl.TabIndex = 22;
            this.remainAmntLbl.Text = "0.00";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ghc";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(459, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ghc";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ghc";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(182, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ghc";
            // 
            // modeOfPaymentCb
            // 
            this.modeOfPaymentCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modeOfPaymentCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeOfPaymentCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeOfPaymentCb.FormattingEnabled = true;
            this.modeOfPaymentCb.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Mobile Money",
            "Debit/Credit Card"});
            this.modeOfPaymentCb.Location = new System.Drawing.Point(186, 252);
            this.modeOfPaymentCb.Name = "modeOfPaymentCb";
            this.modeOfPaymentCb.Size = new System.Drawing.Size(578, 27);
            this.modeOfPaymentCb.TabIndex = 18;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearBtn.AutoSize = true;
            this.clearBtn.BackColor = System.Drawing.Color.DarkRed;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(513, 449);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 29);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // payFeesBtn
            // 
            this.payFeesBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payFeesBtn.AutoSize = true;
            this.payFeesBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.payFeesBtn.Enabled = false;
            this.payFeesBtn.FlatAppearance.BorderSize = 0;
            this.payFeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payFeesBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payFeesBtn.ForeColor = System.Drawing.Color.White;
            this.payFeesBtn.Location = new System.Drawing.Point(397, 449);
            this.payFeesBtn.Name = "payFeesBtn";
            this.payFeesBtn.Size = new System.Drawing.Size(76, 29);
            this.payFeesBtn.TabIndex = 16;
            this.payFeesBtn.Text = "Pay Fees";
            this.payFeesBtn.UseVisualStyleBackColor = false;
            this.payFeesBtn.Click += new System.EventHandler(this.payFeesBtn_Click);
            // 
            // termCb
            // 
            this.termCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.termCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termCb.FormattingEnabled = true;
            this.termCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.termCb.Location = new System.Drawing.Point(186, 294);
            this.termCb.Name = "termCb";
            this.termCb.Size = new System.Drawing.Size(578, 27);
            this.termCb.TabIndex = 15;
            // 
            // amntTb
            // 
            this.amntTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amntTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amntTb.Location = new System.Drawing.Point(226, 101);
            this.amntTb.Name = "amntTb";
            this.amntTb.Size = new System.Drawing.Size(538, 27);
            this.amntTb.TabIndex = 13;
            this.amntTb.TextChanged += new System.EventHandler(this.amntTb_TextChanged);
            this.amntTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amntTb_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Term: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mode of Payment: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Amount Paid: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Amount: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Paid Amount: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remaining Amount: ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "PAY FEES";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getStudentDetailsBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.classLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.student_nameCb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totalAmntLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.paidAmntLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.remainAmntLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.amntTb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.termCb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.modeOfPaymentCb);
            this.panel1.Location = new System.Drawing.Point(56, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 358);
            this.panel1.TabIndex = 42;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel feePanel;
        private System.Windows.Forms.ComboBox modeOfPaymentCb;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button payFeesBtn;
        private System.Windows.Forms.ComboBox termCb;
        private System.Windows.Forms.TextBox amntTb;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.ComboBox student_nameCb;
        private System.Windows.Forms.Button getStudentDetailsBtn;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.Label paidAmntLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
    }
}