namespace Perfect_Peace_System.Pages
{
    partial class AddStudent
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
            this.registerPanel = new System.Windows.Forms.Panel();
            this.clearFeildBtn = new System.Windows.Forms.Button();
            this.registerStntBnt = new System.Windows.Forms.Button();
            this.classCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.mnameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.AutoScroll = true;
            this.registerPanel.Controls.Add(this.clearFeildBtn);
            this.registerPanel.Controls.Add(this.registerStntBnt);
            this.registerPanel.Controls.Add(this.classCb);
            this.registerPanel.Controls.Add(this.label7);
            this.registerPanel.Controls.Add(this.femaleRadio);
            this.registerPanel.Controls.Add(this.maleRadio);
            this.registerPanel.Controls.Add(this.dobPicker);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Controls.Add(this.mnameTb);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.lnameTb);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.addressTb);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Controls.Add(this.fnameTb);
            this.registerPanel.Controls.Add(this.label1);
            this.registerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPanel.Location = new System.Drawing.Point(0, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(950, 539);
            this.registerPanel.TabIndex = 0;
            // 
            // clearFeildBtn
            // 
            this.clearFeildBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearFeildBtn.Location = new System.Drawing.Point(520, 452);
            this.clearFeildBtn.Name = "clearFeildBtn";
            this.clearFeildBtn.Size = new System.Drawing.Size(75, 23);
            this.clearFeildBtn.TabIndex = 18;
            this.clearFeildBtn.Text = "Clear";
            this.clearFeildBtn.UseVisualStyleBackColor = true;
            this.clearFeildBtn.Click += new System.EventHandler(this.clearFeildBtn_Click);
            // 
            // registerStntBnt
            // 
            this.registerStntBnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerStntBnt.Location = new System.Drawing.Point(359, 452);
            this.registerStntBnt.Name = "registerStntBnt";
            this.registerStntBnt.Size = new System.Drawing.Size(75, 23);
            this.registerStntBnt.TabIndex = 17;
            this.registerStntBnt.Text = "Register";
            this.registerStntBnt.UseVisualStyleBackColor = true;
            this.registerStntBnt.Click += new System.EventHandler(this.registerStntBnt_Click);
            // 
            // classCb
            // 
            this.classCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCb.FormattingEnabled = true;
            this.classCb.Location = new System.Drawing.Point(193, 400);
            this.classCb.Name = "classCb";
            this.classCb.Size = new System.Drawing.Size(658, 21);
            this.classCb.TabIndex = 16;
            this.classCb.SelectedIndexChanged += new System.EventHandler(this.classCb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Class: ";
            // 
            // femaleRadio
            // 
            this.femaleRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.femaleRadio.Location = new System.Drawing.Point(282, 240);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 18);
            this.femaleRadio.TabIndex = 14;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseCompatibleTextRendering = true;
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maleRadio.Location = new System.Drawing.Point(190, 240);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(46, 18);
            this.maleRadio.TabIndex = 13;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseCompatibleTextRendering = true;
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // dobPicker
            // 
            this.dobPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobPicker.Location = new System.Drawing.Point(192, 186);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(660, 20);
            this.dobPicker.TabIndex = 12;
            this.dobPicker.Value = new System.DateTime(2009, 12, 27, 0, 0, 0, 0);
            this.dobPicker.ValueChanged += new System.EventHandler(this.dobPicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address: *";
            // 
            // mnameTb
            // 
            this.mnameTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mnameTb.Location = new System.Drawing.Point(192, 111);
            this.mnameTb.Name = "mnameTb";
            this.mnameTb.Size = new System.Drawing.Size(659, 20);
            this.mnameTb.TabIndex = 10;
            this.mnameTb.TextChanged += new System.EventHandler(this.mnameTb_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Middle Name: ";
            // 
            // lnameTb
            // 
            this.lnameTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnameTb.Location = new System.Drawing.Point(192, 149);
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(659, 20);
            this.lnameTb.TabIndex = 8;
            this.lnameTb.TextChanged += new System.EventHandler(this.lnameTb_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name: *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender: ";
            // 
            // addressTb
            // 
            this.addressTb.AcceptsReturn = true;
            this.addressTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTb.Location = new System.Drawing.Point(192, 303);
            this.addressTb.Multiline = true;
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(660, 66);
            this.addressTb.TabIndex = 4;
            this.addressTb.TextChanged += new System.EventHandler(this.addressTb_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth: *";
            // 
            // fnameTb
            // 
            this.fnameTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnameTb.Location = new System.Drawing.Point(193, 76);
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(659, 20);
            this.fnameTb.TabIndex = 2;
            this.fnameTb.TextChanged += new System.EventHandler(this.fnameTb_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: *";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 539);
            this.Controls.Add(this.registerPanel);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Button clearFeildBtn;
        private System.Windows.Forms.Button registerStntBnt;
        private System.Windows.Forms.ComboBox classCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mnameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label label1;
    }
}