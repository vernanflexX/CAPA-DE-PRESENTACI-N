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
    public partial class MultiAPP : Form
    {
        Paint framecolor;
        Texto frametexto;
        public MultiAPP()
        {
            InitializeComponent();
            framecolor = new Paint();
            frametexto = new Texto();
        }

        private void paint_Click(object sender, EventArgs e)
        {
            framecolor.ShowDialog();
        }

        private void editorTexto_Click(object sender, EventArgs e)
        {
            frametexto.ShowDialog();
        }
    }
}
