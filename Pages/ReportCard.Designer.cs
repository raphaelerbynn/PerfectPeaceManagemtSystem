namespace Perfect_Peace_System.Pages
{
    partial class ReportCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultDataView = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position_in_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.resultDataView);
            this.panel1.Location = new System.Drawing.Point(38, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 510);
            this.panel1.TabIndex = 0;
            // 
            // resultDataView
            // 
            this.resultDataView.AllowUserToAddRows = false;
            this.resultDataView.AllowUserToDeleteRows = false;
            this.resultDataView.BackgroundColor = System.Drawing.Color.White;
            this.resultDataView.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subject,
            this.exam_score,
            this.class_score,
            this.total_score,
            this.position_in_subject,
            this.remarks});
            this.resultDataView.Location = new System.Drawing.Point(15, 142);
            this.resultDataView.MaximumSize = new System.Drawing.Size(700, 700);
            this.resultDataView.Name = "resultDataView";
            this.resultDataView.ReadOnly = true;
            this.resultDataView.RowHeadersVisible = false;
            this.resultDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.resultDataView.RowTemplate.Height = 30;
            this.resultDataView.Size = new System.Drawing.Size(689, 68);
            this.resultDataView.TabIndex = 0;
            this.resultDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "subject_id";
            this.subject_id.HeaderText = "SUBJECT ID";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.Visible = false;
            this.subject_id.Width = 5;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.DataPropertyName = "name";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject.DefaultCellStyle = dataGridViewCellStyle2;
            this.subject.HeaderText = "SUBJECT";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // exam_score
            // 
            this.exam_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exam_score.DefaultCellStyle = dataGridViewCellStyle3;
            this.exam_score.HeaderText = "EXAM SCORE 50%";
            this.exam_score.Name = "exam_score";
            this.exam_score.ReadOnly = true;
            // 
            // class_score
            // 
            this.class_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.class_score.DefaultCellStyle = dataGridViewCellStyle4;
            this.class_score.HeaderText = "CLASS SCORE 50%";
            this.class_score.Name = "class_score";
            this.class_score.ReadOnly = true;
            // 
            // total_score
            // 
            this.total_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.total_score.DefaultCellStyle = dataGridViewCellStyle5;
            this.total_score.HeaderText = "TOTAL SCORE 100%";
            this.total_score.Name = "total_score";
            this.total_score.ReadOnly = true;
            // 
            // position_in_subject
            // 
            this.position_in_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.position_in_subject.DefaultCellStyle = dataGridViewCellStyle6;
            this.position_in_subject.HeaderText = "POSITION IN SUBJECT";
            this.position_in_subject.Name = "position_in_subject";
            this.position_in_subject.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarks.HeaderText = "REMARKS";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // ReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.panel1);
            this.Name = "ReportCard";
            this.Text = "ReportCard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView resultDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn position_in_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}