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
                noNotes_label.Visible = false;
                Point point = new Point() { X = addNew_button.Location.X + 40, Y = addNew_button.Location.Y };
                Controls.Add(new Label() { Text = "New Note", Location = point});
                for (int i = 1; i < Directory.GetFiles(notesPath).Length; i++)
                {
                    Controls.Add(new Label() { Text = "0adadaa", Location = new Point().});
                }
            }
        }
    }
}
