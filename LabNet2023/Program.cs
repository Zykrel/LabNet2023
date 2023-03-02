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
            List<cantidadPersonas> pasajeros = new List<cantidadPersonas>
            {
                new omnibus(30),
                new omnibus(10),
                new omnibus(20),
                new omnibus(40),
                new omnibus(28),

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
