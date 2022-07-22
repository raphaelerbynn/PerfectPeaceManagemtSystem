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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.attendanceDatePk = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.classCb = new System.Windows.Forms.ComboBox();
            this.attendanceDataView = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.loadAttendanceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalAbsentLbl = new System.Windows.Forms.Label();
            this.totalPresentLbl = new System.Windows.Forms.Label();
            this.student_roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAttendanceBtn = new System.Windows.Forms.Button();
            this.attendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // attendancePanel
            // 
            this.attendancePanel.AutoScroll = true;
            this.attendancePanel.Controls.Add(this.checkAttendanceBtn);
            this.attendancePanel.Controls.Add(this.loadAttendanceBtn);
            this.attendancePanel.Controls.Add(this.attendanceDatePk);
            this.attendancePanel.Controls.Add(this.label3);
            this.attendancePanel.Controls.Add(this.totalPresentLbl);
            this.attendancePanel.Controls.Add(this.totalAbsentLbl);
            this.attendancePanel.Controls.Add(this.label2);
            this.attendancePanel.Controls.Add(this.label1);
            this.attendancePanel.Controls.Add(this.classCb);
            this.attendancePanel.Controls.Add(this.attendanceDataView);
            this.attendancePanel.Controls.Add(this.label32);
            this.attendancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancePanel.Location = new System.Drawing.Point(0, 0);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.attendancePanel.Size = new System.Drawing.Size(833, 703);
            this.attendancePanel.TabIndex = 3;
            // 
            // attendanceDatePk
            // 
            this.attendanceDatePk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.attendanceDatePk.CustomFormat = "";
            this.attendanceDatePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.attendanceDatePk.Location = new System.Drawing.Point(508, 40);
            this.attendanceDatePk.Name = "attendanceDatePk";
            this.attendanceDatePk.Size = new System.Drawing.Size(200, 20);
            this.attendanceDatePk.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Class:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCb
            // 
            this.classCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCb.FormattingEnabled = true;
            this.classCb.Location = new System.Drawing.Point(142, 38);
            this.classCb.Name = "classCb";
            this.classCb.Size = new System.Drawing.Size(153, 21);
            this.classCb.TabIndex = 47;
            // 
            // attendanceDataView
            // 
            this.attendanceDataView.AllowUserToAddRows = false;
            this.attendanceDataView.AllowUserToDeleteRows = false;
            this.attendanceDataView.AllowUserToOrderColumns = true;
            this.attendanceDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attendanceDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendanceDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.attendanceDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.attendanceDataView.ColumnHeadersHeight = 30;
            this.attendanceDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.attendanceDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_roll,
            this.student_name,
            this.status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attendanceDataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.attendanceDataView.EnableHeadersVisualStyles = false;
            this.attendanceDataView.Location = new System.Drawing.Point(3, 165);
            this.attendanceDataView.Name = "attendanceDataView";
            this.attendanceDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.attendanceDataView.RowHeadersWidth = 18;
            this.attendanceDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            this.attendanceDataView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.attendanceDataView.RowTemplate.Height = 30;
            this.attendanceDataView.ShowEditingIcon = false;
            this.attendanceDataView.Size = new System.Drawing.Size(826, 538);
            this.attendanceDataView.TabIndex = 46;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(364, 40);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(138, 19);
            this.label32.TabIndex = 45;
            this.label32.Text = "Date of attendance:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadAttendanceBtn
            // 
            this.loadAttendanceBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadAttendanceBtn.AutoSize = true;
            this.loadAttendanceBtn.Location = new System.Drawing.Point(353, 85);
            this.loadAttendanceBtn.Name = "loadAttendanceBtn";
            this.loadAttendanceBtn.Size = new System.Drawing.Size(99, 23);
            this.loadAttendanceBtn.TabIndex = 50;
            this.loadAttendanceBtn.Text = "Load Attendance";
            this.loadAttendanceBtn.UseVisualStyleBackColor = true;
            this.loadAttendanceBtn.Click += new System.EventHandler(this.loadAttendanceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Total Present:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Total Absent:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAbsentLbl
            // 
            this.totalAbsentLbl.AutoSize = true;
            this.totalAbsentLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAbsentLbl.Location = new System.Drawing.Point(112, 143);
            this.totalAbsentLbl.Name = "totalAbsentLbl";
            this.totalAbsentLbl.Size = new System.Drawing.Size(17, 19);
            this.totalAbsentLbl.TabIndex = 48;
            this.totalAbsentLbl.Text = "0";
            this.totalAbsentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPresentLbl
            // 
            this.totalPresentLbl.AutoSize = true;
            this.totalPresentLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPresentLbl.Location = new System.Drawing.Point(116, 119);
            this.totalPresentLbl.Name = "totalPresentLbl";
            this.totalPresentLbl.Size = new System.Drawing.Size(17, 19);
            this.totalPresentLbl.TabIndex = 48;
            this.totalPresentLbl.Text = "0";
            this.totalPresentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // student_roll
            // 
            this.student_roll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.student_roll.DataPropertyName = "student_id";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.student_roll.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.student_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.student_name.HeaderText = "NAME";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // checkAttendanceBtn
            // 
            this.checkAttendanceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAttendanceBtn.AutoSize = true;
            this.checkAttendanceBtn.Location = new System.Drawing.Point(715, 136);
            this.checkAttendanceBtn.Name = "checkAttendanceBtn";
            this.checkAttendanceBtn.Size = new System.Drawing.Size(106, 23);
            this.checkAttendanceBtn.TabIndex = 50;
            this.checkAttendanceBtn.Text = "Check Attendance";
            this.checkAttendanceBtn.UseVisualStyleBackColor = true;
            this.checkAttendanceBtn.Click += new System.EventHandler(this.checkAttendanceBtn_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 703);
            this.Controls.Add(this.attendancePanel);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.attendancePanel.ResumeLayout(false);
            this.attendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classCb;
        private System.Windows.Forms.DataGridView attendanceDataView;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker attendanceDatePk;
        private System.Windows.Forms.Button loadAttendanceBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPresentLbl;
        private System.Windows.Forms.Label totalAbsentLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button checkAttendanceBtn;
    }
}