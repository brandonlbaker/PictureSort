namespace WindowsFormsApp2
{
    partial class FolderBrowse
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.destinationButton1 = new System.Windows.Forms.Button();
            this.destinationButton2 = new System.Windows.Forms.Button();
            this.destinationButton3 = new System.Windows.Forms.Button();
            this.destinationButton4 = new System.Windows.Forms.Button();
            this.destinationButton5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.openDestination1 = new System.Windows.Forms.Button();
            this.openDestination2 = new System.Windows.Forms.Button();
            this.openDestination3 = new System.Windows.Forms.Button();
            this.openDestination4 = new System.Windows.Forms.Button();
            this.openDestination5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(28, 31);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(100, 22);
            this.openFolderButton.TabIndex = 1;
            this.openFolderButton.Text = "Open Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 22);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 500);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(365, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // destinationButton1
            // 
            this.destinationButton1.Location = new System.Drawing.Point(871, 45);
            this.destinationButton1.Name = "destinationButton1";
            this.destinationButton1.Size = new System.Drawing.Size(133, 23);
            this.destinationButton1.TabIndex = 5;
            this.destinationButton1.Text = "Move Picture To...";
            this.destinationButton1.UseVisualStyleBackColor = true;
            this.destinationButton1.Click += new System.EventHandler(this.destinationButton1_Click);
            // 
            // destinationButton2
            // 
            this.destinationButton2.Location = new System.Drawing.Point(871, 170);
            this.destinationButton2.Name = "destinationButton2";
            this.destinationButton2.Size = new System.Drawing.Size(133, 23);
            this.destinationButton2.TabIndex = 6;
            this.destinationButton2.Text = "Move Picture To...";
            this.destinationButton2.UseVisualStyleBackColor = true;
            this.destinationButton2.Click += new System.EventHandler(this.destinationButton2_Click);
            // 
            // destinationButton3
            // 
            this.destinationButton3.Location = new System.Drawing.Point(871, 295);
            this.destinationButton3.Name = "destinationButton3";
            this.destinationButton3.Size = new System.Drawing.Size(133, 23);
            this.destinationButton3.TabIndex = 7;
            this.destinationButton3.Text = "Move Picture To...";
            this.destinationButton3.UseVisualStyleBackColor = true;
            this.destinationButton3.Click += new System.EventHandler(this.destinationButton3_Click);
            // 
            // destinationButton4
            // 
            this.destinationButton4.Location = new System.Drawing.Point(871, 420);
            this.destinationButton4.Name = "destinationButton4";
            this.destinationButton4.Size = new System.Drawing.Size(133, 23);
            this.destinationButton4.TabIndex = 8;
            this.destinationButton4.Text = "Move Picture To...";
            this.destinationButton4.UseVisualStyleBackColor = true;
            this.destinationButton4.Click += new System.EventHandler(this.destinationButton4_Click);
            // 
            // destinationButton5
            // 
            this.destinationButton5.Location = new System.Drawing.Point(871, 522);
            this.destinationButton5.Name = "destinationButton5";
            this.destinationButton5.Size = new System.Drawing.Size(133, 23);
            this.destinationButton5.TabIndex = 9;
            this.destinationButton5.Text = "Move Picture To...";
            this.destinationButton5.UseVisualStyleBackColor = true;
            this.destinationButton5.Click += new System.EventHandler(this.destinationButton5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(871, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(871, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(871, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 22);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(880, 449);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 22);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(871, 551);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(207, 22);
            this.textBox6.TabIndex = 14;
            // 
            // openDestination1
            // 
            this.openDestination1.Location = new System.Drawing.Point(1084, 74);
            this.openDestination1.Name = "openDestination1";
            this.openDestination1.Size = new System.Drawing.Size(100, 22);
            this.openDestination1.TabIndex = 15;
            this.openDestination1.Text = "Open Folder";
            this.openDestination1.UseVisualStyleBackColor = true;
            this.openDestination1.Click += new System.EventHandler(this.openDestination1_Click);
            // 
            // openDestination2
            // 
            this.openDestination2.Location = new System.Drawing.Point(1084, 199);
            this.openDestination2.Name = "openDestination2";
            this.openDestination2.Size = new System.Drawing.Size(100, 22);
            this.openDestination2.TabIndex = 16;
            this.openDestination2.Text = "Open Folder";
            this.openDestination2.UseVisualStyleBackColor = true;
            this.openDestination2.Click += new System.EventHandler(this.openDestination2_Click);
            // 
            // openDestination3
            // 
            this.openDestination3.Location = new System.Drawing.Point(1084, 324);
            this.openDestination3.Name = "openDestination3";
            this.openDestination3.Size = new System.Drawing.Size(100, 22);
            this.openDestination3.TabIndex = 17;
            this.openDestination3.Text = "Open Folder";
            this.openDestination3.UseVisualStyleBackColor = true;
            this.openDestination3.Click += new System.EventHandler(this.openDestination3_Click);
            // 
            // openDestination4
            // 
            this.openDestination4.Location = new System.Drawing.Point(1084, 449);
            this.openDestination4.Name = "openDestination4";
            this.openDestination4.Size = new System.Drawing.Size(100, 22);
            this.openDestination4.TabIndex = 18;
            this.openDestination4.Text = "Open Folder";
            this.openDestination4.UseVisualStyleBackColor = true;
            this.openDestination4.Click += new System.EventHandler(this.openDestination4_Click);
            // 
            // openDestination5
            // 
            this.openDestination5.Location = new System.Drawing.Point(1084, 551);
            this.openDestination5.Name = "openDestination5";
            this.openDestination5.Size = new System.Drawing.Size(100, 22);
            this.openDestination5.TabIndex = 19;
            this.openDestination5.Text = "Open Folder";
            this.openDestination5.UseVisualStyleBackColor = true;
            this.openDestination5.Click += new System.EventHandler(this.openDestination5_Click);
            // 
            // FolderBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 655);
            this.Controls.Add(this.openDestination5);
            this.Controls.Add(this.openDestination4);
            this.Controls.Add(this.openDestination3);
            this.Controls.Add(this.openDestination2);
            this.Controls.Add(this.openDestination1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.destinationButton5);
            this.Controls.Add(this.destinationButton4);
            this.Controls.Add(this.destinationButton3);
            this.Controls.Add(this.destinationButton2);
            this.Controls.Add(this.destinationButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FolderBrowse";
            this.RightToLeftLayout = true;
            this.Text = "Picture Sort";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button destinationButton1;
        private System.Windows.Forms.Button destinationButton2;
        private System.Windows.Forms.Button destinationButton3;
        private System.Windows.Forms.Button destinationButton4;
        private System.Windows.Forms.Button destinationButton5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button openDestination1;
        private System.Windows.Forms.Button openDestination2;
        private System.Windows.Forms.Button openDestination3;
        private System.Windows.Forms.Button openDestination4;
        private System.Windows.Forms.Button openDestination5;
    }
}

