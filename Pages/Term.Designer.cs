namespace Perfect_Peace_System.Pages
{
    partial class Term
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
            this.saveDateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDatePk = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.feesBtn = new System.Windows.Forms.Button();
            this.saveAttenceBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.saveDateBtn);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.endDatePk);
            this.bgPanel.Controls.Add(this.button1);
            this.bgPanel.Controls.Add(this.feesBtn);
            this.bgPanel.Controls.Add(this.saveAttenceBtn);
            this.bgPanel.Controls.Add(this.closeBtn);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(800, 450);
            this.bgPanel.TabIndex = 1;
            // 
            // saveDateBtn
            // 
            this.saveDateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveDateBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveDateBtn.FlatAppearance.BorderSize = 0;
            this.saveDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDateBtn.Location = new System.Drawing.Point(585, 90);
            this.saveDateBtn.Name = "saveDateBtn";
            this.saveDateBtn.Size = new System.Drawing.Size(75, 23);
            this.saveDateBtn.TabIndex = 11;
            this.saveDateBtn.Text = "Save Date";
            this.saveDateBtn.UseVisualStyleBackColor = false;
            this.saveDateBtn.Click += new System.EventHandler(this.saveDateBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(342, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "END OF TERM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Set Term End Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // endDatePk
            // 
            this.endDatePk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDatePk.Enabled = false;
            this.endDatePk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePk.Location = new System.Drawing.Point(211, 86);
            this.endDatePk.Name = "endDatePk";
            this.endDatePk.Size = new System.Drawing.Size(368, 27);
            this.endDatePk.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(313, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "END TERM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // feesBtn
            // 
            this.feesBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feesBtn.AutoSize = true;
            this.feesBtn.BackColor = System.Drawing.Color.LightCoral;
            this.feesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.feesBtn.FlatAppearance.BorderSize = 0;
            this.feesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesBtn.Location = new System.Drawing.Point(178, 245);
            this.feesBtn.Name = "feesBtn";
            this.feesBtn.Size = new System.Drawing.Size(458, 98);
            this.feesBtn.TabIndex = 8;
            this.feesBtn.Text = "RESET FEES FOR REPORT AND SYSTEM";
            this.feesBtn.UseVisualStyleBackColor = false;
            this.feesBtn.Click += new System.EventHandler(this.feesBtn_Click);
            // 
            // saveAttenceBtn
            // 
            this.saveAttenceBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveAttenceBtn.AutoSize = true;
            this.saveAttenceBtn.BackColor = System.Drawing.Color.LightGreen;
            this.saveAttenceBtn.FlatAppearance.BorderSize = 0;
            this.saveAttenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAttenceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAttenceBtn.Location = new System.Drawing.Point(178, 137);
            this.saveAttenceBtn.Name = "saveAttenceBtn";
            this.saveAttenceBtn.Size = new System.Drawing.Size(458, 91);
            this.saveAttenceBtn.TabIndex = 8;
            this.saveAttenceBtn.Text = "SAVE ATTENDANCE FOR REPORT";
            this.saveAttenceBtn.UseVisualStyleBackColor = false;
            this.saveAttenceBtn.Click += new System.EventHandler(this.saveAttenceBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::Perfect_Peace_System.Properties.Resources.controls_white;
            this.closeBtn.Location = new System.Drawing.Point(768, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 7;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Term
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Term";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Term";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button feesBtn;
        private System.Windows.Forms.Button saveAttenceBtn;
        private System.Windows.Forms.Button saveDateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDatePk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}