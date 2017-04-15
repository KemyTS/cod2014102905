﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod2014102905
{
    class Tripulacion:Empleado
    {
        public TipoTripulacion TipoTripulacion { get; set; }
        public int Cantidad { get; set; }

        public Tripulacion(String nombre, String apellidos, String dni, int edad, int cantidad, int tipotripulacion, Decimal sueldo) : base(nombre, apellidos, dni, edad, sueldo)
        {
            Cantidad = cantidad;
            TipoTripulacion = new TipoTripulacion(tipotripulacion);
        }
    }
}
