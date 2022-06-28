namespace Perfect_Peace_System.Pages
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.teacherCb = new System.Windows.Forms.ComboBox();
            this.sectionCb = new System.Windows.Forms.ComboBox();
            this.capacityTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feesBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.feesBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.addClassBtn);
            this.panel1.Controls.Add(this.teacherCb);
            this.panel1.Controls.Add(this.sectionCb);
            this.panel1.Controls.Add(this.capacityTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 539);
            this.panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(509, 359);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // addClassBtn
            // 
            this.addClassBtn.Location = new System.Drawing.Point(408, 359);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(75, 23);
            this.addClassBtn.TabIndex = 22;
            this.addClassBtn.Text = "Add Class";
            this.addClassBtn.UseVisualStyleBackColor = true;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // teacherCb
            // 
            this.teacherCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCb.FormattingEnabled = true;
            this.teacherCb.Location = new System.Drawing.Point(327, 267);
            this.teacherCb.Name = "teacherCb";
            this.teacherCb.Size = new System.Drawing.Size(330, 21);
            this.teacherCb.TabIndex = 21;
            // 
            // sectionCb
            // 
            this.sectionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionCb.FormattingEnabled = true;
            this.sectionCb.Items.AddRange(new object[] {
            "Crech",
            "Nursury",
            "KG",
            "Lower Primary",
            "Upper Primary",
            "JHS"});
            this.sectionCb.Location = new System.Drawing.Point(328, 219);
            this.sectionCb.Name = "sectionCb";
            this.sectionCb.Size = new System.Drawing.Size(330, 21);
            this.sectionCb.TabIndex = 20;
            // 
            // capacityTb
            // 
            this.capacityTb.Location = new System.Drawing.Point(327, 180);
            this.capacityTb.Name = "capacityTb";
            this.capacityTb.Size = new System.Drawing.Size(330, 20);
            this.capacityTb.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Capacity: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Section: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teacher: ";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(328, 137);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(330, 20);
            this.nameTb.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fees: ";
            // 
            // feesBox
            // 
            this.feesBox.Location = new System.Drawing.Point(328, 309);
            this.feesBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.feesBox.Name = "feesBox";
            this.feesBox.Size = new System.Drawing.Size(120, 20);
            this.feesBox.TabIndex = 25;
            this.feesBox.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ghc";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 539);
            this.Controls.Add(this.panel1);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.NumericUpDown feesBox;
        private System.Windows.Forms.Label label2;
    }
}