using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notes
{
    public partial class EditNote : Form
    {
        public EditNote()
        {
            InitializeComponent();
            comboBox1.Items.Add(Color.Black);
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
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                canvas_richTextBox.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
