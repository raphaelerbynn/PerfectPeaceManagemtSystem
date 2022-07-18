namespace Perfect_Peace_System.Pages
{
    partial class Create
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salaryBasedPanel = new System.Windows.Forms.Panel();
            this.salaryBaseDataView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSalary = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deleteSalary = new System.Windows.Forms.DataGridViewImageColumn();
            this.salaryBasedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBaseDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryBasedPanel
            // 
            this.salaryBasedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryBasedPanel.AutoScroll = true;
            this.salaryBasedPanel.Controls.Add(this.salaryBaseDataView);
            this.salaryBasedPanel.Controls.Add(this.label4);
            this.salaryBasedPanel.Location = new System.Drawing.Point(9, 52);
            this.salaryBasedPanel.Name = "salaryBasedPanel";
            this.salaryBasedPanel.Size = new System.Drawing.Size(923, 573);
            this.salaryBasedPanel.TabIndex = 2;
            this.salaryBasedPanel.Visible = false;
            // 
            // salaryBaseDataView
            // 
            this.salaryBaseDataView.AllowUserToAddRows = false;
            this.salaryBaseDataView.AllowUserToDeleteRows = false;
            this.salaryBaseDataView.AllowUserToOrderColumns = true;
            this.salaryBaseDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryBaseDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryBaseDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salaryBaseDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryBaseDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salaryBaseDataView.ColumnHeadersHeight = 30;
            this.salaryBaseDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salaryBaseDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacher_id,
            this.employee_name,
            this.employee_mail,
            this.amountSalary,
            this.deleteSalary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salaryBaseDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.salaryBaseDataView.EnableHeadersVisualStyles = false;
            this.salaryBaseDataView.Location = new System.Drawing.Point(3, 174);
            this.salaryBaseDataView.Name = "salaryBaseDataView";
            this.salaryBaseDataView.ReadOnly = true;
            this.salaryBaseDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryBaseDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.salaryBaseDataView.RowHeadersWidth = 18;
            this.salaryBaseDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Snow;
            this.salaryBaseDataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.salaryBaseDataView.RowTemplate.Height = 30;
            this.salaryBaseDataView.ShowEditingIcon = false;
            this.salaryBaseDataView.Size = new System.Drawing.Size(917, 390);
            this.salaryBaseDataView.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employee Salary";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // teacher_id
            // 
            this.teacher_id.DataPropertyName = "teacher_id";
            this.teacher_id.HeaderText = "ID";
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            this.teacher_id.Visible = false;
            // 
            // employee_name
            // 
            this.employee_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employee_name.DataPropertyName = "name";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employee_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.employee_name.HeaderText = "NAME";
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            this.employee_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // employee_mail
            // 
            this.employee_mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employee_mail.DataPropertyName = "email";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employee_mail.DefaultCellStyle = dataGridViewCellStyle3;
            this.employee_mail.HeaderText = "E-MAIL";
            this.employee_mail.Name = "employee_mail";
            this.employee_mail.ReadOnly = true;
            // 
            // amountSalary
            // 
            this.amountSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountSalary.DataPropertyName = "amount";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.amountSalary.DefaultCellStyle = dataGridViewCellStyle4;
            this.amountSalary.HeaderText = "SALARY BASE";
            this.amountSalary.Name = "amountSalary";
            this.amountSalary.ReadOnly = true;
            this.amountSalary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amountSalary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteSalary
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            this.deleteSalary.DefaultCellStyle = dataGridViewCellStyle5;
            this.deleteSalary.FillWeight = 30F;
            this.deleteSalary.HeaderText = "";
            this.deleteSalary.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.deleteSalary.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.deleteSalary.Name = "deleteSalary";
            this.deleteSalary.ReadOnly = true;
            this.deleteSalary.Width = 50;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 677);
            this.Controls.Add(this.salaryBasedPanel);
            this.Name = "Create";
            this.Text = "Create";
            this.salaryBasedPanel.ResumeLayout(false);
            this.salaryBasedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBaseDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel salaryBasedPanel;
        private System.Windows.Forms.DataGridView salaryBaseDataView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_mail;
        private System.Windows.Forms.DataGridViewComboBoxColumn amountSalary;
        private System.Windows.Forms.DataGridViewImageColumn deleteSalary;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}