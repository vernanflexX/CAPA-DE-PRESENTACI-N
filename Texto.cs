using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACIÓN
{
    public partial class Texto  : Form
    {
        String Archivo;
        public Texto()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Texto|*.txt";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Archivo = OpenFile.FileName;
                using (StreamReader A = new StreamReader(Archivo))
                {
                    richTextBox1.Text = A.ReadToEnd();
                }

            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.txt";
            if (Archivo != null)
            {
                using (StreamWriter G = new StreamWriter(Archivo))
                {
                    G.Write(richTextBox1.Text);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Archivo = SaveFile.FileName;
                    using (StreamWriter g = new StreamWriter(SaveFile.FileName))
                    {
                        
                        g.Write(richTextBox1.Text);

                    }
                }


            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void atrás_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void forrmato_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();

            if (fuente.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fuente.Font;
            }
        }
        private void nuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            archivo = null;
        }
    }
}
