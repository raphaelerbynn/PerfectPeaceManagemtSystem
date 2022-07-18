namespace Perfect_Peace_System.Pages
{
    partial class Payroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.payrollPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentBtn = new System.Windows.Forms.Panel();
            this.empSalaryBtn = new System.Windows.Forms.Panel();
            this.salaryBaseBtn = new System.Windows.Forms.Panel();
            this.salaryBaseLbl = new System.Windows.Forms.Label();
            this.empSalaryLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addSalaryBtn = new System.Windows.Forms.Button();
            this.salaryBasedPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryBaseDataView = new System.Windows.Forms.DataGridView();
            this.salary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteSalary = new System.Windows.Forms.DataGridViewImageColumn();
            this.payrollPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paymentBtn.SuspendLayout();
            this.empSalaryBtn.SuspendLayout();
            this.salaryBaseBtn.SuspendLayout();
            this.salaryBasedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBaseDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // payrollPanel
            // 
            this.payrollPanel.AutoScroll = true;
            this.payrollPanel.Controls.Add(this.salaryBasedPanel);
            this.payrollPanel.Controls.Add(this.panel1);
            this.payrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollPanel.Location = new System.Drawing.Point(0, 0);
            this.payrollPanel.Name = "payrollPanel";
            this.payrollPanel.Size = new System.Drawing.Size(923, 650);
            this.payrollPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.addSalaryBtn);
            this.panel1.Controls.Add(this.paymentBtn);
            this.panel1.Controls.Add(this.empSalaryBtn);
            this.panel1.Controls.Add(this.salaryBaseBtn);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 74);
            this.panel1.TabIndex = 0;
            // 
            // paymentBtn
            // 
            this.paymentBtn.Controls.Add(this.label3);
            this.paymentBtn.Location = new System.Drawing.Point(453, 34);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(200, 40);
            this.paymentBtn.TabIndex = 3;
            // 
            // empSalaryBtn
            // 
            this.empSalaryBtn.Controls.Add(this.empSalaryLbl);
            this.empSalaryBtn.Location = new System.Drawing.Point(238, 34);
            this.empSalaryBtn.Name = "empSalaryBtn";
            this.empSalaryBtn.Size = new System.Drawing.Size(200, 40);
            this.empSalaryBtn.TabIndex = 3;
            // 
            // salaryBaseBtn
            // 
            this.salaryBaseBtn.Controls.Add(this.salaryBaseLbl);
            this.salaryBaseBtn.Location = new System.Drawing.Point(21, 34);
            this.salaryBaseBtn.Name = "salaryBaseBtn";
            this.salaryBaseBtn.Size = new System.Drawing.Size(200, 40);
            this.salaryBaseBtn.TabIndex = 3;
            this.salaryBaseBtn.Click += new System.EventHandler(this.salaryBaseBtn_Click);
            // 
            // salaryBaseLbl
            // 
            this.salaryBaseLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salaryBaseLbl.AutoSize = true;
            this.salaryBaseLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBaseLbl.Location = new System.Drawing.Point(55, 12);
            this.salaryBaseLbl.Name = "salaryBaseLbl";
            this.salaryBaseLbl.Size = new System.Drawing.Size(84, 19);
            this.salaryBaseLbl.TabIndex = 0;
            this.salaryBaseLbl.Text = "Salary Base";
            this.salaryBaseLbl.Click += new System.EventHandler(this.salaryBaseBtn_Click);
            // 
            // empSalaryLbl
            // 
            this.empSalaryLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empSalaryLbl.AutoSize = true;
            this.empSalaryLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSalaryLbl.Location = new System.Drawing.Point(44, 12);
            this.empSalaryLbl.Name = "empSalaryLbl";
            this.empSalaryLbl.Size = new System.Drawing.Size(115, 19);
            this.empSalaryLbl.TabIndex = 0;
            this.empSalaryLbl.Text = "Employee Salary";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salary Payment";
            // 
            // addSalaryBtn
            // 
            this.addSalaryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSalaryBtn.Location = new System.Drawing.Point(822, 45);
            this.addSalaryBtn.Name = "addSalaryBtn";
            this.addSalaryBtn.Size = new System.Drawing.Size(75, 23);
            this.addSalaryBtn.TabIndex = 4;
            this.addSalaryBtn.Text = "Add Salary";
            this.addSalaryBtn.UseVisualStyleBackColor = true;
            this.addSalaryBtn.Visible = false;
            this.addSalaryBtn.Click += new System.EventHandler(this.addSalaryBtn_Click);
            // 
            // salaryBasedPanel
            // 
            this.salaryBasedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryBasedPanel.AutoScroll = true;
            this.salaryBasedPanel.Controls.Add(this.salaryBaseDataView);
            this.salaryBasedPanel.Controls.Add(this.label4);
            this.salaryBasedPanel.Location = new System.Drawing.Point(3, 74);
            this.salaryBasedPanel.Name = "salaryBasedPanel";
            this.salaryBasedPanel.Size = new System.Drawing.Size(923, 573);
            this.salaryBasedPanel.TabIndex = 1;
            this.salaryBasedPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salary Details";
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
            this.salary_id,
            this.salaryTitle,
            this.salaryRank,
            this.grossAmount,
            this.netSalary,
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
            this.salaryBaseDataView.Location = new System.Drawing.Point(3, 78);
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
            this.salaryBaseDataView.Size = new System.Drawing.Size(917, 486);
            this.salaryBaseDataView.TabIndex = 34;
            this.salaryBaseDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryBaseDataView_CellContentClick);
            // 
            // salary_id
            // 
            this.salary_id.DataPropertyName = "salary_id";
            this.salary_id.HeaderText = "ID";
            this.salary_id.Name = "salary_id";
            this.salary_id.ReadOnly = true;
            this.salary_id.Visible = false;
            // 
            // salaryTitle
            // 
            this.salaryTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salaryTitle.DataPropertyName = "title";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salaryTitle.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryTitle.HeaderText = "TITLE";
            this.salaryTitle.Name = "salaryTitle";
            this.salaryTitle.ReadOnly = true;
            this.salaryTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // salaryRank
            // 
            this.salaryRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salaryRank.DataPropertyName = "rank";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salaryRank.DefaultCellStyle = dataGridViewCellStyle3;
            this.salaryRank.HeaderText = "RANK";
            this.salaryRank.Name = "salaryRank";
            this.salaryRank.ReadOnly = true;
            // 
            // grossAmount
            // 
            this.grossAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.grossAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.grossAmount.HeaderText = "GROSS AMOUNT";
            this.grossAmount.Name = "grossAmount";
            this.grossAmount.ReadOnly = true;
            // 
            // netSalary
            // 
            this.netSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.netSalary.HeaderText = "NET AMOUNT";
            this.netSalary.Name = "netSalary";
            this.netSalary.ReadOnly = true;
            // 
            // amountSalary
            // 
            this.amountSalary.DataPropertyName = "amount";
            this.amountSalary.HeaderText = "AMOUNT";
            this.amountSalary.Name = "amountSalary";
            this.amountSalary.ReadOnly = true;
            this.amountSalary.Visible = false;
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
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 650);
            this.Controls.Add(this.payrollPanel);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.payrollPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paymentBtn.ResumeLayout(false);
            this.paymentBtn.PerformLayout();
            this.empSalaryBtn.ResumeLayout(false);
            this.empSalaryBtn.PerformLayout();
            this.salaryBaseBtn.ResumeLayout(false);
            this.salaryBaseBtn.PerformLayout();
            this.salaryBasedPanel.ResumeLayout(false);
            this.salaryBasedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBaseDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel payrollPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paymentBtn;
        private System.Windows.Forms.Panel empSalaryBtn;
        private System.Windows.Forms.Panel salaryBaseBtn;
        private System.Windows.Forms.Panel salaryBasedPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSalaryBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label empSalaryLbl;
        private System.Windows.Forms.Label salaryBaseLbl;
        private System.Windows.Forms.DataGridView salaryBaseDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountSalary;
        private System.Windows.Forms.DataGridViewImageColumn deleteSalary;
    }
}