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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelBg = new System.Windows.Forms.Panel();
            this.usersBtn = new System.Windows.Forms.Button();
            this.termBtn = new System.Windows.Forms.Button();
            this.feesPanel = new System.Windows.Forms.Panel();
            this.feesListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.feesLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.classChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eventPanel = new System.Windows.Forms.Panel();
            this.eventListView = new System.Windows.Forms.ListView();
            this.eventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventLink = new System.Windows.Forms.LinkLabel();
            this.classPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotoalRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalTeachers = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalStnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.feesPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classChart)).BeginInit();
            this.eventPanel.SuspendLayout();
            this.classPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.teacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelBg.Controls.Add(this.usersBtn);
            this.panelBg.Controls.Add(this.termBtn);
            this.panelBg.Controls.Add(this.feesPanel);
            this.panelBg.Controls.Add(this.panel3);
            this.panelBg.Controls.Add(this.eventPanel);
            this.panelBg.Controls.Add(this.classPanel);
            this.panelBg.Controls.Add(this.teacherPanel);
            this.panelBg.Controls.Add(this.studentPanel);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(941, 642);
            this.panelBg.TabIndex = 0;
            // 
            // usersBtn
            // 
            this.usersBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.usersBtn.BackColor = System.Drawing.Color.DarkRed;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.ForeColor = System.Drawing.Color.White;
            this.usersBtn.Location = new System.Drawing.Point(514, 607);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(75, 23);
            this.usersBtn.TabIndex = 7;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Visible = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // termBtn
            // 
            this.termBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.termBtn.BackColor = System.Drawing.Color.DarkRed;
            this.termBtn.FlatAppearance.BorderSize = 0;
            this.termBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termBtn.ForeColor = System.Drawing.Color.White;
            this.termBtn.Location = new System.Drawing.Point(401, 607);
            this.termBtn.Name = "termBtn";
            this.termBtn.Size = new System.Drawing.Size(75, 23);
            this.termBtn.TabIndex = 7;
            this.termBtn.Text = "Term Details";
            this.termBtn.UseVisualStyleBackColor = false;
            this.termBtn.Visible = false;
            this.termBtn.Click += new System.EventHandler(this.termBtn_Click);
            // 
            // feesPanel
            // 
            this.feesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feesPanel.BackColor = System.Drawing.Color.DimGray;
            this.feesPanel.Controls.Add(this.feesListView);
            this.feesPanel.Controls.Add(this.feesLbl);
            this.feesPanel.Location = new System.Drawing.Point(510, 97);
            this.feesPanel.Name = "feesPanel";
            this.feesPanel.Size = new System.Drawing.Size(414, 487);
            this.feesPanel.TabIndex = 2;
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
            this.feesListView.Location = new System.Drawing.Point(4, 23);
            this.feesListView.Name = "feesListView";
            this.feesListView.Size = new System.Drawing.Size(406, 461);
            this.feesListView.TabIndex = 3;
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
            this.fees.Text = "Fees (Ghc)";
            this.fees.Width = 112;
            // 
            // feesLbl
            // 
            this.feesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feesLbl.AutoSize = true;
            this.feesLbl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLbl.Location = new System.Drawing.Point(156, 2);
            this.feesLbl.Name = "feesLbl";
            this.feesLbl.Size = new System.Drawing.Size(120, 18);
            this.feesLbl.TabIndex = 1;
            this.feesLbl.Text = "Those Owing Fees";
            this.feesLbl.Click += new System.EventHandler(this.classPanel_Click);
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
            this.panel3.Size = new System.Drawing.Size(482, 282);
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
            this.classChart.Size = new System.Drawing.Size(482, 279);
            this.classChart.TabIndex = 0;
            this.classChart.Text = "chart1";
            this.classChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // eventPanel
            // 
            this.eventPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventPanel.BackColor = System.Drawing.Color.Silver;
            this.eventPanel.Controls.Add(this.eventListView);
            this.eventPanel.Controls.Add(this.eventLink);
            this.eventPanel.Location = new System.Drawing.Point(12, 385);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.Size = new System.Drawing.Size(482, 203);
            this.eventPanel.TabIndex = 1;
            this.eventPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            this.eventListView.Location = new System.Drawing.Point(2, 25);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(477, 174);
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
            // eventLink
            // 
            this.eventLink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventLink.AutoSize = true;
            this.eventLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLink.Location = new System.Drawing.Point(224, 3);
            this.eventLink.Name = "eventLink";
            this.eventLink.Size = new System.Drawing.Size(54, 19);
            this.eventLink.TabIndex = 0;
            this.eventLink.TabStop = true;
            this.eventLink.Text = "Events";
            this.eventLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eventLink_LinkClicked);
            // 
            // classPanel
            // 
            this.classPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classPanel.BackColor = System.Drawing.Color.Transparent;
            this.classPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("classPanel.BackgroundImage")));
            this.classPanel.Controls.Add(this.pictureBox3);
            this.classPanel.Controls.Add(this.lblTotoalRooms);
            this.classPanel.Controls.Add(this.label2);
            this.classPanel.Location = new System.Drawing.Point(634, 11);
            this.classPanel.Name = "classPanel";
            this.classPanel.Size = new System.Drawing.Size(290, 67);
            this.classPanel.TabIndex = 1;
            this.classPanel.Click += new System.EventHandler(this.classPanel_Click);
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
            // teacherPanel
            // 
            this.teacherPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teacherPanel.BackColor = System.Drawing.Color.Transparent;
            this.teacherPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teacherPanel.BackgroundImage")));
            this.teacherPanel.Controls.Add(this.pictureBox2);
            this.teacherPanel.Controls.Add(this.label3);
            this.teacherPanel.Controls.Add(this.lbltotalTeachers);
            this.teacherPanel.Location = new System.Drawing.Point(324, 11);
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Size = new System.Drawing.Size(290, 67);
            this.teacherPanel.TabIndex = 1;
            this.teacherPanel.Click += new System.EventHandler(this.teacherPanel_Click);
            this.teacherPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.teacherPanel_Paint);
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
            // studentPanel
            // 
            this.studentPanel.BackColor = System.Drawing.Color.Transparent;
            this.studentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentPanel.BackgroundImage")));
            this.studentPanel.Controls.Add(this.pictureBox1);
            this.studentPanel.Controls.Add(this.lblTotalStnt);
            this.studentPanel.Controls.Add(this.label1);
            this.studentPanel.Location = new System.Drawing.Point(12, 12);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(290, 67);
            this.studentPanel.TabIndex = 0;
            this.studentPanel.Click += new System.EventHandler(this.studentPanel_Click);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 642);
            this.Controls.Add(this.panelBg);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelBg.ResumeLayout(false);
            this.feesPanel.ResumeLayout(false);
            this.feesPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classChart)).EndInit();
            this.eventPanel.ResumeLayout(false);
            this.eventPanel.PerformLayout();
            this.classPanel.ResumeLayout(false);
            this.classPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.teacherPanel.ResumeLayout(false);
            this.teacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel eventPanel;
        private System.Windows.Forms.Panel classPanel;
        private System.Windows.Forms.Panel teacherPanel;
        private System.Windows.Forms.Panel studentPanel;
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
        private System.Windows.Forms.LinkLabel eventLink;
        private System.Windows.Forms.Panel feesPanel;
        private System.Windows.Forms.ListView feesListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader student_class;
        private System.Windows.Forms.ColumnHeader fees;
        private System.Windows.Forms.Label feesLbl;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button termBtn;
    }
}