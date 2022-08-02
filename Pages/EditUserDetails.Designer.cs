namespace Perfect_Peace_System.Pages
{
    partial class EditUserDetails
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
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.nameCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginAsLbl = new System.Windows.Forms.Label();
            this.createAccBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::Perfect_Peace_System.Properties.Resources.controls;
            this.closeBtn.Location = new System.Drawing.Point(524, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 9;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nameCb
            // 
            this.nameCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameCb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCb.FormattingEnabled = true;
            this.nameCb.Location = new System.Drawing.Point(137, 142);
            this.nameCb.Name = "nameCb";
            this.nameCb.Size = new System.Drawing.Size(342, 23);
            this.nameCb.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Name:";
            // 
            // emailTb
            // 
            this.emailTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.Location = new System.Drawing.Point(138, 176);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(341, 24);
            this.emailTb.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Email:";
            // 
            // usernameTb
            // 
            this.usernameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(138, 215);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(341, 24);
            this.usernameTb.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Username:";
            // 
            // passwordTb
            // 
            this.passwordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.Location = new System.Drawing.Point(138, 254);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(341, 24);
            this.passwordTb.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Password:";
            // 
            // loginAsLbl
            // 
            this.loginAsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginAsLbl.AutoSize = true;
            this.loginAsLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsLbl.Location = new System.Drawing.Point(199, 73);
            this.loginAsLbl.Name = "loginAsLbl";
            this.loginAsLbl.Size = new System.Drawing.Size(185, 23);
            this.loginAsLbl.TabIndex = 48;
            this.loginAsLbl.Text = "UPDATE USER DETAILS";
            // 
            // createAccBtn
            // 
            this.createAccBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createAccBtn.AutoSize = true;
            this.createAccBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccBtn.Location = new System.Drawing.Point(228, 314);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(118, 29);
            this.createAccBtn.TabIndex = 45;
            this.createAccBtn.Text = "Update Details";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // EditUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 420);
            this.Controls.Add(this.nameCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginAsLbl);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserDetails";
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.ComboBox nameCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginAsLbl;
        private System.Windows.Forms.Button createAccBtn;
    }
}