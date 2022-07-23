namespace Perfect_Peace_System
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loadingPlaceholderPanel = new System.Windows.Forms.Panel();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loadingLbl);
            this.loginPanel.Controls.Add(this.loadingPanel);
            this.loginPanel.Controls.Add(this.loadingPlaceholderPanel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(703, 388);
            this.loginPanel.TabIndex = 0;
            // 
            // loadingPlaceholderPanel
            // 
            this.loadingPlaceholderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingPlaceholderPanel.Location = new System.Drawing.Point(0, 373);
            this.loadingPlaceholderPanel.Name = "loadingPlaceholderPanel";
            this.loadingPlaceholderPanel.Size = new System.Drawing.Size(703, 15);
            this.loadingPlaceholderPanel.TabIndex = 0;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Location = new System.Drawing.Point(0, 373);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(95, 15);
            this.loadingPanel.TabIndex = 1;
            // 
            // loadingLbl
            // 
            this.loadingLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLbl.Location = new System.Drawing.Point(325, 351);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(72, 19);
            this.loadingLbl.TabIndex = 2;
            this.loadingLbl.Text = "Loading...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 388);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label loadingLbl;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Panel loadingPlaceholderPanel;
        private System.Windows.Forms.Timer timer1;
    }
}