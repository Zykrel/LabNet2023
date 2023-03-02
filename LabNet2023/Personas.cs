using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public abstract class cantidadPersonas
    {
        public int pasajeros { get; set; }

        public cantidadPersonas(int pasajeros)
        { 
            this.pasajeros = pasajeros;
        }
        public abstract string Avanzar();
        public abstract string Descripcion();
    }
}
