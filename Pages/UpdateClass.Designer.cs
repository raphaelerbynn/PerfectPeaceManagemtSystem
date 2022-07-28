namespace Perfect_Peace_System.Pages
{
    partial class UpdateClass
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
            this.label6 = new System.Windows.Forms.Label();
            this.feesBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updateClassBtn = new System.Windows.Forms.Button();
            this.teacherCb = new System.Windows.Forms.ComboBox();
            this.sectionCb = new System.Windows.Forms.ComboBox();
            this.capacityTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.label6);
            this.bgPanel.Controls.Add(this.feesBox);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.updateClassBtn);
            this.bgPanel.Controls.Add(this.teacherCb);
            this.bgPanel.Controls.Add(this.sectionCb);
            this.bgPanel.Controls.Add(this.capacityTb);
            this.bgPanel.Controls.Add(this.label5);
            this.bgPanel.Controls.Add(this.label4);
            this.bgPanel.Controls.Add(this.label3);
            this.bgPanel.Controls.Add(this.nameTb);
            this.bgPanel.Controls.Add(this.label7);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(797, 540);
            this.bgPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ghc";
            // 
            // feesBox
            // 
            this.feesBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feesBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesBox.Location = new System.Drawing.Point(235, 358);
            this.feesBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.feesBox.Name = "feesBox";
            this.feesBox.Size = new System.Drawing.Size(120, 27);
            this.feesBox.TabIndex = 25;
            this.feesBox.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fees: ";
            // 
            // updateClassBtn
            // 
            this.updateClassBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateClassBtn.AutoSize = true;
            this.updateClassBtn.BackColor = System.Drawing.Color.Green;
            this.updateClassBtn.FlatAppearance.BorderSize = 0;
            this.updateClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateClassBtn.ForeColor = System.Drawing.Color.White;
            this.updateClassBtn.Location = new System.Drawing.Point(390, 443);
            this.updateClassBtn.Name = "updateClassBtn";
            this.updateClassBtn.Size = new System.Drawing.Size(80, 23);
            this.updateClassBtn.TabIndex = 22;
            this.updateClassBtn.Text = "Update Class";
            this.updateClassBtn.UseVisualStyleBackColor = false;
            this.updateClassBtn.Click += new System.EventHandler(this.updateClassBtn_Click);
            // 
            // teacherCb
            // 
            this.teacherCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teacherCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherCb.FormattingEnabled = true;
            this.teacherCb.Location = new System.Drawing.Point(199, 300);
            this.teacherCb.Name = "teacherCb";
            this.teacherCb.Size = new System.Drawing.Size(456, 27);
            this.teacherCb.TabIndex = 21;
            // 
            // sectionCb
            // 
            this.sectionCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sectionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionCb.FormattingEnabled = true;
            this.sectionCb.Items.AddRange(new object[] {
            "Crech",
            "Nursury",
            "KG",
            "Lower Primary",
            "Upper Primary",
            "JHS"});
            this.sectionCb.Location = new System.Drawing.Point(199, 238);
            this.sectionCb.Name = "sectionCb";
            this.sectionCb.Size = new System.Drawing.Size(456, 27);
            this.sectionCb.TabIndex = 20;
            // 
            // capacityTb
            // 
            this.capacityTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacityTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTb.Location = new System.Drawing.Point(199, 185);
            this.capacityTb.Name = "capacityTb";
            this.capacityTb.Size = new System.Drawing.Size(456, 27);
            this.capacityTb.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Capacity: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Section: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teacher: ";
            // 
            // nameTb
            // 
            this.nameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(199, 126);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(456, 27);
            this.nameTb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "UPDATE CLASSROOM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class Name: ";
            // 
            // UpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 540);
            this.Controls.Add(this.bgPanel);
            this.Name = "UpdateClass";
            this.Text = "UpdateClass";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown feesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateClassBtn;
        private System.Windows.Forms.ComboBox teacherCb;
        private System.Windows.Forms.ComboBox sectionCb;
        private System.Windows.Forms.TextBox capacityTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}