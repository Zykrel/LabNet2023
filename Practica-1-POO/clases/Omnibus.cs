using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_POO
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base (pasajeros) 
        {
            
        }
        public override string Avanzar()
        {
            return "El omnibus esta avanzando";
        }

        public override string Detenerse()
        {
            return "El omnibus se detuvo";
        }

        public override string Mostrar()
        {
            return $"El omnibus tiene {base.Pasajeros} pasajeros";
        }
    }
}
