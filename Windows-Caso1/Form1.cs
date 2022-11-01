using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Caso1.Models.Derivada;

namespace Windows_Caso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfinarViolin_Click(object sender, EventArgs e)
        {
            Violin miViolin = new Violin();
            MessageBox.Show(miViolin.AfinarInstrumento());
        }

        private void btnAfinarGuitarra_Click(object sender, EventArgs e)
        {
            Guitarra miGuitarra = new Guitarra();
            MessageBox.Show(miGuitarra.AfinarInstrumento());
        }

        private void btnAfinarPiano_Click(object sender, EventArgs e)
        {
            Piano miPiano = new Piano();
            MessageBox.Show(miPiano.AfinarInstrumento());
        }
    }
}
