﻿namespace Perfect_Peace_System.Pages
{
    partial class AddClass
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
            this.bgPanel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.tuition = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.firstAid = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.PTA = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.water = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.maintenance = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stationary = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.totalFeesLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cocurricular = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.teacherCb = new System.Windows.Forms.ComboBox();
            this.sectionCb = new System.Windows.Forms.ComboBox();
            this.capacityTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocurricular)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.panel1);
            this.bgPanel.Controls.Add(this.clearBtn);
            this.bgPanel.Controls.Add(this.addClassBtn);
            this.bgPanel.Controls.Add(this.label7);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(775, 586);
            this.bgPanel.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(286, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 19);
            this.label19.TabIndex = 26;
            this.label19.Text = "Ghc";
            // 
            // tuition
            // 
            this.tuition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tuition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuition.Location = new System.Drawing.Point(326, 161);
            this.tuition.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tuition.Name = "tuition";
            this.tuition.Size = new System.Drawing.Size(120, 27);
            this.tuition.TabIndex = 25;
            this.tuition.ThousandsSeparator = true;
            this.tuition.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(286, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 19);
            this.label17.TabIndex = 26;
            this.label17.Text = "Ghc";
            // 
            // firstAid
            // 
            this.firstAid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstAid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAid.Location = new System.Drawing.Point(326, 194);
            this.firstAid.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.firstAid.Name = "firstAid";
            this.firstAid.Size = new System.Drawing.Size(120, 27);
            this.firstAid.TabIndex = 25;
            this.firstAid.ThousandsSeparator = true;
            this.firstAid.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(286, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Ghc";
            // 
            // PTA
            // 
            this.PTA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PTA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTA.Location = new System.Drawing.Point(326, 226);
            this.PTA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PTA.Name = "PTA";
            this.PTA.Size = new System.Drawing.Size(120, 27);
            this.PTA.TabIndex = 25;
            this.PTA.ThousandsSeparator = true;
            this.PTA.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(286, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ghc";
            // 
            // water
            // 
            this.water.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.water.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water.Location = new System.Drawing.Point(326, 258);
            this.water.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(120, 27);
            this.water.TabIndex = 25;
            this.water.ThousandsSeparator = true;
            this.water.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(196, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "Tuition Fee: ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(286, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ghc";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(214, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 19);
            this.label16.TabIndex = 24;
            this.label16.Text = "First Aid: ";
            // 
            // maintenance
            // 
            this.maintenance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maintenance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenance.Location = new System.Drawing.Point(326, 288);
            this.maintenance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maintenance.Name = "maintenance";
            this.maintenance.Size = new System.Drawing.Size(120, 27);
            this.maintenance.TabIndex = 25;
            this.maintenance.ThousandsSeparator = true;
            this.maintenance.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(206, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "PTA Dues: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ghc";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Toiletories/Sanitation/Water:";
            // 
            // stationary
            // 
            this.stationary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stationary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationary.Location = new System.Drawing.Point(326, 318);
            this.stationary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stationary.Name = "stationary";
            this.stationary.Size = new System.Drawing.Size(120, 27);
            this.stationary.TabIndex = 25;
            this.stationary.ThousandsSeparator = true;
            this.stationary.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(182, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Maintenance:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(286, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 19);
            this.label21.TabIndex = 26;
            this.label21.Text = "Ghc";
            // 
            // totalFeesLbl
            // 
            this.totalFeesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalFeesLbl.AutoSize = true;
            this.totalFeesLbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesLbl.Location = new System.Drawing.Point(316, 388);
            this.totalFeesLbl.Name = "totalFeesLbl";
            this.totalFeesLbl.Size = new System.Drawing.Size(45, 23);
            this.totalFeesLbl.TabIndex = 26;
            this.totalFeesLbl.Text = "0.00";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ghc";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Stationary:";
            // 
            // cocurricular
            // 
            this.cocurricular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cocurricular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocurricular.Location = new System.Drawing.Point(326, 351);
            this.cocurricular.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cocurricular.Name = "cocurricular";
            this.cocurricular.Size = new System.Drawing.Size(120, 27);
            this.cocurricular.TabIndex = 25;
            this.cocurricular.ThousandsSeparator = true;
            this.cocurricular.ValueChanged += new System.EventHandler(this.tuition_ValueChanged);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(189, 353);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 19);
            this.label20.TabIndex = 24;
            this.label20.Text = "Cocurricular: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fees: ";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearBtn.BackColor = System.Drawing.Color.Maroon;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(453, 495);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addClassBtn
            // 
            this.addClassBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addClassBtn.BackColor = System.Drawing.Color.Green;
            this.addClassBtn.FlatAppearance.BorderSize = 0;
            this.addClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClassBtn.ForeColor = System.Drawing.Color.White;
            this.addClassBtn.Location = new System.Drawing.Point(312, 495);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(75, 23);
            this.addClassBtn.TabIndex = 22;
            this.addClassBtn.Text = "Add Class";
            this.addClassBtn.UseVisualStyleBackColor = false;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // teacherCb
            // 
            this.teacherCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teacherCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherCb.FormattingEnabled = true;
            this.teacherCb.Location = new System.Drawing.Point(135, 123);
            this.teacherCb.Name = "teacherCb";
            this.teacherCb.Size = new System.Drawing.Size(456, 27);
            this.teacherCb.TabIndex = 21;
            // 
            // sectionCb
            // 
            this.sectionCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sectionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionCb.FormattingEnabled = true;
            this.sectionCb.Items.AddRange(new object[] {
            "Crech",
            "Nursury",
            "KG",
            "Lower Primary",
            "Upper Primary",
            "JHS"});
            this.sectionCb.Location = new System.Drawing.Point(135, 90);
            this.sectionCb.Name = "sectionCb";
            this.sectionCb.Size = new System.Drawing.Size(456, 27);
            this.sectionCb.TabIndex = 20;
            // 
            // capacityTb
            // 
            this.capacityTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacityTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTb.Location = new System.Drawing.Point(135, 57);
            this.capacityTb.Name = "capacityTb";
            this.capacityTb.Size = new System.Drawing.Size(456, 27);
            this.capacityTb.TabIndex = 19;
            this.capacityTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Capacity: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Section: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teacher: ";
            // 
            // nameTb
            // 
            this.nameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(135, 24);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(456, 27);
            this.nameTb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "ADD CLASSROOM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class Name: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameTb);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tuition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.firstAid);
            this.panel1.Controls.Add(this.capacityTb);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.sectionCb);
            this.panel1.Controls.Add(this.PTA);
            this.panel1.Controls.Add(this.teacherCb);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.water);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cocurricular);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.maintenance);
            this.panel1.Controls.Add(this.totalFeesLbl);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.stationary);
            this.panel1.Location = new System.Drawing.Point(54, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 438);
            this.panel1.TabIndex = 28;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 586);
            this.Controls.Add(this.bgPanel);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocurricular)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addClassBtn;
        private System.Windows.Forms.ComboBox teacherCb;
        private System.Windows.Forms.ComboBox sectionCb;
        private System.Windows.Forms.TextBox capacityTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown tuition;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown firstAid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown PTA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown water;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown maintenance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown stationary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label totalFeesLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cocurricular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
    }
}