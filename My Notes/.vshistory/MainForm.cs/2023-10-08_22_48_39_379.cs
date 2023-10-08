using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notes
{
    public partial class MainForm : Form
    {
        private string notesPath = @"..\..\Data";
        private List<(string, string)> values;
        public MainForm()
        {
            InitializeComponent();
            files_panel.AutoScroll = true;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        public void LoadNotes()
        {
            if(Directory.GetFiles(notesPath).Length > 0)
            {
                string[] files = Directory.GetFiles(notesPath);
                noNotes_label.Visible = false;
                Point point = new Point(0, 0);
                for (int i = 0; i < Directory.GetFiles(notesPath).Length; i++)
                {
                    CreateNewListItem(ref point, files[i]);
                }
            }
        }

        private void CreateNewListItem(ref Point point, string fileName)
        {
            Panel panel = new Panel()
            {
                BackColor = Color.Transparent,
                Size = new Size(705, 30),
                Location = point,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            };  
            Button file_button = new Button()
            {
                Text = Path.GetFileName(fileName),
                BackColor = Color.LightGray,
                Size = new Size(705, 30),
                TextAlign = ContentAlignment.MiddleLeft,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            };
            file_button.FlatAppearance.BorderSize = 0;
            file_button.MouseEnter += new EventHandler(file_button_MouseEnter);
            file_button.Click += new EventHandler(file_button_Click);
            point.X += 570;
            point.Y += 4;
            Label label = new Label()
            {
                Text = File.GetLastWriteTime(fileName).ToString(),
                Location = new Point(0, 570),
                BackColor = Color.LightGray,
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(80, 20),
            };
            files_panel.Controls.Add(panel);
            panel.Controls.Add(file_button);
            panel.Controls.Add(label);
            label.BringToFront();
            point.X -= 570;
            point.Y += 35;
        }

        private void search_pictureBox_Click(object sender, EventArgs e)
        {
            if (!Directory.GetFiles(notesPath).Any(x => Path.GetFileName(x) == search_textbox.Text))
            {
                MessageBox.Show("Oops, likely, there is no such note..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                files_panel.Controls.Clear();
                Point point = new Point(0, 0);
                CreateNewListItem(ref point, search_textbox.Text);
            }
        }

        private void addNew_button_Click(object sender, EventArgs e)
        {
            EditNote editNote = new EditNote();
            editNote.Show();
        }

        private void newNoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditNote newNote = new EditNote();
            newNote.Show();
        }

        private void file_button_MouseEnter(object sender, EventArgs e)
        {

        }

        private void file_button_Click(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                EditNote editNote = new EditNote();
                editNote.Show();
                editNote.RichTextBox.LoadFile($"{notesPath}/{button.Text}", RichTextBoxStreamType.RichText);
                editNote.TextBox.Text = button.Text;
            }
        }

        private void search_textBox_Click(object sender, EventArgs e)
        {
            search_textbox.Text = string.Empty;
        }

        private void allNotesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }
    }
}
