using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Caso2.Models.Derivada
{
    public class Peon: PiezaAjedrez
    {
        public override string MoverPieza()
        {
            return "Moviendo peón";
        }
    }
}
