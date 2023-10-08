namespace My_Notes
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fonts_comboBox = new System.Windows.Forms.ComboBox();
            this.fontSizes_comboBox = new System.Windows.Forms.ComboBox();
            this.canvas_richTextBox = new System.Windows.Forms.RichTextBox();
            this.color_button = new System.Windows.Forms.Button();
            this.nameSetter_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(805, 51);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(55, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(86, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(1, 15);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(56, 30);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem1,
            this.allNotesToolStripMenuItem2,
            this.foldersToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNoteToolStripMenuItem1
            // 
            this.newNoteToolStripMenuItem1.Name = "newNoteToolStripMenuItem1";
            this.newNoteToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.newNoteToolStripMenuItem1.Text = "New Note";
            // 
            // allNotesToolStripMenuItem2
            // 
            this.allNotesToolStripMenuItem2.Name = "allNotesToolStripMenuItem2";
            this.allNotesToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.allNotesToolStripMenuItem2.Text = "All Notes";
            // 
            // foldersToolStripMenuItem1
            // 
            this.foldersToolStripMenuItem1.Name = "foldersToolStripMenuItem1";
            this.foldersToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.foldersToolStripMenuItem1.Text = "Folders";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Location = new System.Drawing.Point(-21, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(852, 35);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // fonts_comboBox
            // 
            this.fonts_comboBox.FormattingEnabled = true;
            this.fonts_comboBox.Location = new System.Drawing.Point(65, 53);
            this.fonts_comboBox.Name = "fonts_comboBox";
            this.fonts_comboBox.Size = new System.Drawing.Size(99, 24);
            this.fonts_comboBox.TabIndex = 12;
            this.fonts_comboBox.Text = "Arial";
            this.fonts_comboBox.TextChanged += new System.EventHandler(this.fonts_comboBox_TextChanged);
            // 
            // fontSizes_comboBox
            // 
            this.fontSizes_comboBox.DisplayMember = "1";
            this.fontSizes_comboBox.FormattingEnabled = true;
            this.fontSizes_comboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizes_comboBox.Location = new System.Drawing.Point(179, 53);
            this.fontSizes_comboBox.Name = "fontSizes_comboBox";
            this.fontSizes_comboBox.Size = new System.Drawing.Size(51, 24);
            this.fontSizes_comboBox.TabIndex = 13;
            this.fontSizes_comboBox.Text = "8";
            this.fontSizes_comboBox.TextChanged += new System.EventHandler(this.fontSizes_comboBox_TextChanged);
            // 
            // canvas_richTextBox
            // 
            this.canvas_richTextBox.Location = new System.Drawing.Point(65, 98);
            this.canvas_richTextBox.Name = "canvas_richTextBox";
            this.canvas_richTextBox.Size = new System.Drawing.Size(707, 326);
            this.canvas_richTextBox.TabIndex = 14;
            this.canvas_richTextBox.Text = "";
            // 
            // color_button
            // 
            this.color_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color_button.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_button.ForeColor = System.Drawing.Color.Black;
            this.color_button.Location = new System.Drawing.Point(245, 53);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(71, 24);
            this.color_button.TabIndex = 15;
            this.color_button.Text = "Black";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // nameSetter_textBox
            // 
            this.nameSetter_textBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameSetter_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameSetter_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameSetter_textBox.Location = new System.Drawing.Point(657, 25);
            this.nameSetter_textBox.Name = "nameSetter_textBox";
            this.nameSetter_textBox.Size = new System.Drawing.Size(115, 15);
            this.nameSetter_textBox.TabIndex = 16;
            this.nameSetter_textBox.Text = "Note Name...";
            this.nameSetter_textBox.Click += new System.EventHandler(this.nameSetter_textBox_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.save_button.BackgroundImage = global::My_Notes.Properties.Resources._149111;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Location = new System.Drawing.Point(636, 25);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(15, 15);
            this.save_button.TabIndex = 17;
            this.save_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.nameSetter_textBox);
            this.Controls.Add(this.color_button);
            this.Controls.Add(this.canvas_richTextBox);
            this.Controls.Add(this.fontSizes_comboBox);
            this.Controls.Add(this.fonts_comboBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "EditNote";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allNotesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox fonts_comboBox;
        private System.Windows.Forms.ComboBox fontSizes_comboBox;
        private System.Windows.Forms.RichTextBox canvas_richTextBox;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.TextBox nameSetter_textBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button save_button;
    }
}