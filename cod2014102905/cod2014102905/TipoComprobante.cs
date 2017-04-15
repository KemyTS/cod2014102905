using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod2014102905
{
    class TipoComprobante
    {
        public static int BOLETA = 0;
        public static int FACTURA = 1;
        public String NombreComprobante { get; }

        public TipoComprobante(int i)
        {
            if (i == BOLETA)
            {
                NombreComprobante = "Boleta";
            }
            else
            {
                NombreComprobante = "Factura";
            }
        }
    }
}
