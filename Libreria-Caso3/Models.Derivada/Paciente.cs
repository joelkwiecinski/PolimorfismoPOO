using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Caso3.Models.Derivada
{
    public class Paciente:Persona
    {
        public Paciente(string nombre, string idcartilla) : base(nombre)
        {
            IDCartilla = idcartilla;
        }

        public string IDCartilla { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nCartilla: " + IDCartilla;
        }
    }
}
