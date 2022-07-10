namespace Perfect_Peace_System.Pages
{
    partial class ReportCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printBtn = new System.Windows.Forms.Button();
            this.reportCardPanel = new System.Windows.Forms.Panel();
            this.classLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.termLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.remarksPanel = new System.Windows.Forms.Panel();
            this.PtaLbl = new System.Windows.Forms.Label();
            this.extraClassesLbl = new System.Windows.Forms.Label();
            this.hRemarksLbl = new System.Windows.Forms.Label();
            this.tRemarksLbl = new System.Windows.Forms.Label();
            this.examsFeesLbl = new System.Windows.Forms.Label();
            this.totalFeesLbl = new System.Windows.Forms.Label();
            this.owingLbl = new System.Windows.Forms.Label();
            this.feesLbl = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.interestLbl = new System.Windows.Forms.Label();
            this.attitudeLbl = new System.Windows.Forms.Label();
            this.conductLbl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.rawScoreLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultDataView = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position_in_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.reportCardPanel.SuspendLayout();
            this.remarksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.printBtn);
            this.panel1.Controls.Add(this.reportCardPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 743);
            this.panel1.TabIndex = 0;
            // 
            // printBtn
            // 
            this.printBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printBtn.Location = new System.Drawing.Point(349, 688);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(99, 23);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Print Result";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // reportCardPanel
            // 
            this.reportCardPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportCardPanel.AutoSize = true;
            this.reportCardPanel.BackColor = System.Drawing.Color.White;
            this.reportCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportCardPanel.Controls.Add(this.classLbl);
            this.reportCardPanel.Controls.Add(this.positionLbl);
            this.reportCardPanel.Controls.Add(this.termLbl);
            this.reportCardPanel.Controls.Add(this.nameLbl);
            this.reportCardPanel.Controls.Add(this.remarksPanel);
            this.reportCardPanel.Controls.Add(this.label9);
            this.reportCardPanel.Controls.Add(this.label8);
            this.reportCardPanel.Controls.Add(this.label7);
            this.reportCardPanel.Controls.Add(this.label6);
            this.reportCardPanel.Controls.Add(this.label5);
            this.reportCardPanel.Controls.Add(this.label4);
            this.reportCardPanel.Controls.Add(this.label3);
            this.reportCardPanel.Controls.Add(this.label2);
            this.reportCardPanel.Controls.Add(this.label1);
            this.reportCardPanel.Controls.Add(this.resultDataView);
            this.reportCardPanel.Location = new System.Drawing.Point(40, 23);
            this.reportCardPanel.Name = "reportCardPanel";
            this.reportCardPanel.Size = new System.Drawing.Size(720, 649);
            this.reportCardPanel.TabIndex = 2;
            // 
            // classLbl
            // 
            this.classLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classLbl.AutoSize = true;
            this.classLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLbl.Location = new System.Drawing.Point(396, 120);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(23, 17);
            this.classLbl.TabIndex = 16;
            this.classLbl.Text = "2A";
            this.classLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionLbl
            // 
            this.positionLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(537, 120);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(28, 17);
            this.positionLbl.TabIndex = 15;
            this.positionLbl.Text = "1ST";
            this.positionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termLbl
            // 
            this.termLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.termLbl.AutoSize = true;
            this.termLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLbl.Location = new System.Drawing.Point(660, 120);
            this.termLbl.Name = "termLbl";
            this.termLbl.Size = new System.Drawing.Size(15, 17);
            this.termLbl.TabIndex = 14;
            this.termLbl.Text = "1";
            this.termLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(143, 120);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(87, 17);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "EMMA AMOA";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remarksPanel
            // 
            this.remarksPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remarksPanel.BackColor = System.Drawing.Color.Transparent;
            this.remarksPanel.Controls.Add(this.PtaLbl);
            this.remarksPanel.Controls.Add(this.extraClassesLbl);
            this.remarksPanel.Controls.Add(this.hRemarksLbl);
            this.remarksPanel.Controls.Add(this.tRemarksLbl);
            this.remarksPanel.Controls.Add(this.examsFeesLbl);
            this.remarksPanel.Controls.Add(this.totalFeesLbl);
            this.remarksPanel.Controls.Add(this.owingLbl);
            this.remarksPanel.Controls.Add(this.feesLbl);
            this.remarksPanel.Controls.Add(this.label24);
            this.remarksPanel.Controls.Add(this.label22);
            this.remarksPanel.Controls.Add(this.label20);
            this.remarksPanel.Controls.Add(this.interestLbl);
            this.remarksPanel.Controls.Add(this.attitudeLbl);
            this.remarksPanel.Controls.Add(this.conductLbl);
            this.remarksPanel.Controls.Add(this.label21);
            this.remarksPanel.Controls.Add(this.label19);
            this.remarksPanel.Controls.Add(this.label23);
            this.remarksPanel.Controls.Add(this.label18);
            this.remarksPanel.Controls.Add(this.label17);
            this.remarksPanel.Controls.Add(this.label16);
            this.remarksPanel.Controls.Add(this.label15);
            this.remarksPanel.Controls.Add(this.label14);
            this.remarksPanel.Controls.Add(this.label13);
            this.remarksPanel.Controls.Add(this.label12);
            this.remarksPanel.Controls.Add(this.totalScoreLbl);
            this.remarksPanel.Controls.Add(this.rawScoreLbl);
            this.remarksPanel.Controls.Add(this.label10);
            this.remarksPanel.Controls.Add(this.label11);
            this.remarksPanel.Location = new System.Drawing.Point(15, 288);
            this.remarksPanel.Name = "remarksPanel";
            this.remarksPanel.Size = new System.Drawing.Size(689, 345);
            this.remarksPanel.TabIndex = 9;
            // 
            // PtaLbl
            // 
            this.PtaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PtaLbl.AutoSize = true;
            this.PtaLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PtaLbl.Location = new System.Drawing.Point(337, 286);
            this.PtaLbl.Name = "PtaLbl";
            this.PtaLbl.Size = new System.Drawing.Size(62, 17);
            this.PtaLbl.TabIndex = 35;
            this.PtaLbl.Text = "READING\r\n";
            this.PtaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extraClassesLbl
            // 
            this.extraClassesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.extraClassesLbl.AutoSize = true;
            this.extraClassesLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraClassesLbl.Location = new System.Drawing.Point(139, 286);
            this.extraClassesLbl.Name = "extraClassesLbl";
            this.extraClassesLbl.Size = new System.Drawing.Size(62, 17);
            this.extraClassesLbl.TabIndex = 34;
            this.extraClassesLbl.Text = "READING\r\n";
            this.extraClassesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hRemarksLbl
            // 
            this.hRemarksLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hRemarksLbl.AutoSize = true;
            this.hRemarksLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hRemarksLbl.Location = new System.Drawing.Point(292, 179);
            this.hRemarksLbl.Name = "hRemarksLbl";
            this.hRemarksLbl.Size = new System.Drawing.Size(62, 17);
            this.hRemarksLbl.TabIndex = 32;
            this.hRemarksLbl.Text = "READING\r\n";
            this.hRemarksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tRemarksLbl
            // 
            this.tRemarksLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tRemarksLbl.AutoSize = true;
            this.tRemarksLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRemarksLbl.Location = new System.Drawing.Point(358, 144);
            this.tRemarksLbl.Name = "tRemarksLbl";
            this.tRemarksLbl.Size = new System.Drawing.Size(62, 17);
            this.tRemarksLbl.TabIndex = 31;
            this.tRemarksLbl.Text = "READING\r\n";
            this.tRemarksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examsFeesLbl
            // 
            this.examsFeesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.examsFeesLbl.AutoSize = true;
            this.examsFeesLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examsFeesLbl.Location = new System.Drawing.Point(569, 241);
            this.examsFeesLbl.Name = "examsFeesLbl";
            this.examsFeesLbl.Size = new System.Drawing.Size(62, 17);
            this.examsFeesLbl.TabIndex = 30;
            this.examsFeesLbl.Text = "READING\r\n";
            this.examsFeesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalFeesLbl
            // 
            this.totalFeesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalFeesLbl.AutoSize = true;
            this.totalFeesLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesLbl.Location = new System.Drawing.Point(542, 287);
            this.totalFeesLbl.Name = "totalFeesLbl";
            this.totalFeesLbl.Size = new System.Drawing.Size(62, 17);
            this.totalFeesLbl.TabIndex = 29;
            this.totalFeesLbl.Text = "READING\r\n";
            this.totalFeesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // owingLbl
            // 
            this.owingLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.owingLbl.AutoSize = true;
            this.owingLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owingLbl.Location = new System.Drawing.Point(102, 242);
            this.owingLbl.Name = "owingLbl";
            this.owingLbl.Size = new System.Drawing.Size(62, 17);
            this.owingLbl.TabIndex = 28;
            this.owingLbl.Text = "READING\r\n";
            this.owingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feesLbl
            // 
            this.feesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feesLbl.AutoSize = true;
            this.feesLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLbl.Location = new System.Drawing.Point(345, 240);
            this.feesLbl.Name = "feesLbl";
            this.feesLbl.Size = new System.Drawing.Size(62, 17);
            this.feesLbl.TabIndex = 27;
            this.feesLbl.Text = "READING\r\n";
            this.feesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(227, 296);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(221, 17);
            this.label24.TabIndex = 26;
            this.label24.Text = "PTA DUES:______________________";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(454, 296);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(223, 17);
            this.label22.TabIndex = 25;
            this.label22.Text = "TOTAL:_________________________";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(221, 248);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(227, 17);
            this.label20.TabIndex = 26;
            this.label20.Text = "SCHOOL FEES:____________________";
            // 
            // interestLbl
            // 
            this.interestLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interestLbl.AutoSize = true;
            this.interestLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLbl.Location = new System.Drawing.Point(248, 105);
            this.interestLbl.Name = "interestLbl";
            this.interestLbl.Size = new System.Drawing.Size(62, 17);
            this.interestLbl.TabIndex = 11;
            this.interestLbl.Text = "READING\r\n";
            this.interestLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attitudeLbl
            // 
            this.attitudeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.attitudeLbl.AutoSize = true;
            this.attitudeLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attitudeLbl.Location = new System.Drawing.Point(254, 66);
            this.attitudeLbl.Name = "attitudeLbl";
            this.attitudeLbl.Size = new System.Drawing.Size(44, 17);
            this.attitudeLbl.TabIndex = 12;
            this.attitudeLbl.Text = "QUIET";
            this.attitudeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conductLbl
            // 
            this.conductLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.conductLbl.AutoSize = true;
            this.conductLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conductLbl.Location = new System.Drawing.Point(277, 30);
            this.conductLbl.Name = "conductLbl";
            this.conductLbl.Size = new System.Drawing.Size(44, 17);
            this.conductLbl.TabIndex = 13;
            this.conductLbl.Text = "GOOD";
            this.conductLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(203, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "EXTRA CURRICULAR:___________";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(454, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(221, 17);
            this.label19.TabIndex = 25;
            this.label19.Text = "EXAMS FEES:____________________";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 248);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(205, 17);
            this.label23.TabIndex = 24;
            this.label23.Text = "ARREARS:____________________";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(326, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "FEES";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(476, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(204, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "SIGNATURE:__________________";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(463, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "HEAD TEACHER\'S REMARKS:__________________________________________";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(673, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "CLASS TEACHER\'S REMARKS:_________________________________________________________" +
    "_______________";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(668, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "INTEREST:________________________________________________________________________" +
    "______________";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(673, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "ATTITIDE:________________________________________________________________________" +
    "_______________";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(677, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "CONDUCT:_________________________________________________________________________" +
    "______________";
            // 
            // totalScoreLbl
            // 
            this.totalScoreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalScoreLbl.AutoSize = true;
            this.totalScoreLbl.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLbl.Location = new System.Drawing.Point(187, 4);
            this.totalScoreLbl.Name = "totalScoreLbl";
            this.totalScoreLbl.Size = new System.Drawing.Size(28, 17);
            this.totalScoreLbl.TabIndex = 15;
            this.totalScoreLbl.Text = "-----";
            // 
            // rawScoreLbl
            // 
            this.rawScoreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rawScoreLbl.AutoSize = true;
            this.rawScoreLbl.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawScoreLbl.Location = new System.Drawing.Point(96, 4);
            this.rawScoreLbl.Name = "rawScoreLbl";
            this.rawScoreLbl.Size = new System.Drawing.Size(28, 17);
            this.rawScoreLbl.TabIndex = 14;
            this.rawScoreLbl.Text = "-----";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "OUT OF";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "TOTAL SCORE:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "POSITION:_________";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "TERM:_________";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "CLASS:_________";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "NEXT TERM BEGINS:_________________________________";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "NO. ON ROLL:_________________________________";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME: ______________________________________";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PUPIL\'S TERMINAL REPORT";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "MEMPEASSEM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFECT PEACE  PREPARATORY SCHOOL";
            // 
            // resultDataView
            // 
            this.resultDataView.AllowUserToAddRows = false;
            this.resultDataView.AllowUserToDeleteRows = false;
            this.resultDataView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultDataView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subject,
            this.exam_score,
            this.class_score,
            this.total_score,
            this.position_in_subject,
            this.remarks});
            this.resultDataView.Location = new System.Drawing.Point(15, 203);
            this.resultDataView.Name = "resultDataView";
            this.resultDataView.ReadOnly = true;
            this.resultDataView.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.resultDataView.RowTemplate.Height = 30;
            this.resultDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultDataView.Size = new System.Drawing.Size(689, 68);
            this.resultDataView.TabIndex = 0;
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "subject_id";
            this.subject_id.HeaderText = "SUBJECT ID";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.Visible = false;
            this.subject_id.Width = 5;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.DataPropertyName = "name";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject.DefaultCellStyle = dataGridViewCellStyle2;
            this.subject.HeaderText = "SUBJECT";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // exam_score
            // 
            this.exam_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exam_score.DefaultCellStyle = dataGridViewCellStyle3;
            this.exam_score.HeaderText = "EXAM SCORE 50%";
            this.exam_score.Name = "exam_score";
            this.exam_score.ReadOnly = true;
            // 
            // class_score
            // 
            this.class_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.class_score.DefaultCellStyle = dataGridViewCellStyle4;
            this.class_score.HeaderText = "CLASS SCORE 50%";
            this.class_score.Name = "class_score";
            this.class_score.ReadOnly = true;
            // 
            // total_score
            // 
            this.total_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.total_score.DefaultCellStyle = dataGridViewCellStyle5;
            this.total_score.HeaderText = "TOTAL SCORE 100%";
            this.total_score.Name = "total_score";
            this.total_score.ReadOnly = true;
            // 
            // position_in_subject
            // 
            this.position_in_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.position_in_subject.DefaultCellStyle = dataGridViewCellStyle6;
            this.position_in_subject.HeaderText = "POSITION IN SUBJECT";
            this.position_in_subject.Name = "position_in_subject";
            this.position_in_subject.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarks.HeaderText = "REMARKS";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // ReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 743);
            this.Controls.Add(this.panel1);
            this.Name = "ReportCard";
            this.Text = "ReportCard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.reportCardPanel.ResumeLayout(false);
            this.reportCardPanel.PerformLayout();
            this.remarksPanel.ResumeLayout(false);
            this.remarksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Panel reportCardPanel;
        private System.Windows.Forms.Panel remarksPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.Label rawScoreLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn position_in_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label termLbl;
        private System.Windows.Forms.Label conductLbl;
        private System.Windows.Forms.Label attitudeLbl;
        private System.Windows.Forms.Label interestLbl;
        private System.Windows.Forms.Label tRemarksLbl;
        private System.Windows.Forms.Label examsFeesLbl;
        private System.Windows.Forms.Label totalFeesLbl;
        private System.Windows.Forms.Label owingLbl;
        private System.Windows.Forms.Label feesLbl;
        private System.Windows.Forms.Label PtaLbl;
        private System.Windows.Forms.Label extraClassesLbl;
        private System.Windows.Forms.Label hRemarksLbl;
    }
}