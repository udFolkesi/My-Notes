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
            FillComboBoxes();
            canvas_textBox.Font = new Font("Arial", fontSizes_comboBox.SelectedValue);
        }

        private void FillComboBoxes()
        {
            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }

            fonts_comboBox.DataSource = fonts;
        }
    }
}
