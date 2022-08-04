namespace Perfect_Peace_System.Pages
{
    partial class AssessmentCard
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
            this.bpPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bpPanel
            // 
            this.bpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpPanel.Location = new System.Drawing.Point(0, 0);
            this.bpPanel.Name = "bpPanel";
            this.bpPanel.Size = new System.Drawing.Size(835, 689);
            this.bpPanel.TabIndex = 0;
            // 
            // AssessmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 689);
            this.Controls.Add(this.bpPanel);
            this.Name = "AssessmentCard";
            this.Text = "AssessmentCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bpPanel;
    }
}