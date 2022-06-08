namespace El_Kosier
{
    partial class Form3
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
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.levelComboBox11 = new System.Windows.Forms.ComboBox();
            this.notesTextBox5 = new System.Windows.Forms.TextBox();
            this.guardianNumberTextBox4 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.studentNameTextBox3 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.dateTextBox1 = new System.Windows.Forms.TextBox();
            this.entryStudentDataTextBox = new System.Windows.Forms.TextBox();
            this.idStudentTextBox2 = new System.Windows.Forms.TextBox();
            this.groupComboBox10 = new System.Windows.Forms.ComboBox();
            this.placeComboBox9 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(80, 623);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 35);
            this.saveButton.TabIndex = 64;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(644, 623);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 63;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click_1);
            // 
            // levelComboBox11
            // 
            this.levelComboBox11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox11.FormattingEnabled = true;
            this.levelComboBox11.Items.AddRange(new object[] {
            "",
            "Excellent",
            "Very Good",
            "Good",
            "Acceptable"});
            this.levelComboBox11.Location = new System.Drawing.Point(227, 271);
            this.levelComboBox11.Name = "levelComboBox11";
            this.levelComboBox11.Size = new System.Drawing.Size(177, 31);
            this.levelComboBox11.TabIndex = 62;
            // 
            // notesTextBox5
            // 
            this.notesTextBox5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox5.Location = new System.Drawing.Point(227, 389);
            this.notesTextBox5.Multiline = true;
            this.notesTextBox5.Name = "notesTextBox5";
            this.notesTextBox5.Size = new System.Drawing.Size(373, 209);
            this.notesTextBox5.TabIndex = 61;
            // 
            // guardianNumberTextBox4
            // 
            this.guardianNumberTextBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianNumberTextBox4.Location = new System.Drawing.Point(227, 331);
            this.guardianNumberTextBox4.Multiline = true;
            this.guardianNumberTextBox4.Name = "guardianNumberTextBox4";
            this.guardianNumberTextBox4.Size = new System.Drawing.Size(177, 29);
            this.guardianNumberTextBox4.TabIndex = 60;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Silver;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(21, 390);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(197, 30);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Notes";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Silver;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(21, 270);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(197, 30);
            this.Label6.TabIndex = 58;
            this.Label6.Text = "Grade";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Silver;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(21, 330);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(197, 30);
            this.Label7.TabIndex = 57;
            this.Label7.Text = "Guardian Number";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNameTextBox3
            // 
            this.studentNameTextBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox3.Location = new System.Drawing.Point(227, 210);
            this.studentNameTextBox3.Multiline = true;
            this.studentNameTextBox3.Name = "studentNameTextBox3";
            this.studentNameTextBox3.Size = new System.Drawing.Size(364, 29);
            this.studentNameTextBox3.TabIndex = 56;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Silver;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(21, 210);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(197, 30);
            this.Label5.TabIndex = 55;
            this.Label5.Text = "Student Name";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox1.Location = new System.Drawing.Point(227, 150);
            this.dateTextBox1.Multiline = true;
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(177, 29);
            this.dateTextBox1.TabIndex = 54;
            // 
            // entryStudentDataTextBox
            // 
            this.entryStudentDataTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.entryStudentDataTextBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryStudentDataTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryStudentDataTextBox.Location = new System.Drawing.Point(227, 21);
            this.entryStudentDataTextBox.Multiline = true;
            this.entryStudentDataTextBox.Name = "entryStudentDataTextBox";
            this.entryStudentDataTextBox.Size = new System.Drawing.Size(356, 41);
            this.entryStudentDataTextBox.TabIndex = 53;
            this.entryStudentDataTextBox.Text = "Entry Student Data\r\n";
            this.entryStudentDataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idStudentTextBox2
            // 
            this.idStudentTextBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idStudentTextBox2.Location = new System.Drawing.Point(633, 150);
            this.idStudentTextBox2.Multiline = true;
            this.idStudentTextBox2.Name = "idStudentTextBox2";
            this.idStudentTextBox2.Size = new System.Drawing.Size(177, 29);
            this.idStudentTextBox2.TabIndex = 52;
            // 
            // groupComboBox10
            // 
            this.groupComboBox10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox10.FormattingEnabled = true;
            this.groupComboBox10.Items.AddRange(new object[] {
            "Prim 4A",
            "Prim 4B",
            "Prim 5A",
            "Prim 5B",
            "Prim 6A",
            "Prim 6B",
            "Prep 1A",
            "Prep 1B",
            "Prep 2A",
            "Prep 2B",
            "Prep 3A",
            "Prep 3B",
            "Sec 1A",
            "Sec 1B",
            "Sec 2A",
            "Sec 2B",
            "Sec 3A",
            "Sec 3B"});
            this.groupComboBox10.Location = new System.Drawing.Point(633, 90);
            this.groupComboBox10.Name = "groupComboBox10";
            this.groupComboBox10.Size = new System.Drawing.Size(177, 31);
            this.groupComboBox10.TabIndex = 51;
            // 
            // placeComboBox9
            // 
            this.placeComboBox9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox9.FormattingEnabled = true;
            this.placeComboBox9.Items.AddRange(new object[] {
            "Dessouk",
            "Kafr Magar"});
            this.placeComboBox9.Location = new System.Drawing.Point(227, 90);
            this.placeComboBox9.Name = "placeComboBox9";
            this.placeComboBox9.Size = new System.Drawing.Size(177, 31);
            this.placeComboBox9.TabIndex = 50;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(462, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(161, 30);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "ID Student";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Silver;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(21, 150);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(197, 30);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Date ";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(462, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(161, 30);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Group";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(21, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(197, 30);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Place";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 666);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.levelComboBox11);
            this.Controls.Add(this.notesTextBox5);
            this.Controls.Add(this.guardianNumberTextBox4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.studentNameTextBox3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.entryStudentDataTextBox);
            this.Controls.Add(this.idStudentTextBox2);
            this.Controls.Add(this.groupComboBox10);
            this.Controls.Add(this.placeComboBox9);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Data";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox levelComboBox11;
        private System.Windows.Forms.TextBox notesTextBox5;
        private System.Windows.Forms.TextBox guardianNumberTextBox4;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox studentNameTextBox3;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox dateTextBox1;
        private System.Windows.Forms.TextBox entryStudentDataTextBox;
        private System.Windows.Forms.TextBox idStudentTextBox2;
        private System.Windows.Forms.ComboBox groupComboBox10;
        private System.Windows.Forms.ComboBox placeComboBox9;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;






    }
}