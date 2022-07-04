namespace Perfect_Peace_System.Pages
{
    partial class AddSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.examPercentageTB = new System.Windows.Forms.TextBox();
            this.examTotalMarkTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passMarksTB = new System.Windows.Forms.TextBox();
            this.classTotalMarksTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classPercentageLB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.class_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_total_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_total_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subjectDataView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 677);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.classPercentageLB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.classTotalMarksTB);
            this.panel2.Controls.Add(this.passMarksTB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.examPercentageTB);
            this.panel2.Controls.Add(this.examTotalMarkTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.subjectNameTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 193);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add Subject";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveBtn.Location = new System.Drawing.Point(423, 158);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // examPercentageTB
            // 
            this.examPercentageTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.examPercentageTB.Location = new System.Drawing.Point(480, 84);
            this.examPercentageTB.Name = "examPercentageTB";
            this.examPercentageTB.Size = new System.Drawing.Size(100, 20);
            this.examPercentageTB.TabIndex = 6;
            // 
            // examTotalMarkTB
            // 
            this.examTotalMarkTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.examTotalMarkTB.Location = new System.Drawing.Point(213, 88);
            this.examTotalMarkTB.Name = "examTotalMarkTB";
            this.examTotalMarkTB.Size = new System.Drawing.Size(100, 20);
            this.examTotalMarkTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exam Percentage: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exam Total Marks: ";
            // 
            // subjectNameTB
            // 
            this.subjectNameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectNameTB.Location = new System.Drawing.Point(213, 48);
            this.subjectNameTB.Name = "subjectNameTB";
            this.subjectNameTB.Size = new System.Drawing.Size(563, 20);
            this.subjectNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(112, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class Total Marks: ";
            // 
            // passMarksTB
            // 
            this.passMarksTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passMarksTB.Location = new System.Drawing.Point(676, 122);
            this.passMarksTB.Name = "passMarksTB";
            this.passMarksTB.Size = new System.Drawing.Size(100, 20);
            this.passMarksTB.TabIndex = 10;
            // 
            // classTotalMarksTB
            // 
            this.classTotalMarksTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classTotalMarksTB.Location = new System.Drawing.Point(213, 122);
            this.classTotalMarksTB.Name = "classTotalMarksTB";
            this.classTotalMarksTB.Size = new System.Drawing.Size(100, 20);
            this.classTotalMarksTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class Percentage: ";
            // 
            // classPercentageLB
            // 
            this.classPercentageLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classPercentageLB.AutoSize = true;
            this.classPercentageLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classPercentageLB.Location = new System.Drawing.Point(480, 125);
            this.classPercentageLB.Name = "classPercentageLB";
            this.classPercentageLB.Size = new System.Drawing.Size(41, 18);
            this.classPercentageLB.TabIndex = 13;
            this.classPercentageLB.Text = "00 %";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Pass Marks:";
            // 
            // delete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            this.delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // class_percentage
            // 
            this.class_percentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.class_percentage.HeaderText = "CLASS %";
            this.class_percentage.Name = "class_percentage";
            this.class_percentage.ReadOnly = true;
            this.class_percentage.Width = 105;
            // 
            // class_total_marks
            // 
            this.class_total_marks.HeaderText = "CLASS TOTAL MARKS";
            this.class_total_marks.Name = "class_total_marks";
            this.class_total_marks.ReadOnly = true;
            // 
            // exam_percentage
            // 
            this.exam_percentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exam_percentage.HeaderText = "EXAM %";
            this.exam_percentage.Name = "exam_percentage";
            this.exam_percentage.ReadOnly = true;
            this.exam_percentage.Width = 98;
            // 
            // pass_marks
            // 
            this.pass_marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pass_marks.DataPropertyName = "pass_marks";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pass_marks.DefaultCellStyle = dataGridViewCellStyle5;
            this.pass_marks.HeaderText = "PASS MARKS";
            this.pass_marks.Name = "pass_marks";
            this.pass_marks.ReadOnly = true;
            this.pass_marks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pass_marks.Width = 135;
            // 
            // exam_total_marks
            // 
            this.exam_total_marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exam_total_marks.DataPropertyName = "exam_total_marks";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exam_total_marks.DefaultCellStyle = dataGridViewCellStyle4;
            this.exam_total_marks.HeaderText = "EXAM TOTAL MARKS";
            this.exam_total_marks.Name = "exam_total_marks";
            this.exam_total_marks.ReadOnly = true;
            this.exam_total_marks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exam_total_marks.Width = 189;
            // 
            // subject_name
            // 
            this.subject_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject_name.DataPropertyName = "name";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subject_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.subject_name.HeaderText = "SUBJECT NAME";
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            this.subject_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subject_id
            // 
            this.subject_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subject_id.DataPropertyName = "subject_id";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subject_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.subject_id.HeaderText = "ID";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subject_id.Width = 57;
            // 
            // subjectDataView
            // 
            this.subjectDataView.AllowUserToAddRows = false;
            this.subjectDataView.AllowUserToDeleteRows = false;
            this.subjectDataView.AllowUserToOrderColumns = true;
            this.subjectDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.subjectDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subjectDataView.ColumnHeadersHeight = 40;
            this.subjectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.subjectDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subject_name,
            this.exam_total_marks,
            this.pass_marks,
            this.exam_percentage,
            this.class_total_marks,
            this.class_percentage,
            this.delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectDataView.DefaultCellStyle = dataGridViewCellStyle7;
            this.subjectDataView.EnableHeadersVisualStyles = false;
            this.subjectDataView.Location = new System.Drawing.Point(12, 205);
            this.subjectDataView.Name = "subjectDataView";
            this.subjectDataView.ReadOnly = true;
            this.subjectDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.subjectDataView.RowHeadersWidth = 18;
            this.subjectDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Snow;
            this.subjectDataView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.subjectDataView.RowTemplate.Height = 30;
            this.subjectDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subjectDataView.ShowEditingIcon = false;
            this.subjectDataView.Size = new System.Drawing.Size(891, 460);
            this.subjectDataView.TabIndex = 5;
            this.subjectDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataView_CellContentClick);
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 677);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox examPercentageTB;
        private System.Windows.Forms.TextBox examTotalMarkTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_total_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_total_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_percentage;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label classPercentageLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox classTotalMarksTB;
        private System.Windows.Forms.TextBox passMarksTB;
        private System.Windows.Forms.Label label5;
    }
}