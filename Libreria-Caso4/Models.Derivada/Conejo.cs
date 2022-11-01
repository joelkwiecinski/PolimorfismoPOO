using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Caso4.Models.Derivada
{
    public class Conejo: Animal
    {
        public string Salto { get; set; }

        public Conejo(string edad, string altura, string peso, string salto) : base(edad, altura, peso)
        {
            Salto = salto;
        }

        public override string ImprimirComida()
        {
            return "ñam ñam ñam dijo el conejo, comiendo pastito";
        }

        public override string Imprimir()
        {
            return base.Imprimir() + ", altura del salto: " + Salto + "cm";
        }
    }
}
