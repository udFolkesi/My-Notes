using My_Notes.Properties;
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
                    CreateNewListItem(ref point, files[i], i);
                }
            }
        }

        private void CreateNewListItem(ref Point point, string fileName, int index = 0)
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
            file_button.Click += new EventHandler(file_button_Click);
            point.Y += 4;
            Label label = new Label()
            {
                Text = File.GetLastWriteTime(fileName).ToString(),
                Location = new Point(560, 5),
                BackColor = Color.LightGray,
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(80, 20),
            };
            Button delete_button = new Button()
            {
                Image = Resources.icons8_trash_24,
                Size = new Size(15, 20),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(650, 5),
                Cursor = Cursors.Hand,
                //Visible = false,
            };
            delete_button.FlatAppearance.BorderSize = 0;
            delete_button.MouseEnter += new EventHandler(delete_button_MouseEnter);
            panel.Controls.Add(file_button);
            panel.Controls.Add(label);
            panel.Controls.Add(delete_button);
            files_panel.Controls.Add(panel);
            files_panel.Controls[index].Controls[0].MouseEnter += new EventHandler(panel_MouseEnter);
            files_panel.Controls[index].Controls[0].MouseLeave += new EventHandler(panel_MouseLeave);
            files_panel.Controls[index].Controls[2].MouseEnter += new EventHandler(delete_button_MouseEnter);
            files_panel.Controls[index].Controls[2].MouseLeave += new EventHandler(delete_button_MouseLeave);
            files_panel.Controls[index].Controls[2].Click += new EventHandler(delete_button_Click);
            label.BringToFront();
            delete_button.BringToFront();
            point.Y += 35;
            files_panel.Controls[index].BringToFront();
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

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                //button.Parent.Controls[0].Visible = true;
                button.Parent.Controls[1].BackColor = Color.Silver;
                //button.Parent.Controls[0].BackColor = Color.Gray;
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                //button.Parent.Controls[0].Visible = false;
                button.Parent.Controls[1].BackColor = Color.LightGray;
            }
        }

        private void delete_button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                //button.Parent.Controls[0].Visible = true;
                button.Parent.Controls[0].BackColor = Color.OrangeRed;
            }
        }

        private void delete_button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                //button.Parent.Controls[0].Visible = false;
                button.Parent.Controls[0].BackColor = Color.Transparent;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
