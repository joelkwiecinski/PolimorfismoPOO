using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Caso4;
using Libreria_Caso4.Models.Derivada;

namespace Windows_Caso4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLeon_Click(object sender, EventArgs e)
        {
            Leon miLeoncito = new Leon("6", "190", "400", "Excelente");
            MessageBox.Show(miLeoncito.Imprimir());
            MessageBox.Show(miLeoncito.ImprimirComida());
        }

        private void btnCrearConejo_Click(object sender, EventArgs e)
        {
            Conejo miConejito = new Conejo("3", "30", "5", "20");
            MessageBox.Show(miConejito.Imprimir());
            MessageBox.Show(miConejito.ImprimirComida());
        }

        private void btnCrearLoro_Click(object sender, EventArgs e)
        {
            Loro miLoro = new Loro("2", "25", "0.3", "Fuerte");
            MessageBox.Show(miLoro.Imprimir());
            MessageBox.Show(miLoro.ImprimirComida());
        }
    }
}
