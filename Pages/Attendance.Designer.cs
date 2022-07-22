﻿namespace Perfect_Peace_System.Pages
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.classCb = new System.Windows.Forms.ComboBox();
            this.checkAttendanceDataView = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.present_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.absent_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.todayDateLbl = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.saveAttendanceBtn = new System.Windows.Forms.Button();
            this.attendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAttendanceDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // attendancePanel
            // 
            this.attendancePanel.AutoScroll = true;
            this.attendancePanel.Controls.Add(this.saveAttendanceBtn);
            this.attendancePanel.Controls.Add(this.label1);
            this.attendancePanel.Controls.Add(this.classCb);
            this.attendancePanel.Controls.Add(this.checkAttendanceDataView);
            this.attendancePanel.Controls.Add(this.todayDateLbl);
            this.attendancePanel.Controls.Add(this.label32);
            this.attendancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancePanel.Location = new System.Drawing.Point(0, 0);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.attendancePanel.Size = new System.Drawing.Size(878, 684);
            this.attendancePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Class:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCb
            // 
            this.classCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCb.FormattingEnabled = true;
            this.classCb.Location = new System.Drawing.Point(66, 85);
            this.classCb.Name = "classCb";
            this.classCb.Size = new System.Drawing.Size(153, 21);
            this.classCb.TabIndex = 47;
            this.classCb.TextChanged += new System.EventHandler(this.classCb_TextChanged);
            // 
            // checkAttendanceDataView
            // 
            this.checkAttendanceDataView.AllowUserToAddRows = false;
            this.checkAttendanceDataView.AllowUserToDeleteRows = false;
            this.checkAttendanceDataView.AllowUserToOrderColumns = true;
            this.checkAttendanceDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAttendanceDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkAttendanceDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.checkAttendanceDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkAttendanceDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.checkAttendanceDataView.ColumnHeadersHeight = 30;
            this.checkAttendanceDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.checkAttendanceDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.student_roll,
            this.student_name,
            this.present_check,
            this.absent_check});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkAttendanceDataView.DefaultCellStyle = dataGridViewCellStyle10;
            this.checkAttendanceDataView.EnableHeadersVisualStyles = false;
            this.checkAttendanceDataView.Location = new System.Drawing.Point(0, 112);
            this.checkAttendanceDataView.Name = "checkAttendanceDataView";
            this.checkAttendanceDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkAttendanceDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.checkAttendanceDataView.RowHeadersWidth = 18;
            this.checkAttendanceDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Snow;
            this.checkAttendanceDataView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.checkAttendanceDataView.RowTemplate.Height = 30;
            this.checkAttendanceDataView.ShowEditingIcon = false;
            this.checkAttendanceDataView.Size = new System.Drawing.Size(872, 510);
            this.checkAttendanceDataView.TabIndex = 46;
            this.checkAttendanceDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkAttendanceDataView_CellContentClick);
            // 
            // student_id
            // 
            this.student_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "ID";
            this.student_id.Name = "student_id";
            this.student_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.student_id.Visible = false;
            this.student_id.Width = 59;
            // 
            // student_roll
            // 
            this.student_roll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.student_roll.DataPropertyName = "roll_id";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.student_roll.DefaultCellStyle = dataGridViewCellStyle8;
            this.student_roll.HeaderText = "ROLL";
            this.student_roll.Name = "student_roll";
            this.student_roll.ReadOnly = true;
            this.student_roll.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.student_roll.Width = 84;
            // 
            // student_name
            // 
            this.student_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_name.DataPropertyName = "name";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.student_name.DefaultCellStyle = dataGridViewCellStyle9;
            this.student_name.HeaderText = "NAME";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // present_check
            // 
            this.present_check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.present_check.HeaderText = "PRESENT";
            this.present_check.Name = "present_check";
            this.present_check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.present_check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.present_check.Width = 119;
            // 
            // absent_check
            // 
            this.absent_check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.absent_check.HeaderText = "ABSENT";
            this.absent_check.Name = "absent_check";
            this.absent_check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.absent_check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.absent_check.Width = 106;
            // 
            // todayDateLbl
            // 
            this.todayDateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todayDateLbl.AutoSize = true;
            this.todayDateLbl.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDateLbl.Location = new System.Drawing.Point(484, 34);
            this.todayDateLbl.Name = "todayDateLbl";
            this.todayDateLbl.Size = new System.Drawing.Size(60, 24);
            this.todayDateLbl.TabIndex = 45;
            this.todayDateLbl.Text = "(date)";
            this.todayDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(297, 34);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(192, 24);
            this.label32.TabIndex = 45;
            this.label32.Text = "Attendance for today ";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveAttendanceBtn
            // 
            this.saveAttendanceBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveAttendanceBtn.AutoSize = true;
            this.saveAttendanceBtn.Location = new System.Drawing.Point(372, 628);
            this.saveAttendanceBtn.Name = "saveAttendanceBtn";
            this.saveAttendanceBtn.Size = new System.Drawing.Size(100, 23);
            this.saveAttendanceBtn.TabIndex = 49;
            this.saveAttendanceBtn.Text = "Save Attendance";
            this.saveAttendanceBtn.UseVisualStyleBackColor = true;
            this.saveAttendanceBtn.Click += new System.EventHandler(this.saveAttendanceBtn_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 684);
            this.Controls.Add(this.attendancePanel);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.attendancePanel.ResumeLayout(false);
            this.attendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAttendanceDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label todayDateLbl;
        private System.Windows.Forms.DataGridView checkAttendanceDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn present_check;
        private System.Windows.Forms.DataGridViewCheckBoxColumn absent_check;
        private System.Windows.Forms.Button saveAttendanceBtn;
    }
}