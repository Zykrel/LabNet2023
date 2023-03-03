using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_POO
{
    public abstract class TransportePublico
    {
        private int pasajeros;
        public int Pasajeros { get { return this.pasajeros; } }

        public TransportePublico(int pasajeros)
        { 
            this.pasajeros = pasajeros;
        }
        public abstract string Avanzar();
        public abstract string Detenerse();
        public abstract string Mostrar();
    }
}
