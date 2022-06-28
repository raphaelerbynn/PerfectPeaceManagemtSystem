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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.IndianRed, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelBg = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
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
            this.panelBg.SuspendLayout();
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
            this.panelBg.Controls.Add(this.panel8);
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
            this.panelBg.Click += new System.EventHandler(this.panelBg_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Location = new System.Drawing.Point(12, 387);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(540, 184);
            this.panel8.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.classChart);
            this.panel3.Location = new System.Drawing.Point(12, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 284);
            this.panel3.TabIndex = 1;
            // 
            // classChart
            // 
            this.classChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.classChart.BackSecondaryColor = System.Drawing.Color.White;
            this.classChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.classChart.BorderlineWidth = 0;
            this.classChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.classChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.classChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.classChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Class name";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsMarksNextToAxis = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea1.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisY.Title = "Number of students";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.classChart.ChartAreas.Add(chartArea1);
            this.classChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.ItemColumnSpacing = 100;
            legend1.Name = "Legend1";
            this.classChart.Legends.Add(legend1);
            this.classChart.Location = new System.Drawing.Point(0, 0);
            this.classChart.Name = "classChart";
            this.classChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.MarkerSize = 0;
            series1.Name = "Class";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.classChart.Series.Add(series1);
            this.classChart.Size = new System.Drawing.Size(540, 284);
            this.classChart.TabIndex = 0;
            this.classChart.Text = "chart1";
            this.classChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.eventListView);
            this.panel4.Location = new System.Drawing.Point(571, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 474);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventName,
            this.eventDate,
            this.eventTime});
            this.eventListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventListView.HideSelection = false;
            this.eventListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.eventListView.Location = new System.Drawing.Point(0, 0);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(353, 167);
            this.eventListView.TabIndex = 4;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            // 
            // eventName
            // 
            this.eventName.Text = "Name";
            this.eventName.Width = 183;
            // 
            // eventDate
            // 
            this.eventDate.Text = "Date";
            this.eventDate.Width = 88;
            // 
            // eventTime
            // 
            this.eventTime.Text = "Time";
            this.eventTime.Width = 64;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.lblTotoalRooms);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(634, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 67);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Perfect_Peace_System.Properties.Resources.classroom_dash;
            this.pictureBox3.Location = new System.Drawing.Point(21, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotoalRooms
            // 
            this.lblTotoalRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotoalRooms.Location = new System.Drawing.Point(153, 28);
            this.lblTotoalRooms.Name = "lblTotoalRooms";
            this.lblTotoalRooms.Size = new System.Drawing.Size(123, 35);
            this.lblTotoalRooms.TabIndex = 3;
            this.lblTotoalRooms.Text = "0";
            this.lblTotoalRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Classrooms";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lbltotalTeachers);
            this.panel6.Location = new System.Drawing.Point(324, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 67);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Perfect_Peace_System.Properties.Resources.teacher_dash;
            this.pictureBox2.Location = new System.Drawing.Point(23, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Teachers";
            // 
            // lbltotalTeachers
            // 
            this.lbltotalTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalTeachers.Location = new System.Drawing.Point(153, 26);
            this.lbltotalTeachers.Name = "lbltotalTeachers";
            this.lbltotalTeachers.Size = new System.Drawing.Size(123, 37);
            this.lbltotalTeachers.TabIndex = 2;
            this.lbltotalTeachers.Text = "0";
            this.lbltotalTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Perfect_Peace_System.Properties.Resources.student_boy_dash;
            this.pictureBox1.Location = new System.Drawing.Point(26, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panelBg_Click);
            // 
            // lblTotalStnt
            // 
            this.lblTotalStnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStnt.Location = new System.Drawing.Point(155, 26);
            this.lblTotalStnt.Name = "lblTotalStnt";
            this.lblTotalStnt.Size = new System.Drawing.Size(123, 37);
            this.lblTotalStnt.TabIndex = 1;
            this.lblTotalStnt.Text = "0";
            this.lblTotalStnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalStnt.Click += new System.EventHandler(this.panelBg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Students";
            this.label1.Click += new System.EventHandler(this.panelBg_Click);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classChart)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel8;
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
    }
}