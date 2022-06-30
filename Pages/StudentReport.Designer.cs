namespace Perfect_Peace_System.Pages
{
    partial class StudentReport
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.classCb = new System.Windows.Forms.ComboBox();
            this.loadListBtn = new System.Windows.Forms.Button();
            this.totalStudentLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.topPanel);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(880, 638);
            this.bgPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.totalStudentLbl);
            this.topPanel.Controls.Add(this.loadListBtn);
            this.topPanel.Controls.Add(this.classCb);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(880, 97);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Class:";
            // 
            // classCb
            // 
            this.classCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCb.FormattingEnabled = true;
            this.classCb.Location = new System.Drawing.Point(158, 40);
            this.classCb.Name = "classCb";
            this.classCb.Size = new System.Drawing.Size(153, 21);
            this.classCb.TabIndex = 1;
            // 
            // loadListBtn
            // 
            this.loadListBtn.Location = new System.Drawing.Point(327, 38);
            this.loadListBtn.Name = "loadListBtn";
            this.loadListBtn.Size = new System.Drawing.Size(75, 23);
            this.loadListBtn.TabIndex = 2;
            this.loadListBtn.Text = "Load List";
            this.loadListBtn.UseVisualStyleBackColor = true;
            this.loadListBtn.Click += new System.EventHandler(this.loadListBtn_Click);
            // 
            // totalStudentLbl
            // 
            this.totalStudentLbl.AutoSize = true;
            this.totalStudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStudentLbl.Location = new System.Drawing.Point(671, 35);
            this.totalStudentLbl.Name = "totalStudentLbl";
            this.totalStudentLbl.Size = new System.Drawing.Size(20, 24);
            this.totalStudentLbl.TabIndex = 3;
            this.totalStudentLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class Total:";
            // 
            // StudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 638);
            this.Controls.Add(this.bgPanel);
            this.Name = "StudentReport";
            this.Text = "StudentReport";
            this.bgPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalStudentLbl;
        private System.Windows.Forms.Button loadListBtn;
        private System.Windows.Forms.ComboBox classCb;
        private System.Windows.Forms.Label label1;
    }
}