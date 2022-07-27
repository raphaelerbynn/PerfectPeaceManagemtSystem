namespace Perfect_Peace_System.Pages
{
    partial class StudentDataDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDataDisplay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showDataPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCb = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.studentDataView = new System.Windows.Forms.DataGridView();
            this.student_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fees_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.showDataPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // showDataPanel
            // 
            this.showDataPanel.Controls.Add(this.topPanel);
            this.showDataPanel.Controls.Add(this.studentDataView);
            this.showDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataPanel.Location = new System.Drawing.Point(0, 0);
            this.showDataPanel.Name = "showDataPanel";
            this.showDataPanel.Size = new System.Drawing.Size(1102, 704);
            this.showDataPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.searchBtn);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.searchCb);
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1102, 59);
            this.topPanel.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(1002, 11);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "By:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchCb
            // 
            this.searchCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCb.FormattingEnabled = true;
            this.searchCb.Items.AddRange(new object[] {
            "Name",
            "Age",
            "Class",
            "Gender"});
            this.searchCb.Location = new System.Drawing.Point(669, 9);
            this.searchCb.Name = "searchCb";
            this.searchCb.Size = new System.Drawing.Size(94, 27);
            this.searchCb.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(769, 9);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(227, 27);
            this.searchTextBox.TabIndex = 0;
            // 
            // studentDataView
            // 
            this.studentDataView.AllowUserToAddRows = false;
            this.studentDataView.AllowUserToDeleteRows = false;
            this.studentDataView.AllowUserToOrderColumns = true;
            this.studentDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentDataView.ColumnHeadersHeight = 30;
            this.studentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_Id,
            this.full_name,
            this.age,
            this._class,
            this.gender,
            this.fees_details,
            this.view,
            this.edit,
            this.delete});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDataView.DefaultCellStyle = dataGridViewCellStyle11;
            this.studentDataView.EnableHeadersVisualStyles = false;
            this.studentDataView.Location = new System.Drawing.Point(0, 56);
            this.studentDataView.Name = "studentDataView";
            this.studentDataView.ReadOnly = true;
            this.studentDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.studentDataView.RowHeadersWidth = 18;
            this.studentDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Snow;
            this.studentDataView.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.studentDataView.RowTemplate.Height = 30;
            this.studentDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentDataView.ShowEditingIcon = false;
            this.studentDataView.Size = new System.Drawing.Size(1102, 648);
            this.studentDataView.TabIndex = 4;
            this.studentDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataView_CellContentClick);
            // 
            // student_Id
            // 
            this.student_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.student_Id.DataPropertyName = "student_id";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.student_Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.student_Id.HeaderText = "ID";
            this.student_Id.Name = "student_Id";
            this.student_Id.ReadOnly = true;
            this.student_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.student_Id.Width = 57;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.full_name.DataPropertyName = "name";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.full_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.full_name.HeaderText = "NAME";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.DataPropertyName = "age";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.age.DefaultCellStyle = dataGridViewCellStyle4;
            this.age.HeaderText = "AGE";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.age.Width = 75;
            // 
            // _class
            // 
            this._class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._class.DataPropertyName = "class";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._class.DefaultCellStyle = dataGridViewCellStyle5;
            this._class.HeaderText = "CLASS";
            this._class.Name = "_class";
            this._class.ReadOnly = true;
            this._class.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._class.Width = 94;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "gender";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gender.DefaultCellStyle = dataGridViewCellStyle6;
            this.gender.HeaderText = "GENDER";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 112;
            // 
            // fees_details
            // 
            this.fees_details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fees_details.DataPropertyName = "fees_owing";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fees_details.DefaultCellStyle = dataGridViewCellStyle7;
            this.fees_details.HeaderText = "FEES";
            this.fees_details.Name = "fees_details";
            this.fees_details.ReadOnly = true;
            this.fees_details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fees_details.Width = 84;
            // 
            // view
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            this.view.DefaultCellStyle = dataGridViewCellStyle8;
            this.view.FillWeight = 30F;
            this.view.HeaderText = "";
            this.view.Image = global::Perfect_Peace_System.Properties.Resources.view;
            this.view.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Width = 50;
            // 
            // edit
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            this.edit.DefaultCellStyle = dataGridViewCellStyle9;
            this.edit.FillWeight = 30F;
            this.edit.HeaderText = "";
            this.edit.Image = global::Perfect_Peace_System.Properties.Resources.update;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 50;
            // 
            // delete
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            this.delete.DefaultCellStyle = dataGridViewCellStyle10;
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // StudentDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 704);
            this.Controls.Add(this.showDataPanel);
            this.Name = "StudentDataDisplay";
            this.showDataPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showDataPanel;
        private System.Windows.Forms.DataGridView studentDataView;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchCb;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn _class;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn fees_details;
        private System.Windows.Forms.DataGridViewImageColumn view;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}