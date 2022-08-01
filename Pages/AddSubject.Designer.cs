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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.bgPanel = new System.Windows.Forms.Panel();
            this.subjectDataView = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_total_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_total_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.classPercentageLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classTotalMarksTB = new System.Windows.Forms.TextBox();
            this.passMarksTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.examPercentageTB = new System.Windows.Forms.TextBox();
            this.examTotalMarkTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataView)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.subjectDataView);
            this.bgPanel.Controls.Add(this.topPanel);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(912, 677);
            this.bgPanel.TabIndex = 0;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectDataView.DefaultCellStyle = dataGridViewCellStyle16;
            this.subjectDataView.EnableHeadersVisualStyles = false;
            this.subjectDataView.Location = new System.Drawing.Point(3, 205);
            this.subjectDataView.Name = "subjectDataView";
            this.subjectDataView.ReadOnly = true;
            this.subjectDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.subjectDataView.RowHeadersWidth = 18;
            this.subjectDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Snow;
            this.subjectDataView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.subjectDataView.RowTemplate.Height = 30;
            this.subjectDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subjectDataView.ShowEditingIcon = false;
            this.subjectDataView.Size = new System.Drawing.Size(906, 469);
            this.subjectDataView.TabIndex = 5;
            this.subjectDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataView_CellContentClick);
            // 
            // subject_id
            // 
            this.subject_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subject_id.DataPropertyName = "subject_id";
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subject_id.DefaultCellStyle = dataGridViewCellStyle11;
            this.subject_id.HeaderText = "ID";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subject_id.Width = 57;
            // 
            // subject_name
            // 
            this.subject_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject_name.DataPropertyName = "name";
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subject_name.DefaultCellStyle = dataGridViewCellStyle12;
            this.subject_name.HeaderText = "SUBJECT NAME";
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            this.subject_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // exam_total_marks
            // 
            this.exam_total_marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exam_total_marks.DataPropertyName = "exam_total_marks";
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exam_total_marks.DefaultCellStyle = dataGridViewCellStyle13;
            this.exam_total_marks.HeaderText = "EXAM TOTAL MARKS";
            this.exam_total_marks.Name = "exam_total_marks";
            this.exam_total_marks.ReadOnly = true;
            this.exam_total_marks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exam_total_marks.Width = 189;
            // 
            // pass_marks
            // 
            this.pass_marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pass_marks.DataPropertyName = "pass_marks";
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pass_marks.DefaultCellStyle = dataGridViewCellStyle14;
            this.pass_marks.HeaderText = "PASS MARKS";
            this.pass_marks.Name = "pass_marks";
            this.pass_marks.ReadOnly = true;
            this.pass_marks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pass_marks.Width = 135;
            // 
            // exam_percentage
            // 
            this.exam_percentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exam_percentage.DataPropertyName = "exam_percentage";
            this.exam_percentage.HeaderText = "EXAM %";
            this.exam_percentage.Name = "exam_percentage";
            this.exam_percentage.ReadOnly = true;
            this.exam_percentage.Width = 98;
            // 
            // class_total_marks
            // 
            this.class_total_marks.DataPropertyName = "class_total_marks";
            this.class_total_marks.HeaderText = "CLASS TOTAL MARKS";
            this.class_total_marks.Name = "class_total_marks";
            this.class_total_marks.ReadOnly = true;
            // 
            // class_percentage
            // 
            this.class_percentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.class_percentage.DataPropertyName = "class_percentage";
            this.class_percentage.HeaderText = "CLASS %";
            this.class_percentage.Name = "class_percentage";
            this.class_percentage.ReadOnly = true;
            this.class_percentage.Width = 105;
            // 
            // delete
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            this.delete.DefaultCellStyle = dataGridViewCellStyle15;
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.label10);
            this.topPanel.Controls.Add(this.label9);
            this.topPanel.Controls.Add(this.label7);
            this.topPanel.Controls.Add(this.label8);
            this.topPanel.Controls.Add(this.classPercentageLB);
            this.topPanel.Controls.Add(this.label6);
            this.topPanel.Controls.Add(this.classTotalMarksTB);
            this.topPanel.Controls.Add(this.passMarksTB);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.saveBtn);
            this.topPanel.Controls.Add(this.examPercentageTB);
            this.topPanel.Controls.Add(this.examTotalMarkTB);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.subjectNameTB);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(912, 193);
            this.topPanel.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(823, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "/100";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Pass Marks:";
            // 
            // classPercentageLB
            // 
            this.classPercentageLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classPercentageLB.AutoSize = true;
            this.classPercentageLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classPercentageLB.Location = new System.Drawing.Point(480, 125);
            this.classPercentageLB.Name = "classPercentageLB";
            this.classPercentageLB.Size = new System.Drawing.Size(25, 19);
            this.classPercentageLB.TabIndex = 13;
            this.classPercentageLB.Text = "00";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class Percentage: ";
            // 
            // classTotalMarksTB
            // 
            this.classTotalMarksTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classTotalMarksTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classTotalMarksTB.Location = new System.Drawing.Point(213, 122);
            this.classTotalMarksTB.Name = "classTotalMarksTB";
            this.classTotalMarksTB.Size = new System.Drawing.Size(100, 27);
            this.classTotalMarksTB.TabIndex = 11;
            // 
            // passMarksTB
            // 
            this.passMarksTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passMarksTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passMarksTB.Location = new System.Drawing.Point(717, 122);
            this.passMarksTB.Name = "passMarksTB";
            this.passMarksTB.Size = new System.Drawing.Size(100, 27);
            this.passMarksTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class Total Marks: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "ADD SUBJECT";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(423, 158);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // examPercentageTB
            // 
            this.examPercentageTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.examPercentageTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examPercentageTB.Location = new System.Drawing.Point(480, 84);
            this.examPercentageTB.Name = "examPercentageTB";
            this.examPercentageTB.Size = new System.Drawing.Size(100, 27);
            this.examPercentageTB.TabIndex = 6;
            this.examPercentageTB.TextChanged += new System.EventHandler(this.examPercentageTB_TextChanged);
            // 
            // examTotalMarkTB
            // 
            this.examTotalMarkTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.examTotalMarkTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTotalMarkTB.Location = new System.Drawing.Point(213, 88);
            this.examTotalMarkTB.Name = "examTotalMarkTB";
            this.examTotalMarkTB.Size = new System.Drawing.Size(100, 27);
            this.examTotalMarkTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exam Percentage: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exam Total Marks: ";
            // 
            // subjectNameTB
            // 
            this.subjectNameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectNameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameTB.Location = new System.Drawing.Point(213, 48);
            this.subjectNameTB.Name = "subjectNameTB";
            this.subjectNameTB.Size = new System.Drawing.Size(604, 27);
            this.subjectNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(101, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name: ";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 677);
            this.Controls.Add(this.bgPanel);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataView)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox examPercentageTB;
        private System.Windows.Forms.TextBox examTotalMarkTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectDataView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label classPercentageLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox classTotalMarksTB;
        private System.Windows.Forms.TextBox passMarksTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_total_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_total_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_percentage;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}