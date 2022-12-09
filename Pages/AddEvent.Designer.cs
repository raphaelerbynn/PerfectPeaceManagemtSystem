namespace Perfect_Peace_System.Pages
{
    partial class AddEvent
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formsBg = new System.Windows.Forms.Panel();
            this.bgPanel.SuspendLayout();
            this.formsBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.formsBg);
            this.bgPanel.Controls.Add(this.clearBtn);
            this.bgPanel.Controls.Add(this.addEventBtn);
            this.bgPanel.Controls.Add(this.label5);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(800, 607);
            this.bgPanel.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearBtn.BackColor = System.Drawing.Color.DarkRed;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(418, 409);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addEventBtn
            // 
            this.addEventBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addEventBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.addEventBtn.FlatAppearance.BorderSize = 0;
            this.addEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventBtn.ForeColor = System.Drawing.Color.White;
            this.addEventBtn.Location = new System.Drawing.Point(311, 409);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(75, 23);
            this.addEventBtn.TabIndex = 8;
            this.addEventBtn.Text = "Add Event";
            this.addEventBtn.UseVisualStyleBackColor = false;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(469, 195);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(187, 27);
            this.timePicker.TabIndex = 7;
            this.timePicker.Value = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(124, 195);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(264, 27);
            this.datePicker.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AcceptsReturn = true;
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(124, 78);
            this.lblDescription.Multiline = true;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(532, 93);
            this.lblDescription.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(124, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(532, 27);
            this.lblName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "ADD EVENT";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name: ";
            // 
            // formsBg
            // 
            this.formsBg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formsBg.BackColor = System.Drawing.Color.PaleGreen;
            this.formsBg.Controls.Add(this.label1);
            this.formsBg.Controls.Add(this.label2);
            this.formsBg.Controls.Add(this.label3);
            this.formsBg.Controls.Add(this.timePicker);
            this.formsBg.Controls.Add(this.label4);
            this.formsBg.Controls.Add(this.datePicker);
            this.formsBg.Controls.Add(this.lblName);
            this.formsBg.Controls.Add(this.lblDescription);
            this.formsBg.Location = new System.Drawing.Point(63, 114);
            this.formsBg.Name = "formsBg";
            this.formsBg.Size = new System.Drawing.Size(688, 271);
            this.formsBg.TabIndex = 10;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.bgPanel);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.formsBg.ResumeLayout(false);
            this.formsBg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox lblDescription;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel formsBg;
    }
}