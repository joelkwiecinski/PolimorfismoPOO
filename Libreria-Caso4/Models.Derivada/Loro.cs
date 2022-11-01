using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Caso4.Models.Derivada
{
    public class Loro: Animal
    {
        public string Canto { get; set; }

        public Loro(string edad, string altura, string peso, string canto) : base(edad, altura, peso)
        {
            Canto = canto;
        }

        public override string ImprimirComida()
        {
            return "ñam ñam ñam dijo el loro, comiendo semillas";
        }

        public override string Imprimir()
        {
            return base.Imprimir() + ", intensidad del canto: " + Canto;
        }
    }
}
