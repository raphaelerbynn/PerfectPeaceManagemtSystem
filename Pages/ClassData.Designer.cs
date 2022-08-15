namespace Perfect_Peace_System.Pages
{
    partial class ClassData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showDataPanel = new System.Windows.Forms.Panel();
            this.classDataView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.refeshBtn = new System.Windows.Forms.Button();
            this.showDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // showDataPanel
            // 
            this.showDataPanel.Controls.Add(this.refeshBtn);
            this.showDataPanel.Controls.Add(this.classDataView);
            this.showDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataPanel.Location = new System.Drawing.Point(0, 0);
            this.showDataPanel.Name = "showDataPanel";
            this.showDataPanel.Size = new System.Drawing.Size(800, 450);
            this.showDataPanel.TabIndex = 0;
            // 
            // classDataView
            // 
            this.classDataView.AllowUserToAddRows = false;
            this.classDataView.AllowUserToDeleteRows = false;
            this.classDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.classDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.classDataView.ColumnHeadersHeight = 30;
            this.classDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.classDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.teacher_id,
            this.name,
            this.section,
            this.capacity,
            this.teacher,
            this.fees,
            this.view,
            this.edit,
            this.delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.classDataView.EnableHeadersVisualStyles = false;
            this.classDataView.Location = new System.Drawing.Point(0, 40);
            this.classDataView.Name = "classDataView";
            this.classDataView.ReadOnly = true;
            this.classDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.classDataView.RowHeadersVisible = false;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.classDataView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.classDataView.RowTemplate.Height = 30;
            this.classDataView.Size = new System.Drawing.Size(800, 410);
            this.classDataView.TabIndex = 0;
            this.classDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDataView_CellContentClick);
            this.classDataView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.classDataView_DataError);
            // 
            // id
            // 
            this.id.DataPropertyName = "class_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // teacher_id
            // 
            this.teacher_id.DataPropertyName = "teacher_id";
            this.teacher_id.HeaderText = "TEACHER ID";
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            this.teacher_id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "CLASS NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // section
            // 
            this.section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.section.DataPropertyName = "section";
            this.section.HeaderText = "SECTION";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "CAPACITY";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher.DataPropertyName = "teacher";
            this.teacher.HeaderText = "TEACHER";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // fees
            // 
            this.fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fees.DataPropertyName = "fees";
            this.fees.HeaderText = "FEES";
            this.fees.Name = "fees";
            this.fees.ReadOnly = true;
            this.fees.Width = 89;
            // 
            // view
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.view.DefaultCellStyle = dataGridViewCellStyle2;
            this.view.HeaderText = "";
            this.view.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.view.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Visible = false;
            this.view.Width = 38;
            // 
            // edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.edit.HeaderText = "";
            this.edit.Image = global::Perfect_Peace_System.Properties.Resources.update;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 38;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.HeaderText = "";
            this.delete.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 38;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Perfect_Peace_System.Properties.Resources.update;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // refeshBtn
            // 
            this.refeshBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.refeshBtn.FlatAppearance.BorderSize = 0;
            this.refeshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refeshBtn.Location = new System.Drawing.Point(12, 12);
            this.refeshBtn.Name = "refeshBtn";
            this.refeshBtn.Size = new System.Drawing.Size(75, 23);
            this.refeshBtn.TabIndex = 7;
            this.refeshBtn.Text = "Refresh";
            this.refeshBtn.UseVisualStyleBackColor = false;
            this.refeshBtn.Click += new System.EventHandler(this.refeshBtn_Click);
            // 
            // ClassData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDataPanel);
            this.Name = "ClassData";
            this.Text = "ClassData";
            this.showDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showDataPanel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridView classDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn fees;
        private System.Windows.Forms.DataGridViewImageColumn view;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button refeshBtn;
    }
}