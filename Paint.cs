using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACIÓN
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void paletaColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                BackColor = color;
            }
        }
    }
}
