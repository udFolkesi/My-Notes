namespace My_Notes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trashboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addNew_button = new System.Windows.Forms.Button();
            this.noNotes_label = new System.Windows.Forms.Label();
            this.sorting_comboBox = new System.Windows.Forms.ComboBox();
            this.fileName_label = new System.Windows.Forms.Label();
            this.modifDate_label = new System.Windows.Forms.Label();
            this.files_panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(53, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(84, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(-1, 15);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(54, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem1,
            this.allNotesToolStripMenuItem2,
            this.foldersToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNoteToolStripMenuItem1
            // 
            this.newNoteToolStripMenuItem1.Name = "newNoteToolStripMenuItem1";
            this.newNoteToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.newNoteToolStripMenuItem1.Text = "New Note";
            this.newNoteToolStripMenuItem1.Click += new System.EventHandler(this.newNoteToolStripMenuItem1_Click);
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
            // allNotesToolStripMenuItem
            // 
            this.allNotesToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.allNotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.allNotesToolStripMenuItem1,
            this.trashboxToolStripMenuItem});
            this.allNotesToolStripMenuItem.Name = "allNotesToolStripMenuItem";
            this.allNotesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.allNotesToolStripMenuItem.Text = "Notes";
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.newNoteToolStripMenuItem.Text = "New Note";
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            this.foldersToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.foldersToolStripMenuItem.Text = "Folders";
            // 
            // allNotesToolStripMenuItem1
            // 
            this.allNotesToolStripMenuItem1.Name = "allNotesToolStripMenuItem1";
            this.allNotesToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.allNotesToolStripMenuItem1.Text = "All Notes";
            // 
            // trashboxToolStripMenuItem
            // 
            this.trashboxToolStripMenuItem.Name = "trashboxToolStripMenuItem";
            this.trashboxToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.trashboxToolStripMenuItem.Text = "Trashbox";
            // 
            // search_textbox
            // 
            this.search_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.search_textbox.Location = new System.Drawing.Point(597, 15);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(125, 22);
            this.search_textbox.TabIndex = 2;
            this.search_textbox.Text = "Search all notes...";
            this.search_textbox.Click += new System.EventHandler(this.search_textBox_Click);
            // 
            // search_pictureBox
            // 
            this.search_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_pictureBox.BackColor = System.Drawing.Color.Silver;
            this.search_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_pictureBox.Image = global::My_Notes.Properties.Resources.search_icon_png_9985;
            this.search_pictureBox.Location = new System.Drawing.Point(728, 15);
            this.search_pictureBox.Name = "search_pictureBox";
            this.search_pictureBox.Size = new System.Drawing.Size(21, 21);
            this.search_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_pictureBox.TabIndex = 3;
            this.search_pictureBox.TabStop = false;
            this.search_pictureBox.Click += new System.EventHandler(this.search_pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(805, 65);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // addNew_button
            // 
            this.addNew_button.Location = new System.Drawing.Point(53, 71);
            this.addNew_button.Name = "addNew_button";
            this.addNew_button.Size = new System.Drawing.Size(114, 24);
            this.addNew_button.TabIndex = 5;
            this.addNew_button.Text = "+ Add new Note";
            this.addNew_button.UseVisualStyleBackColor = true;
            this.addNew_button.Click += new System.EventHandler(this.addNew_button_Click);
            // 
            // noNotes_label
            // 
            this.noNotes_label.AutoSize = true;
            this.noNotes_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noNotes_label.Location = new System.Drawing.Point(326, 238);
            this.noNotes_label.Name = "noNotes_label";
            this.noNotes_label.Size = new System.Drawing.Size(139, 16);
            this.noNotes_label.TabIndex = 6;
            this.noNotes_label.Text = "Here is until no notes...";
            // 
            // sorting_comboBox
            // 
            this.sorting_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sorting_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sorting_comboBox.FormattingEnabled = true;
            this.sorting_comboBox.Items.AddRange(new object[] {
            "Modif. Date        ↑",
            "Modif. Date        ↓"});
            this.sorting_comboBox.Location = new System.Drawing.Point(597, 71);
            this.sorting_comboBox.Name = "sorting_comboBox";
            this.sorting_comboBox.Size = new System.Drawing.Size(125, 24);
            this.sorting_comboBox.TabIndex = 7;
            this.sorting_comboBox.Text = "Modif. Date        ↑";
            // 
            // fileName_label
            // 
            this.fileName_label.AutoSize = true;
            this.fileName_label.Location = new System.Drawing.Point(53, 102);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(47, 16);
            this.fileName_label.TabIndex = 8;
            this.fileName_label.Text = "Name:";
            // 
            // modifDate_label
            // 
            this.modifDate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifDate_label.AutoSize = true;
            this.modifDate_label.Location = new System.Drawing.Point(604, 102);
            this.modifDate_label.Name = "modifDate_label";
            this.modifDate_label.Size = new System.Drawing.Size(114, 16);
            this.modifDate_label.TabIndex = 9;
            this.modifDate_label.Text = "Modification Date:";
            // 
            // files_panel
            // 
            this.files_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files_panel.BackColor = System.Drawing.Color.Transparent;
            this.files_panel.Location = new System.Drawing.Point(56, 130);
            this.files_panel.Name = "files_panel";
            this.files_panel.Size = new System.Drawing.Size(717, 295);
            this.files_panel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifDate_label);
            this.Controls.Add(this.fileName_label);
            this.Controls.Add(this.sorting_comboBox);
            this.Controls.Add(this.noNotes_label);
            this.Controls.Add(this.addNew_button);
            this.Controls.Add(this.search_pictureBox);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.files_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Notes";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem allNotesToolStripMenuItem;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.PictureBox search_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allNotesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trashboxToolStripMenuItem;
        private System.Windows.Forms.Button addNew_button;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allNotesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem1;
        private System.Windows.Forms.Label noNotes_label;
        private System.Windows.Forms.ComboBox sorting_comboBox;
        private System.Windows.Forms.Label fileName_label;
        private System.Windows.Forms.Label modifDate_label;
        private System.Windows.Forms.Panel files_panel;
    }
}

