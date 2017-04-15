using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod2014102905
{
    class Bus
    {
        public String Placa { get; set; }
        public String SerieMotor { get; set; }
        public Tripulacion Tripulacion { get; set; }
     

        public Bus(int pasajeros)
        {

            Placa = String.Empty;
            SerieMotor = String.Empty;
           
        }
    
}
}

