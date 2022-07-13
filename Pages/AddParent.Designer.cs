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
            this.panel1 = new System.Windows.Forms.Panel();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.clearFeild = new System.Windows.Forms.Button();
            this.registerParent = new System.Windows.Forms.Button();
            this.childCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.relationshipCB = new System.Windows.Forms.ComboBox();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contact1Tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.femaleRadioBtn);
            this.panel1.Controls.Add(this.maleRadioBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.clearFeild);
            this.panel1.Controls.Add(this.registerParent);
            this.panel1.Controls.Add(this.childCB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.relationshipCB);
            this.panel1.Controls.Add(this.lnameTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.contactTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.contact1Tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fnameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 539);
            this.panel1.TabIndex = 0;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(317, 180);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioBtn.TabIndex = 17;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            this.femaleRadioBtn.CheckedChanged += new System.EventHandler(this.femaleRadioBtn_CheckedChanged);
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Checked = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(217, 180);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.maleRadioBtn.TabIndex = 16;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender: ";
            // 
            // clearFeild
            // 
            this.clearFeild.Location = new System.Drawing.Point(509, 429);
            this.clearFeild.Name = "clearFeild";
            this.clearFeild.Size = new System.Drawing.Size(112, 23);
            this.clearFeild.TabIndex = 14;
            this.clearFeild.Text = "Clear";
            this.clearFeild.UseVisualStyleBackColor = true;
            // 
            // registerParent
            // 
            this.registerParent.Location = new System.Drawing.Point(344, 429);
            this.registerParent.Name = "registerParent";
            this.registerParent.Size = new System.Drawing.Size(112, 23);
            this.registerParent.TabIndex = 13;
            this.registerParent.Text = "Register Parent";
            this.registerParent.UseVisualStyleBackColor = true;
            this.registerParent.Click += new System.EventHandler(this.registerParent_Click);
            // 
            // childCB
            // 
            this.childCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.childCB.FormattingEnabled = true;
            this.childCB.Location = new System.Drawing.Point(216, 370);
            this.childCB.Name = "childCB";
            this.childCB.Size = new System.Drawing.Size(615, 21);
            this.childCB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Child: ";
            // 
            // relationshipCB
            // 
            this.relationshipCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipCB.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Sibling",
            "Family Member",
            "Guardian"});
            this.relationshipCB.Location = new System.Drawing.Point(216, 323);
            this.relationshipCB.Name = "relationshipCB";
            this.relationshipCB.Size = new System.Drawing.Size(615, 21);
            this.relationshipCB.TabIndex = 10;
            // 
            // lnameTb
            // 
            this.lnameTb.Location = new System.Drawing.Point(216, 133);
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(615, 20);
            this.lnameTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name: ";
            // 
            // contactTb
            // 
            this.contactTb.Location = new System.Drawing.Point(216, 222);
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(615, 20);
            this.contactTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relationship: ";
            // 
            // contact1Tb
            // 
            this.contact1Tb.Location = new System.Drawing.Point(216, 270);
            this.contact1Tb.Name = "contact1Tb";
            this.contact1Tb.Size = new System.Drawing.Size(615, 20);
            this.contact1Tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Other contact: ";
            // 
            // fnameTb
            // 
            this.fnameTb.Location = new System.Drawing.Point(216, 79);
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(615, 20);
            this.fnameTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // AddParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 539);
            this.Controls.Add(this.panel1);
            this.Name = "AddParent";
            this.Text = "AddParent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contact1Tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearFeild;
        private System.Windows.Forms.Button registerParent;
        private System.Windows.Forms.ComboBox childCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox relationshipCB;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.Label label7;
    }
}