using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public class Taxi : cantidadPersonas
    {
        public Taxi(int pasajeros) : base(pasajeros) 
        {
        
        }
        public override string Avanzar()
        {
            return $"El taxi tiene {pasajeros} pasajeros";
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
