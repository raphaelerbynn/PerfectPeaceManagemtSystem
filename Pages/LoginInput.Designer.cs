namespace Perfect_Peace_System.Pages
{
    partial class LoginInput
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
            this.wrongMeesageLbl = new System.Windows.Forms.Label();
            this.createAccLink = new System.Windows.Forms.LinkLabel();
            this.viewPassword = new System.Windows.Forms.PictureBox();
            this.backLbl = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginAsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_idLbl = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.wrongMeesageLbl);
            this.bgPanel.Controls.Add(this.createAccLink);
            this.bgPanel.Controls.Add(this.viewPassword);
            this.bgPanel.Controls.Add(this.backLbl);
            this.bgPanel.Controls.Add(this.passwordTb);
            this.bgPanel.Controls.Add(this.usernameTb);
            this.bgPanel.Controls.Add(this.loginBtn);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.teacher_idLbl);
            this.bgPanel.Controls.Add(this.loginAsLbl);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(700, 390);
            this.bgPanel.TabIndex = 0;
            // 
            // wrongMeesageLbl
            // 
            this.wrongMeesageLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wrongMeesageLbl.AutoSize = true;
            this.wrongMeesageLbl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongMeesageLbl.ForeColor = System.Drawing.Color.LightCoral;
            this.wrongMeesageLbl.Location = new System.Drawing.Point(259, 94);
            this.wrongMeesageLbl.Name = "wrongMeesageLbl";
            this.wrongMeesageLbl.Size = new System.Drawing.Size(298, 18);
            this.wrongMeesageLbl.TabIndex = 46;
            this.wrongMeesageLbl.Text = "Username/email and password does not match";
            this.wrongMeesageLbl.Visible = false;
            // 
            // createAccLink
            // 
            this.createAccLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccLink.AutoSize = true;
            this.createAccLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccLink.Location = new System.Drawing.Point(574, 362);
            this.createAccLink.Name = "createAccLink";
            this.createAccLink.Size = new System.Drawing.Size(114, 19);
            this.createAccLink.TabIndex = 45;
            this.createAccLink.TabStop = true;
            this.createAccLink.Text = "Create Account";
            this.createAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccLink_LinkClicked);
            // 
            // viewPassword
            // 
            this.viewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewPassword.BackColor = System.Drawing.Color.White;
            this.viewPassword.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.viewPassword.Location = new System.Drawing.Point(541, 176);
            this.viewPassword.Name = "viewPassword";
            this.viewPassword.Size = new System.Drawing.Size(29, 19);
            this.viewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPassword.TabIndex = 44;
            this.viewPassword.TabStop = false;
            this.viewPassword.Tag = "view";
            this.viewPassword.Click += new System.EventHandler(this.viewPassword_Click);
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.Location = new System.Drawing.Point(25, 4);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(28, 13);
            this.backLbl.TabIndex = 4;
            this.backLbl.Text = "<<<";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.Location = new System.Drawing.Point(233, 173);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(341, 27);
            this.passwordTb.TabIndex = 2;
            // 
            // usernameTb
            // 
            this.usernameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(233, 117);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(341, 27);
            this.usernameTb.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.AutoSize = true;
            this.loginBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(347, 226);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 29);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // loginAsLbl
            // 
            this.loginAsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginAsLbl.AutoSize = true;
            this.loginAsLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsLbl.Location = new System.Drawing.Point(313, 54);
            this.loginAsLbl.Name = "loginAsLbl";
            this.loginAsLbl.Size = new System.Drawing.Size(122, 23);
            this.loginAsLbl.TabIndex = 0;
            this.loginAsLbl.Text = "Administrator";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username/email:";
            // 
            // teacher_idLbl
            // 
            this.teacher_idLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teacher_idLbl.AutoSize = true;
            this.teacher_idLbl.Font = new System.Drawing.Font("Calibri", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_idLbl.Location = new System.Drawing.Point(372, 310);
            this.teacher_idLbl.Name = "teacher_idLbl";
            this.teacher_idLbl.Size = new System.Drawing.Size(34, 9);
            this.teacher_idLbl.TabIndex = 0;
            this.teacher_idLbl.Text = "teacher_id";
            this.teacher_idLbl.Visible = false;
            // 
            // LoginInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.bgPanel);
            this.Name = "LoginInput";
            this.Text = "Login";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginAsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.PictureBox viewPassword;
        private System.Windows.Forms.LinkLabel createAccLink;
        private System.Windows.Forms.Label wrongMeesageLbl;
        private System.Windows.Forms.Label teacher_idLbl;
    }
}