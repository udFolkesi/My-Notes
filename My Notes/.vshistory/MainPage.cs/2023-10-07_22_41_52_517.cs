using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notes
{
    public partial class MainPage : Form
    {
        private string notesPath = @"..\..\Data";
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 500, 700));
            myBrush.Dispose();
            formGraphics.Dispose();
            LoadNotes();
        }

        private void LoadNotes()
        {
            if(Directory.GetFiles(notesPath).Length > 0)
            {
                string[] files = Directory.GetFiles(notesPath);
                noNotes_label.Visible = false;
                Point point = new Point(addNew_button.Location.X, addNew_button.Location.Y + 40);
                for (int i = 0; i < Directory.GetFiles(notesPath).Length; i++)
                {
                    PictureBox pictureBox = new PictureBox() { BackColor = Color.LightGray, Location = point, Size = new Size(705, 24), Dock = DockStyle.None };
                    Controls.Add(pictureBox);
                    pictureBox.MouseEnter += new System.EventHandler(note_file_MouseEnter);
                    LinkLabel linkLabel = new LinkLabel() { Text = Path.GetFileName(files[i]), Location = point };
                    Controls.Add(linkLabel);
                    linkLabel.BringToFront();
                    linkLabel.BackColor = Color.LightGray;
                    point.X += 600;
                    Label label = new Label() { Text = File.GetLastWriteTime(files[i]).ToString(), Location = point, BackColor = Color.LightGray };
                    Controls.Add(label);
                    label.BringToFront();
                    point.X -= 600;
                    point.Y += 30;
                }
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

        private void note_file_MouseEnter(object sender, EventArgs e)
        {
            if(sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = Color.LightSlateGray;
            }
        }
    }
}
