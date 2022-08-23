namespace Perfect_Peace_System.Pages
{
    partial class FeesData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeesData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCb = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.feesDataView = new System.Windows.Forms.DataGridView();
            this.fee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.refeshBtn = new System.Windows.Forms.Button();
            this.bgPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.topPanel);
            this.bgPanel.Controls.Add(this.feesDataView);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(1035, 620);
            this.bgPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.refeshBtn);
            this.topPanel.Controls.Add(this.searchBtn);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.searchCb);
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Location = new System.Drawing.Point(3, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1032, 59);
            this.topPanel.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(911, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "By:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // searchCb
            // 
            this.searchCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCb.FormattingEnabled = true;
            this.searchCb.Items.AddRange(new object[] {
            "Student Name",
            "Class",
            "Payment Mode",
            "Date Paid"});
            this.searchCb.Location = new System.Drawing.Point(574, 33);
            this.searchCb.Name = "searchCb";
            this.searchCb.Size = new System.Drawing.Size(121, 23);
            this.searchCb.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(701, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(204, 24);
            this.searchTextBox.TabIndex = 0;
            // 
            // feesDataView
            // 
            this.feesDataView.AllowUserToAddRows = false;
            this.feesDataView.AllowUserToDeleteRows = false;
            this.feesDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feesDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feesDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.feesDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feesDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.feesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feesDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fee_id,
            this.student_name,
            this._class,
            this.amount,
            this.payment_mode,
            this.remaining,
            this.date_paid,
            this.term,
            this.print,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.feesDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.feesDataView.EnableHeadersVisualStyles = false;
            this.feesDataView.Location = new System.Drawing.Point(2, 57);
            this.feesDataView.Name = "feesDataView";
            this.feesDataView.ReadOnly = true;
            this.feesDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feesDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.feesDataView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.feesDataView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.feesDataView.RowTemplate.Height = 30;
            this.feesDataView.Size = new System.Drawing.Size(1032, 562);
            this.feesDataView.TabIndex = 1;
            this.feesDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feesDataView_CellContentClick);
            // 
            // fee_id
            // 
            this.fee_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fee_id.DataPropertyName = "fee_id";
            this.fee_id.HeaderText = "ID";
            this.fee_id.Name = "fee_id";
            this.fee_id.ReadOnly = true;
            this.fee_id.Width = 62;
            // 
            // student_name
            // 
            this.student_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_name.DataPropertyName = "student";
            this.student_name.HeaderText = "STUDENT NAME";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            // 
            // _class
            // 
            this._class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._class.DataPropertyName = "class";
            this._class.HeaderText = "CLASS";
            this._class.Name = "_class";
            this._class.ReadOnly = true;
            this._class.Width = 99;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.DataPropertyName = "paid";
            this.amount.HeaderText = "AMOUNT";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 117;
            // 
            // payment_mode
            // 
            this.payment_mode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.payment_mode.DataPropertyName = "payment_mode";
            this.payment_mode.HeaderText = "PAYMENT MODE";
            this.payment_mode.Name = "payment_mode";
            this.payment_mode.ReadOnly = true;
            this.payment_mode.Width = 164;
            // 
            // remaining
            // 
            this.remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.remaining.DataPropertyName = "remaining";
            this.remaining.HeaderText = "OWING";
            this.remaining.Name = "remaining";
            this.remaining.ReadOnly = true;
            this.remaining.Width = 104;
            // 
            // date_paid
            // 
            this.date_paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_paid.DataPropertyName = "date_paid";
            this.date_paid.HeaderText = "DATE PAID";
            this.date_paid.Name = "date_paid";
            this.date_paid.ReadOnly = true;
            this.date_paid.Width = 121;
            // 
            // term
            // 
            this.term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.term.DataPropertyName = "term";
            this.term.HeaderText = "TERM";
            this.term.Name = "term";
            this.term.ReadOnly = true;
            this.term.Width = 93;
            // 
            // print
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.print.DefaultCellStyle = dataGridViewCellStyle2;
            this.print.FillWeight = 30F;
            this.print.HeaderText = "";
            this.print.Image = global::Perfect_Peace_System.Properties.Resources.printer;
            this.print.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.Width = 38;
            // 
            // delete
            // 
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 38;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 38;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 30F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 38;
            // 
            // refeshBtn
            // 
            this.refeshBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.refeshBtn.FlatAppearance.BorderSize = 0;
            this.refeshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refeshBtn.Location = new System.Drawing.Point(4, 32);
            this.refeshBtn.Name = "refeshBtn";
            this.refeshBtn.Size = new System.Drawing.Size(75, 23);
            this.refeshBtn.TabIndex = 8;
            this.refeshBtn.Text = "Refresh";
            this.refeshBtn.UseVisualStyleBackColor = false;
            this.refeshBtn.Click += new System.EventHandler(this.refeshBtn_Click);
            // 
            // FeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 620);
            this.Controls.Add(this.bgPanel);
            this.Name = "FeesData";
            this.Text = "FeesData";
            this.bgPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchCb;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView feesDataView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _class;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
        private System.Windows.Forms.DataGridViewImageColumn print;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button refeshBtn;
    }
}