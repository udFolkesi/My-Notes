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
    public partial class EditForm : Form
    {
        private readonly string notesPath = @"..\..\Data";
        public RichTextBox RichTextBox
        {
            get { return canvas_richTextBox; }
        }

        public TextBox TextBox
        {
            get { return nameSetter_textBox; }
            set { nameSetter_textBox = value; }
        }

        public EditForm()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }

            fonts_comboBox.DataSource = fonts;
            fonts_comboBox.SelectedItem = "Arial";
        }

        private void fonts_comboBox_TextChanged(object sender, EventArgs e)
        {
            canvas_richTextBox.SelectionFont = new Font(fonts_comboBox.Text, Convert.ToInt32(fontSizes_comboBox.Text));
        }

        private void fontSizes_comboBox_TextChanged(object sender, EventArgs e)
        {
            canvas_richTextBox.SelectionFont = new Font(fonts_comboBox.Text, Convert.ToInt32(fontSizes_comboBox.Text));
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color_button.Text = colorDialog1.Color.Name.ToString();
                color_button.ForeColor = colorDialog1.Color;
                canvas_richTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (nameSetter_textBox.Text != string.Empty && nameSetter_textBox.Text != "Note Name...")
            {
                canvas_richTextBox.SaveFile($"{notesPath}/{nameSetter_textBox.Text}", RichTextBoxStreamType.RichText);
                if (Application.OpenForms["MainForm"] != null)
                {
                    (Application.OpenForms["MainForm"] as MainForm).LoadNotes();
                }
            }
            else
            {
                MessageBox.Show("Please, give your file a name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nameSetter_textBox_Click(object sender, EventArgs e)
        {
            if (nameSetter_textBox.Text == "Note Name...")
            {
                nameSetter_textBox.Text = string.Empty;
            }
        }

        private void italic_button_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                color_button.Text = colorDialog1.Color.Name.ToString();
                color_button.ForeColor = colorDialog1.Color;
                canvas_richTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool fileExists = false;
            if (File.Exists($"{notesPath}/{nameSetter_textBox.Text}"))
            {
                fileExists = true;
            }

            if (canvas_richTextBox.Tag is true && !fileExists)             
            {
                DialogResult dialogResult = MessageBox.Show("Changes made were not saved. Would you like to save your note before closing?\"", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFile();
                    e.Cancel = true;
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
/*            else if(canvas_richTextBox.Tag is true && fileExists
                && canvas_richTextBox.Text != File.ReadAllText($"{notesPath}/{nameSetter_textBox.Text}"))
            {
                DialogResult dialogResult = MessageBox.Show("Changes made were not saved. Would you like to save your note before closing?\"", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFile();
                    e.Cancel = true;
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }*/
        }

        private void canvas_richTextBox_TextChanged(object sender, EventArgs e)
        {
            canvas_richTextBox.Tag = true;
        }

        private void EditForm_Shown(object sender, EventArgs e)
        {
            canvas_richTextBox.TextChanged += new EventHandler(canvas_richTextBox_TextChanged);
        }

        private void bold_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetFontStyle();
        }

        private void italic_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetFontStyle();
        }

        private void SetFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (bold_checkBox.Checked)
                style |= FontStyle.Bold;

            if (italic_checkBox.Checked)
                style |= FontStyle.Italic;

            canvas_richTextBox.SelectionFont = new Font(fonts_comboBox.Text, Convert.ToInt32(fontSizes_comboBox.Text), style);
        }
    }
}
