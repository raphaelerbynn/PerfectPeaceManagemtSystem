namespace Perfect_Peace_System.Pages
{
    partial class EventData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventData));
            this.bgPanel = new System.Windows.Forms.Panel();
            this.addEventLink = new System.Windows.Forms.LinkLabel();
            this.eventDataView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.addEventLink);
            this.bgPanel.Controls.Add(this.eventDataView);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(811, 508);
            this.bgPanel.TabIndex = 0;
            // 
            // addEventLink
            // 
            this.addEventLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addEventLink.AutoSize = true;
            this.addEventLink.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventLink.Location = new System.Drawing.Point(730, 9);
            this.addEventLink.Name = "addEventLink";
            this.addEventLink.Size = new System.Drawing.Size(69, 17);
            this.addEventLink.TabIndex = 2;
            this.addEventLink.TabStop = true;
            this.addEventLink.Text = "Add Event";
            this.addEventLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addEventLink_LinkClicked);
            // 
            // eventDataView
            // 
            this.eventDataView.AllowUserToAddRows = false;
            this.eventDataView.AllowUserToDeleteRows = false;
            this.eventDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eventDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eventDataView.ColumnHeadersHeight = 30;
            this.eventDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.eventDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.event_name,
            this.name,
            this.date,
            this.time,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eventDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.eventDataView.EnableHeadersVisualStyles = false;
            this.eventDataView.Location = new System.Drawing.Point(0, 28);
            this.eventDataView.Name = "eventDataView";
            this.eventDataView.ReadOnly = true;
            this.eventDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.eventDataView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.eventDataView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.eventDataView.RowTemplate.Height = 30;
            this.eventDataView.Size = new System.Drawing.Size(811, 480);
            this.eventDataView.TabIndex = 1;
            this.eventDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDataView_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "event_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // event_name
            // 
            this.event_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.event_name.DataPropertyName = "name";
            this.event_name.HeaderText = "EVENT";
            this.event_name.Name = "event_name";
            this.event_name.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "description";
            this.name.HeaderText = "DESCRIPTION";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 89;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 85;
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Perfect_Peace_System.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 38;
            // 
            // EventData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 508);
            this.Controls.Add(this.bgPanel);
            this.Name = "EventData";
            this.Text = "EventData";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.DataGridView eventDataView;
        private System.Windows.Forms.LinkLabel addEventLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}