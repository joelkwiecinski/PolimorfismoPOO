using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Caso1.Models.Base;

namespace Libreria_Caso1.Models.Derivada
{
    public class Piano : InstrumentoMusical
    {
        public override string AfinarInstrumento()
        {
            return "do re mi fa sol la si... Afinando piano!";
        }
    }
}

