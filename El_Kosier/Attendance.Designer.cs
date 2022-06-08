namespace El_Kosier
{
    partial class Attendance
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.classNumberComboBox3 = new System.Windows.Forms.ComboBox();
            this.groupComboBox2 = new System.Windows.Forms.ComboBox();
            this.studentNameComboBox4 = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.presentRadioButton = new System.Windows.Forms.RadioButton();
            this.absentRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.entryAttendanceTextBox = new System.Windows.Forms.TextBox();
            this.placeComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Silver;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(16, 160);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(180, 30);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Group";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(16, 300);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(180, 30);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Class Number";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(16, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(180, 30);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Place";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(16, 230);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(180, 30);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Student Name";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(370, 439);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 19;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.Return_Click);
            // 
            // classNumberComboBox3
            // 
            this.classNumberComboBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNumberComboBox3.FormattingEnabled = true;
            this.classNumberComboBox3.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.classNumberComboBox3.Location = new System.Drawing.Point(212, 300);
            this.classNumberComboBox3.Name = "classNumberComboBox3";
            this.classNumberComboBox3.Size = new System.Drawing.Size(48, 31);
            this.classNumberComboBox3.TabIndex = 21;
            this.classNumberComboBox3.SelectedIndexChanged += new System.EventHandler(this.classNumberComboBox3_SelectedIndexChanged);
            // 
            // groupComboBox2
            // 
            this.groupComboBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox2.FormattingEnabled = true;
            this.groupComboBox2.Location = new System.Drawing.Point(213, 161);
            this.groupComboBox2.Name = "groupComboBox2";
            this.groupComboBox2.Size = new System.Drawing.Size(296, 31);
            this.groupComboBox2.TabIndex = 22;
            this.groupComboBox2.SelectedIndexChanged += new System.EventHandler(this.groupComboBox2_SelectedIndexChanged);
            // 
            // studentNameComboBox4
            // 
            this.studentNameComboBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameComboBox4.FormattingEnabled = true;
            this.studentNameComboBox4.Location = new System.Drawing.Point(213, 231);
            this.studentNameComboBox4.Name = "studentNameComboBox4";
            this.studentNameComboBox4.Size = new System.Drawing.Size(297, 31);
            this.studentNameComboBox4.TabIndex = 23;
            this.studentNameComboBox4.SelectedIndexChanged += new System.EventHandler(this.studentNameComboBox4_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Silver;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(16, 370);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(180, 30);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Attendance";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presentRadioButton
            // 
            this.presentRadioButton.AutoSize = true;
            this.presentRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentRadioButton.Location = new System.Drawing.Point(212, 375);
            this.presentRadioButton.Name = "presentRadioButton";
            this.presentRadioButton.Size = new System.Drawing.Size(90, 23);
            this.presentRadioButton.TabIndex = 25;
            this.presentRadioButton.TabStop = true;
            this.presentRadioButton.Text = "Present";
            this.presentRadioButton.UseVisualStyleBackColor = true;
            // 
            // absentRadioButton
            // 
            this.absentRadioButton.AutoSize = true;
            this.absentRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentRadioButton.Location = new System.Drawing.Point(370, 375);
            this.absentRadioButton.Name = "absentRadioButton";
            this.absentRadioButton.Size = new System.Drawing.Size(84, 23);
            this.absentRadioButton.TabIndex = 26;
            this.absentRadioButton.TabStop = true;
            this.absentRadioButton.Text = "Absent";
            this.absentRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.ImageKey = "(none)";
            this.saveButton.Location = new System.Drawing.Point(70, 439);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 35);
            this.saveButton.TabIndex = 40;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // entryAttendanceTextBox
            // 
            this.entryAttendanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.entryAttendanceTextBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryAttendanceTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryAttendanceTextBox.Location = new System.Drawing.Point(110, 21);
            this.entryAttendanceTextBox.Multiline = true;
            this.entryAttendanceTextBox.Name = "entryAttendanceTextBox";
            this.entryAttendanceTextBox.Size = new System.Drawing.Size(318, 41);
            this.entryAttendanceTextBox.TabIndex = 41;
            this.entryAttendanceTextBox.Text = "Entry Attendance";
            this.entryAttendanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // placeComboBox1
            // 
            this.placeComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox1.FormattingEnabled = true;
            this.placeComboBox1.Location = new System.Drawing.Point(213, 90);
            this.placeComboBox1.Name = "placeComboBox1";
            this.placeComboBox1.Size = new System.Drawing.Size(297, 31);
            this.placeComboBox1.TabIndex = 42;
            this.placeComboBox1.SelectedIndexChanged += new System.EventHandler(this.placeComboBox1_SelectedIndexChanged);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 496);
            this.Controls.Add(this.placeComboBox1);
            this.Controls.Add(this.entryAttendanceTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.absentRadioButton);
            this.Controls.Add(this.presentRadioButton);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.studentNameComboBox4);
            this.Controls.Add(this.groupComboBox2);
            this.Controls.Add(this.classNumberComboBox3);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox classNumberComboBox3;
        private System.Windows.Forms.ComboBox groupComboBox2;
        private System.Windows.Forms.ComboBox studentNameComboBox4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.RadioButton presentRadioButton;
        private System.Windows.Forms.RadioButton absentRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox entryAttendanceTextBox;
        private System.Windows.Forms.ComboBox placeComboBox1;

    }
}