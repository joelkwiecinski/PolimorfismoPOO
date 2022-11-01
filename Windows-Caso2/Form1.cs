using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Caso2.Models.Derivada;

namespace Windows_Caso2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoverPeon_Click(object sender, EventArgs e)
        {
            Peon miPeon = new Peon();
            MessageBox.Show(miPeon.MoverPieza());
        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {
            Caballo miCaballo = new Caballo();
            MessageBox.Show(miCaballo.MoverPieza());
        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            Torre miTorre = new Torre();
            MessageBox.Show(miTorre.MoverPieza());
        }
    }
}
