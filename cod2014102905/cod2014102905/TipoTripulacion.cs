using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod2014102905
{
    class TipoTripulacion
    {
        public static int CONDUCTOR = 0;
        public static int AZAFATA = 1;

        public String Nombre { get; }

        public TipoTripulacion(int i)
        {
            if (i == CONDUCTOR)
            {
                Nombre = "Tripulante Conductor";
            }
            else
            {
                Nombre = "Tripulante Azafata";
            }
        }

    }
}

