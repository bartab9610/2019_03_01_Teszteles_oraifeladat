using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_01_Oraimunka_teszteles_jaratkezelo
{
    class NegativKesesException: Exception
    {
        public NegativKesesException(string jaratszam)
            : base("Tényleges késés nem lehet 0" + jaratszam)
        {

        }
    }
}
