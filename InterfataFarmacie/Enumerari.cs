using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataFarmacie
{
    [Flags]
    public enum ErrorCode
    {
        CORRECT=0,
        NUME_INCORECT=1,
        PRET_INCORECT=2,
        RETETA_INCORECTA=4,
        ADMINISTRARE_INCORECTA=8
        
        
    }
}
