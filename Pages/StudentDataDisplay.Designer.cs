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
            this.showDataPanel = new System.Windows.Forms.Panel();
            this.reloadDataBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // showDataPanel
            // 
            this.showDataPanel.Controls.Add(this.reloadDataBtn);
            this.showDataPanel.Controls.Add(this.studentDataView);
            this.showDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataPanel.Location = new System.Drawing.Point(0, 0);
            this.showDataPanel.Name = "showDataPanel";
            this.showDataPanel.Size = new System.Drawing.Size(800, 450);
            this.showDataPanel.TabIndex = 0;
            // 
            // reloadDataBtn
            // 
            this.reloadDataBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reloadDataBtn.Location = new System.Drawing.Point(0, 427);
            this.reloadDataBtn.Name = "reloadDataBtn";
            this.reloadDataBtn.Size = new System.Drawing.Size(800, 23);
            this.reloadDataBtn.TabIndex = 5;
            this.reloadDataBtn.Text = "Reload Data";
            this.reloadDataBtn.UseVisualStyleBackColor = true;
            // 
            // studentDataView
            // 
            this.studentDataView.AllowUserToAddRows = false;
            this.studentDataView.AllowUserToDeleteRows = false;
            this.studentDataView.AllowUserToOrderColumns = true;
            this.studentDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.studentDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.studentDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataView.Location = new System.Drawing.Point(0, 0);
            this.studentDataView.Name = "studentDataView";
            this.studentDataView.ReadOnly = true;
            this.studentDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentDataView.RowHeadersVisible = false;
            this.studentDataView.ShowEditingIcon = false;
            this.studentDataView.Size = new System.Drawing.Size(800, 450);
            this.studentDataView.TabIndex = 4;
            this.studentDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataView_CellContentClick);
            // 
            // student_Id
            // 
            this.student_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.student_Id.DataPropertyName = "student_id";
            this.student_Id.HeaderText = "ID";
            this.student_Id.Name = "student_Id";
            this.student_Id.ReadOnly = true;
            this.student_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.student_Id.Width = 43;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.full_name.DataPropertyName = "name";
            this.full_name.HeaderText = "NAME";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "AGE";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.age.Width = 54;
            // 
            // _class
            // 
            this._class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._class.DataPropertyName = "class";
            this._class.HeaderText = "CLASS";
            this._class.Name = "_class";
            this._class.ReadOnly = true;
            this._class.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._class.Width = 66;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 78;
            // 
            // fees_details
            // 
            this.fees_details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fees_details.DataPropertyName = "feesData";
            this.fees_details.HeaderText = "FEES";
            this.fees_details.Name = "fees_details";
            this.fees_details.ReadOnly = true;
            this.fees_details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fees_details.Width = 59;
            // 
            // view
            // 
            this.view.FillWeight = 30F;
            this.view.HeaderText = "";
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Width = 30;
            // 
            // edit
            // 
            this.edit.FillWeight = 30F;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 30;
            // 
            // delete
            // 
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 30;
            // 
            // StudentDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDataPanel);
            this.Name = "StudentDataDisplay";
            this.Text = "7";
            this.showDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showDataPanel;
        private System.Windows.Forms.Button reloadDataBtn;
        private System.Windows.Forms.DataGridView studentDataView;
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