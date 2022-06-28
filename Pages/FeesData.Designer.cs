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
            this.panel1 = new System.Windows.Forms.Panel();
            this.feesDataView = new System.Windows.Forms.DataGridView();
            this.fee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.feesDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // feesDataView
            // 
            this.feesDataView.AllowUserToAddRows = false;
            this.feesDataView.AllowUserToDeleteRows = false;
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
            this.view});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.feesDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.feesDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feesDataView.EnableHeadersVisualStyles = false;
            this.feesDataView.Location = new System.Drawing.Point(0, 0);
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
            this.feesDataView.Size = new System.Drawing.Size(800, 450);
            this.feesDataView.TabIndex = 1;
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
            this.student_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.student_name.DataPropertyName = "student";
            this.student_name.HeaderText = "STUDENT NAME";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Width = 176;
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
            this.payment_mode.Width = 179;
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
            this.date_paid.Width = 131;
            // 
            // view
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.view.DefaultCellStyle = dataGridViewCellStyle2;
            this.view.FillWeight = 30F;
            this.view.HeaderText = "";
            this.view.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.view.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Width = 50;
            // 
            // FeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FeesData";
            this.Text = "FeesData";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feesDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView feesDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _class;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_paid;
        private System.Windows.Forms.DataGridViewImageColumn view;
    }
}