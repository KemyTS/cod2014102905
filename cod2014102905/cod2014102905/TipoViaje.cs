using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod2014102905
{
    class TipoViaje
    {
        public static int NORMAL = 0;
        public static int VIP = 1;
        public String Nombre { get; }

        public TipoViaje(int i)
        {
            if (i == NORMAL)
            {
                Nombre = "Bus Normal";
            }
            else
            {
                Nombre = "Bus Cama";
            }

        }
    }
}
