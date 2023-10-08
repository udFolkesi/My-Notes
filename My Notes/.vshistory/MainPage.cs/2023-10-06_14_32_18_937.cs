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
            LoadNotes();
        }

        private void LoadNotes()
        {
            if(Directory.GetFiles(notesPath).Length > 0)
            {
                //Graphics.
                noNotes_label.Visible = false;
                Point point = new Point(addNew_button.Location.X + 30, addNew_button.Location.Y + 40);
                Controls.Add(new LinkLabel() { Text = "New Note", Location = point, Dock = DockStyle.None });
                Controls.Add(new PictureBox() { BackColor = Color.Gray, Location = new Point(addNew_button.Location.X + 30, addNew_button.Location.Y + 40), Dock = DockStyle.None });
                for (int i = 1; i < Directory.GetFiles(notesPath).Length; i++)
                {
                    point.Y += 30;
                    Controls.Add(new LinkLabel() { Text = "New Note", Location = point});
                }
            }
        }
    }
}
