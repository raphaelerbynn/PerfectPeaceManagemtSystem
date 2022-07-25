namespace Perfect_Peace_System.Pages
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelBg = new System.Windows.Forms.Panel();
            this.feesPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.classChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventListView = new System.Windows.Forms.ListView();
            this.eventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotoalRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalTeachers = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalStnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feesLink = new System.Windows.Forms.LinkLabel();
            this.feesListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventLink = new System.Windows.Forms.LinkLabel();
            this.panelBg.SuspendLayout();
            this.feesPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classChart)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelBg.Controls.Add(this.feesPanel);
            this.panelBg.Controls.Add(this.panel3);
            this.panelBg.Controls.Add(this.panel4);
            this.panelBg.Controls.Add(this.panel5);
            this.panelBg.Controls.Add(this.panel6);
            this.panelBg.Controls.Add(this.panel2);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(941, 588);
            this.panelBg.TabIndex = 0;
            // 
            // feesPanel
            // 
            this.feesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feesPanel.AutoSize = true;
            this.feesPanel.BackColor = System.Drawing.Color.Silver;
            this.feesPanel.Controls.Add(this.feesListView);
            this.feesPanel.Controls.Add(this.feesLink);
            this.feesPanel.Location = new System.Drawing.Point(512, 97);
            this.feesPanel.Name = "feesPanel";
            this.feesPanel.Size = new System.Drawing.Size(417, 479);
            this.feesPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.classChart);
            this.panel3.Location = new System.Drawing.Point(12, 97);
            this.panel3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 270);
            this.panel3.TabIndex = 1;
            // 
            // classChart
            // 
            this.classChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.classChart.BackSecondaryColor = System.Drawing.Color.White;
            this.classChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.classChart.BorderlineWidth = 0;
            this.classChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.classChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.classChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.classChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisX.IsStartedFromZero = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea6.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea6.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.Title = "Class name";
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.IsMarksNextToAxis = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea6.AxisY.LineWidth = 0;
            chartArea6.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea6.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea6.AxisY.ScaleBreakStyle.Spacing = 1D;
            chartArea6.AxisY.Title = "Number of students";
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea6.BorderColor = System.Drawing.Color.Transparent;
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.classChart.ChartAreas.Add(chartArea6);
            legend6.ItemColumnSpacing = 100;
            legend6.Name = "Legend1";
            this.classChart.Legends.Add(legend6);
            this.classChart.Location = new System.Drawing.Point(0, 0);
            this.classChart.Name = "classChart";
            this.classChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series6.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series6.BorderColor = System.Drawing.Color.Transparent;
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series6.BorderWidth = 0;
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            series6.IsValueShownAsLabel = true;
            series6.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series6.LabelBorderWidth = 0;
            series6.Legend = "Legend1";
            series6.MarkerSize = 0;
            series6.Name = "Class";
            series6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.classChart.Series.Add(series6);
            this.classChart.Size = new System.Drawing.Size(482, 270);
            this.classChart.TabIndex = 0;
            this.classChart.Text = "chart1";
            this.classChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.eventListView);
            this.panel4.Controls.Add(this.eventLink);
            this.panel4.Location = new System.Drawing.Point(12, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 203);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // eventListView
            // 
            this.eventListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventName,
            this.eventDate,
            this.eventTime});
            this.eventListView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListView.HideSelection = false;
            this.eventListView.Location = new System.Drawing.Point(6, 33);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(469, 158);
            this.eventListView.TabIndex = 4;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            // 
            // eventName
            // 
            this.eventName.Text = "Name";
            this.eventName.Width = 210;
            // 
            // eventDate
            // 
            this.eventDate.Text = "Date";
            this.eventDate.Width = 130;
            // 
            // eventTime
            // 
            this.eventTime.Text = "Time";
            this.eventTime.Width = 130;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.lblTotoalRooms);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(634, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 67);
            this.panel5.TabIndex = 1;
            this.panel5.Click += new System.EventHandler(this.classPanel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Perfect_Peace_System.Properties.Resources.classroom_dash;
            this.pictureBox3.Location = new System.Drawing.Point(21, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.classPanel_Click);
            // 
            // lblTotoalRooms
            // 
            this.lblTotoalRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotoalRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotoalRooms.Location = new System.Drawing.Point(153, 28);
            this.lblTotoalRooms.Name = "lblTotoalRooms";
            this.lblTotoalRooms.Size = new System.Drawing.Size(123, 35);
            this.lblTotoalRooms.TabIndex = 3;
            this.lblTotoalRooms.Text = "0";
            this.lblTotoalRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotoalRooms.Click += new System.EventHandler(this.classPanel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Classrooms";
            this.label2.Click += new System.EventHandler(this.classPanel_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lbltotalTeachers);
            this.panel6.Location = new System.Drawing.Point(324, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 67);
            this.panel6.TabIndex = 1;
            this.panel6.Click += new System.EventHandler(this.teacherPanel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Perfect_Peace_System.Properties.Resources.teacher_dash;
            this.pictureBox2.Location = new System.Drawing.Point(23, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.teacherPanel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Staffs";
            this.label3.Click += new System.EventHandler(this.teacherPanel_Click);
            // 
            // lbltotalTeachers
            // 
            this.lbltotalTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalTeachers.Location = new System.Drawing.Point(153, 26);
            this.lbltotalTeachers.Name = "lbltotalTeachers";
            this.lbltotalTeachers.Size = new System.Drawing.Size(123, 37);
            this.lbltotalTeachers.TabIndex = 2;
            this.lbltotalTeachers.Text = "0";
            this.lbltotalTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbltotalTeachers.Click += new System.EventHandler(this.teacherPanel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTotalStnt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 67);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.studentPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Perfect_Peace_System.Properties.Resources.student_boy_dash;
            this.pictureBox1.Location = new System.Drawing.Point(26, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.studentPanel_Click);
            // 
            // lblTotalStnt
            // 
            this.lblTotalStnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalStnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStnt.Location = new System.Drawing.Point(155, 26);
            this.lblTotalStnt.Name = "lblTotalStnt";
            this.lblTotalStnt.Size = new System.Drawing.Size(123, 37);
            this.lblTotalStnt.TabIndex = 1;
            this.lblTotalStnt.Text = "0";
            this.lblTotalStnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalStnt.Click += new System.EventHandler(this.studentPanel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Students";
            this.label1.Click += new System.EventHandler(this.studentPanel_Click);
            // 
            // feesLink
            // 
            this.feesLink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feesLink.AutoSize = true;
            this.feesLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLink.Location = new System.Drawing.Point(139, 12);
            this.feesLink.Name = "feesLink";
            this.feesLink.Size = new System.Drawing.Size(130, 19);
            this.feesLink.TabIndex = 0;
            this.feesLink.TabStop = true;
            this.feesLink.Text = "Those Owing Fees";
            // 
            // feesListView
            // 
            this.feesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.student_class,
            this.fees});
            this.feesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesListView.HideSelection = false;
            this.feesListView.Location = new System.Drawing.Point(12, 38);
            this.feesListView.Name = "feesListView";
            this.feesListView.Size = new System.Drawing.Size(393, 429);
            this.feesListView.TabIndex = 1;
            this.feesListView.TileSize = new System.Drawing.Size(170, 30);
            this.feesListView.UseCompatibleStateImageBehavior = false;
            this.feesListView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 220;
            // 
            // student_class
            // 
            this.student_class.Text = "Class";
            this.student_class.Width = 120;
            // 
            // fees
            // 
            this.fees.Text = "Fees";
            this.fees.Width = 112;
            // 
            // eventLink
            // 
            this.eventLink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventLink.AutoSize = true;
            this.eventLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLink.Location = new System.Drawing.Point(224, 11);
            this.eventLink.Name = "eventLink";
            this.eventLink.Size = new System.Drawing.Size(54, 19);
            this.eventLink.TabIndex = 0;
            this.eventLink.TabStop = true;
            this.eventLink.Text = "Events";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 588);
            this.Controls.Add(this.panelBg);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            this.feesPanel.ResumeLayout(false);
            this.feesPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classChart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel feesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotoalRooms;
        private System.Windows.Forms.Label lbltotalTeachers;
        private System.Windows.Forms.Label lblTotalStnt;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader eventName;
        private System.Windows.Forms.ColumnHeader eventDate;
        private System.Windows.Forms.ColumnHeader eventTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart classChart;
        private System.Windows.Forms.LinkLabel feesLink;
        private System.Windows.Forms.ListView feesListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader student_class;
        private System.Windows.Forms.ColumnHeader fees;
        private System.Windows.Forms.LinkLabel eventLink;
    }
}