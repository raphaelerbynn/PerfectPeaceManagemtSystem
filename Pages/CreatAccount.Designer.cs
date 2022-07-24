namespace Perfect_Peace_System.Pages
{
    partial class CreateAccount
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
            this.bgPanel = new System.Windows.Forms.Panel();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.backLbl = new System.Windows.Forms.Label();
            this.adminPasswordTb = new System.Windows.Forms.TextBox();
            this.adminPasswordLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cPasswordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.systemKeyTb = new System.Windows.Forms.TextBox();
            this.systemKeyLbl = new System.Windows.Forms.Label();
            this.loginAsLbl = new System.Windows.Forms.Label();
            this.viewPassword = new System.Windows.Forms.PictureBox();
            this.viewConfirmPassword = new System.Windows.Forms.PictureBox();
            this.viewSysKey = new System.Windows.Forms.PictureBox();
            this.viewAdminPassword = new System.Windows.Forms.PictureBox();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSysKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAdminPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.viewAdminPassword);
            this.bgPanel.Controls.Add(this.viewSysKey);
            this.bgPanel.Controls.Add(this.viewConfirmPassword);
            this.bgPanel.Controls.Add(this.viewPassword);
            this.bgPanel.Controls.Add(this.nameTb);
            this.bgPanel.Controls.Add(this.label5);
            this.bgPanel.Controls.Add(this.emailTb);
            this.bgPanel.Controls.Add(this.label4);
            this.bgPanel.Controls.Add(this.usernameTb);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.passwordTb);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.cPasswordTb);
            this.bgPanel.Controls.Add(this.label3);
            this.bgPanel.Controls.Add(this.systemKeyTb);
            this.bgPanel.Controls.Add(this.systemKeyLbl);
            this.bgPanel.Controls.Add(this.loginAsLbl);
            this.bgPanel.Controls.Add(this.adminPasswordTb);
            this.bgPanel.Controls.Add(this.adminPasswordLbl);
            this.bgPanel.Controls.Add(this.backLbl);
            this.bgPanel.Controls.Add(this.createAccBtn);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(700, 390);
            this.bgPanel.TabIndex = 0;
            // 
            // createAccBtn
            // 
            this.createAccBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createAccBtn.AutoSize = true;
            this.createAccBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccBtn.Location = new System.Drawing.Point(317, 331);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(118, 29);
            this.createAccBtn.TabIndex = 1;
            this.createAccBtn.Text = "Create Account";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.Location = new System.Drawing.Point(24, 4);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(28, 13);
            this.backLbl.TabIndex = 3;
            this.backLbl.Text = "<<<";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // adminPasswordTb
            // 
            this.adminPasswordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminPasswordTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordTb.Location = new System.Drawing.Point(235, 291);
            this.adminPasswordTb.Name = "adminPasswordTb";
            this.adminPasswordTb.PasswordChar = '*';
            this.adminPasswordTb.Size = new System.Drawing.Size(341, 24);
            this.adminPasswordTb.TabIndex = 29;
            // 
            // adminPasswordLbl
            // 
            this.adminPasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminPasswordLbl.AutoSize = true;
            this.adminPasswordLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordLbl.Location = new System.Drawing.Point(109, 296);
            this.adminPasswordLbl.Name = "adminPasswordLbl";
            this.adminPasswordLbl.Size = new System.Drawing.Size(120, 19);
            this.adminPasswordLbl.TabIndex = 28;
            this.adminPasswordLbl.Text = "Admin Password:";
            // 
            // nameTb
            // 
            this.nameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(235, 55);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(341, 24);
            this.nameTb.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Name:";
            // 
            // emailTb
            // 
            this.emailTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.Location = new System.Drawing.Point(235, 94);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(341, 24);
            this.emailTb.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Email:";
            // 
            // usernameTb
            // 
            this.usernameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(235, 133);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(341, 24);
            this.usernameTb.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Username:";
            // 
            // passwordTb
            // 
            this.passwordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.Location = new System.Drawing.Point(235, 172);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(341, 24);
            this.passwordTb.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password:";
            // 
            // cPasswordTb
            // 
            this.cPasswordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cPasswordTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPasswordTb.Location = new System.Drawing.Point(235, 211);
            this.cPasswordTb.Name = "cPasswordTb";
            this.cPasswordTb.PasswordChar = '*';
            this.cPasswordTb.Size = new System.Drawing.Size(341, 24);
            this.cPasswordTb.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Confirm Password:";
            // 
            // systemKeyTb
            // 
            this.systemKeyTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.systemKeyTb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemKeyTb.Location = new System.Drawing.Point(235, 252);
            this.systemKeyTb.Name = "systemKeyTb";
            this.systemKeyTb.PasswordChar = '*';
            this.systemKeyTb.Size = new System.Drawing.Size(341, 24);
            this.systemKeyTb.TabIndex = 32;
            // 
            // systemKeyLbl
            // 
            this.systemKeyLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.systemKeyLbl.AutoSize = true;
            this.systemKeyLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemKeyLbl.Location = new System.Drawing.Point(143, 257);
            this.systemKeyLbl.Name = "systemKeyLbl";
            this.systemKeyLbl.Size = new System.Drawing.Size(86, 19);
            this.systemKeyLbl.TabIndex = 31;
            this.systemKeyLbl.Text = "System Key:";
            // 
            // loginAsLbl
            // 
            this.loginAsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginAsLbl.AutoSize = true;
            this.loginAsLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsLbl.Location = new System.Drawing.Point(313, 19);
            this.loginAsLbl.Name = "loginAsLbl";
            this.loginAsLbl.Size = new System.Drawing.Size(122, 23);
            this.loginAsLbl.TabIndex = 30;
            this.loginAsLbl.Text = "Administrator";
            // 
            // viewPassword
            // 
            this.viewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewPassword.BackColor = System.Drawing.Color.White;
            this.viewPassword.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.viewPassword.Location = new System.Drawing.Point(543, 175);
            this.viewPassword.Name = "viewPassword";
            this.viewPassword.Size = new System.Drawing.Size(29, 19);
            this.viewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPassword.TabIndex = 43;
            this.viewPassword.TabStop = false;
            this.viewPassword.Tag = "view";
            this.viewPassword.Click += new System.EventHandler(this.viewPassword_Click);
            // 
            // viewConfirmPassword
            // 
            this.viewConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewConfirmPassword.BackColor = System.Drawing.Color.White;
            this.viewConfirmPassword.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.viewConfirmPassword.Location = new System.Drawing.Point(544, 213);
            this.viewConfirmPassword.Name = "viewConfirmPassword";
            this.viewConfirmPassword.Size = new System.Drawing.Size(29, 19);
            this.viewConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewConfirmPassword.TabIndex = 43;
            this.viewConfirmPassword.TabStop = false;
            this.viewConfirmPassword.Tag = "view";
            this.viewConfirmPassword.Click += new System.EventHandler(this.viewConfirmPassword_Click);
            // 
            // viewSysKey
            // 
            this.viewSysKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewSysKey.BackColor = System.Drawing.Color.White;
            this.viewSysKey.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.viewSysKey.Location = new System.Drawing.Point(545, 254);
            this.viewSysKey.Name = "viewSysKey";
            this.viewSysKey.Size = new System.Drawing.Size(29, 19);
            this.viewSysKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewSysKey.TabIndex = 43;
            this.viewSysKey.TabStop = false;
            this.viewSysKey.Tag = "view";
            this.viewSysKey.Click += new System.EventHandler(this.viewSysKey_Click);
            // 
            // viewAdminPassword
            // 
            this.viewAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewAdminPassword.BackColor = System.Drawing.Color.White;
            this.viewAdminPassword.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.viewAdminPassword.Location = new System.Drawing.Point(544, 294);
            this.viewAdminPassword.Name = "viewAdminPassword";
            this.viewAdminPassword.Size = new System.Drawing.Size(29, 19);
            this.viewAdminPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewAdminPassword.TabIndex = 43;
            this.viewAdminPassword.TabStop = false;
            this.viewAdminPassword.Tag = "view";
            this.viewAdminPassword.Click += new System.EventHandler(this.viewAdminPassword_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.bgPanel);
            this.Name = "CreateAccount";
            this.Text = "Login";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSysKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAdminPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cPasswordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox systemKeyTb;
        private System.Windows.Forms.Label systemKeyLbl;
        private System.Windows.Forms.Label loginAsLbl;
        private System.Windows.Forms.TextBox adminPasswordTb;
        private System.Windows.Forms.Label adminPasswordLbl;
        private System.Windows.Forms.PictureBox viewAdminPassword;
        private System.Windows.Forms.PictureBox viewSysKey;
        private System.Windows.Forms.PictureBox viewConfirmPassword;
        private System.Windows.Forms.PictureBox viewPassword;
    }
}