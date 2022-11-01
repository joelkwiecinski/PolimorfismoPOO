using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Caso3;
using Libreria_Caso3.Models.Derivada;

namespace Windows_Caso3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Medico miMedico = new Medico("Alfonso", "Cardiólogo");
            MessageBox.Show(miMedico.ToString());
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            Paciente miPaciente = new Paciente("Joel", "52741342");
            MessageBox.Show(miPaciente.ToString());
        }
    }
}
