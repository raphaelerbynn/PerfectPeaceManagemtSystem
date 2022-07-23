namespace Perfect_Peace_System.Pages
{
    partial class LoginAs
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
            this.loginAsPanel = new System.Windows.Forms.Panel();
            this.accountantLink = new System.Windows.Forms.LinkLabel();
            this.classTeacherLink = new System.Windows.Forms.LinkLabel();
            this.adminLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginAsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginAsPanel
            // 
            this.loginAsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginAsPanel.Controls.Add(this.accountantLink);
            this.loginAsPanel.Controls.Add(this.classTeacherLink);
            this.loginAsPanel.Controls.Add(this.adminLink);
            this.loginAsPanel.Controls.Add(this.label4);
            this.loginAsPanel.Controls.Add(this.label3);
            this.loginAsPanel.Controls.Add(this.label2);
            this.loginAsPanel.Controls.Add(this.label1);
            this.loginAsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginAsPanel.Location = new System.Drawing.Point(0, 0);
            this.loginAsPanel.Name = "loginAsPanel";
            this.loginAsPanel.Size = new System.Drawing.Size(800, 450);
            this.loginAsPanel.TabIndex = 0;
            // 
            // accountantLink
            // 
            this.accountantLink.AutoSize = true;
            this.accountantLink.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountantLink.Location = new System.Drawing.Point(291, 262);
            this.accountantLink.Name = "accountantLink";
            this.accountantLink.Size = new System.Drawing.Size(169, 39);
            this.accountantLink.TabIndex = 1;
            this.accountantLink.TabStop = true;
            this.accountantLink.Text = "Accountant";
            this.accountantLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminLink_LinkClicked);
            // 
            // classTeacherLink
            // 
            this.classTeacherLink.AutoSize = true;
            this.classTeacherLink.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classTeacherLink.Location = new System.Drawing.Point(291, 194);
            this.classTeacherLink.Name = "classTeacherLink";
            this.classTeacherLink.Size = new System.Drawing.Size(191, 39);
            this.classTeacherLink.TabIndex = 1;
            this.classTeacherLink.TabStop = true;
            this.classTeacherLink.Text = "Class Teacher";
            this.classTeacherLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminLink_LinkClicked);
            // 
            // adminLink
            // 
            this.adminLink.AutoSize = true;
            this.adminLink.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLink.Location = new System.Drawing.Point(291, 134);
            this.adminLink.Name = "adminLink";
            this.adminLink.Size = new System.Drawing.Size(198, 39);
            this.adminLink.TabIndex = 1;
            this.adminLink.TabStop = true;
            this.adminLink.Text = "Administrator";
            this.adminLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = ">>>>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = ">>>>>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = ">>>>>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN AS . . .";
            // 
            // LoginAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginAsPanel);
            this.Name = "LoginAs";
            this.Text = "Login";
            this.loginAsPanel.ResumeLayout(false);
            this.loginAsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginAsPanel;
        private System.Windows.Forms.LinkLabel accountantLink;
        private System.Windows.Forms.LinkLabel classTeacherLink;
        private System.Windows.Forms.LinkLabel adminLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}