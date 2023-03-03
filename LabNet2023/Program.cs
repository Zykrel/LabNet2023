using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<TransportePublico> pasajeros = new List<TransportePublico>
            {
                new Omnibus(30),
                new Omnibus(10),
                new Omnibus(20),
                new Omnibus(40),
                new Omnibus(28),

                new Taxi(2),
                new Taxi(3),
                new Taxi(4),
                new Taxi(2),
                new Taxi(1)


            };

            foreach (var item in pasajeros)
            {
                Console.WriteLine(item.Avanzar());
            }

            Console.ReadLine();
        }
    }
}
