using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Caso4.Models.Derivada
{
    public class Leon:Animal
    {
        public string Salud { get; set; }

        public Leon(string edad, string altura, string peso, string salud):base(edad, altura, peso)
        {
            Salud = salud;
        }

        public override string ImprimirComida()
        {
            return "ñam ñam ñam dijo el león, comiendo carne";
        }

        public override string Imprimir()
        {
            return base.Imprimir() + ", salud: " + Salud;
        }
    }
}
