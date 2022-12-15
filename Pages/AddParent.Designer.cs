namespace Perfect_Peace_System.Pages
{
    partial class AddParent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bpPanel = new System.Windows.Forms.Panel();
            this.clearFeildBtn = new System.Windows.Forms.Button();
            this.registerParent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.number_exercises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home_assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reading_assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topics_covered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bpPanel
            // 
            this.bpPanel.Controls.Add(this.dataGridView1);
            this.bpPanel.Controls.Add(this.clearFeildBtn);
            this.bpPanel.Controls.Add(this.registerParent);
            this.bpPanel.Controls.Add(this.label8);
            this.bpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpPanel.Location = new System.Drawing.Point(0, 0);
            this.bpPanel.Name = "bpPanel";
            this.bpPanel.Size = new System.Drawing.Size(939, 627);
            this.bpPanel.TabIndex = 0;
            // 
            // clearFeildBtn
            // 
            this.clearFeildBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearFeildBtn.AutoSize = true;
            this.clearFeildBtn.BackColor = System.Drawing.Color.DarkRed;
            this.clearFeildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFeildBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFeildBtn.ForeColor = System.Drawing.Color.White;
            this.clearFeildBtn.Location = new System.Drawing.Point(489, 571);
            this.clearFeildBtn.Name = "clearFeildBtn";
            this.clearFeildBtn.Size = new System.Drawing.Size(112, 31);
            this.clearFeildBtn.TabIndex = 14;
            this.clearFeildBtn.Text = "Clear";
            this.clearFeildBtn.UseVisualStyleBackColor = false;
            this.clearFeildBtn.Click += new System.EventHandler(this.clearFeild_Click);
            // 
            // registerParent
            // 
            this.registerParent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerParent.AutoSize = true;
            this.registerParent.BackColor = System.Drawing.Color.DarkGreen;
            this.registerParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerParent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerParent.ForeColor = System.Drawing.Color.White;
            this.registerParent.Location = new System.Drawing.Point(339, 571);
            this.registerParent.Name = "registerParent";
            this.registerParent.Size = new System.Drawing.Size(121, 31);
            this.registerParent.TabIndex = 13;
            this.registerParent.Text = "Register Parent";
            this.registerParent.UseVisualStyleBackColor = false;
            this.registerParent.Click += new System.EventHandler(this.registerParent_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "PARENT DETAILS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.number_exercises,
            this.home_assignment,
            this.diction,
            this.project_work,
            this.reading_assignment,
            this.topics_covered,
            this.group_work});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(23, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(896, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subject.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.subject.HeaderText = "SUBJECT";
            this.subject.Name = "subject";
            this.subject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subject.Width = 90;
            // 
            // number_exercises
            // 
            this.number_exercises.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.number_exercises.DefaultCellStyle = dataGridViewCellStyle2;
            this.number_exercises.HeaderText = "NO OF EXERCISES";
            this.number_exercises.Name = "number_exercises";
            this.number_exercises.Width = 136;
            // 
            // home_assignment
            // 
            this.home_assignment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.home_assignment.HeaderText = "HOME ASSIGNMENTS";
            this.home_assignment.Name = "home_assignment";
            this.home_assignment.Width = 158;
            // 
            // diction
            // 
            this.diction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diction.HeaderText = "DICTATIONS";
            this.diction.Name = "diction";
            this.diction.Width = 112;
            // 
            // project_work
            // 
            this.project_work.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.project_work.HeaderText = "PROJECT WORKS";
            this.project_work.Name = "project_work";
            this.project_work.Width = 133;
            // 
            // reading_assignment
            // 
            this.reading_assignment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.reading_assignment.HeaderText = "READING ASSIGNMENTS";
            this.reading_assignment.Name = "reading_assignment";
            this.reading_assignment.Width = 174;
            // 
            // topics_covered
            // 
            this.topics_covered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.topics_covered.HeaderText = "TOPICS COVERED";
            this.topics_covered.Name = "topics_covered";
            this.topics_covered.Width = 136;
            // 
            // group_work
            // 
            this.group_work.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.group_work.HeaderText = "GROUP WORKS";
            this.group_work.Name = "group_work";
            this.group_work.Width = 124;
            // 
            // AddParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 627);
            this.Controls.Add(this.bpPanel);
            this.Name = "AddParent";
            this.bpPanel.ResumeLayout(false);
            this.bpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bpPanel;
        private System.Windows.Forms.Button clearFeildBtn;
        private System.Windows.Forms.Button registerParent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_exercises;
        private System.Windows.Forms.DataGridViewTextBoxColumn home_assignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn diction;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_work;
        private System.Windows.Forms.DataGridViewTextBoxColumn reading_assignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn topics_covered;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_work;
    }
}