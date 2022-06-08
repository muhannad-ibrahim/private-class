namespace El_Kosier
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.entryButton1 = new System.Windows.Forms.Button();
            this.archiveButton3 = new System.Windows.Forms.Button();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryButton1
            // 
            this.entryButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.entryButton1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.entryButton1, "entryButton1");
            this.entryButton1.ForeColor = System.Drawing.Color.ForestGreen;
            this.entryButton1.Name = "entryButton1";
            this.entryButton1.UseVisualStyleBackColor = false;
            this.entryButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // archiveButton3
            // 
            this.archiveButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.archiveButton3, "archiveButton3");
            this.archiveButton3.ForeColor = System.Drawing.Color.Red;
            this.archiveButton3.Name = "archiveButton3";
            this.archiveButton3.UseVisualStyleBackColor = false;
            // 
            // searchButton2
            // 
            this.searchButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.searchButton2, "searchButton2");
            this.searchButton2.ForeColor = System.Drawing.Color.Blue;
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.UseVisualStyleBackColor = false;
            this.searchButton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Kosier.Properties.Resources._5166950;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton2);
            this.Controls.Add(this.archiveButton3);
            this.Controls.Add(this.entryButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button archiveButton3;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.Button entryButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

