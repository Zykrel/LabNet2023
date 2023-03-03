using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_POO
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros) 
        {
        
        }
        public override string Avanzar()
        {
            return "El taxi esta avanzando";
        }

        public override string Detenerse()
        {
            return "El taxi se detuvo";
        }

        public override string Mostrar()
        {
            return $"El taxi tiene {base.Pasajeros} pasajeros";
        }
    }
}
