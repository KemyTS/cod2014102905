using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod2014102905
{
    class Administrativo:Empleado
    {
        public String Cargo { get; set; }
        public Administrativo(String nombre, String apellidos, String dni, int edad, Decimal sueldo) : base(nombre, apellidos, dni, edad, sueldo)
        {
            Cargo = String.Empty;
        }
    }
}
