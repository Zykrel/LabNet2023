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
            Metodos metodo = new Metodos();
            //Ejercicio 1
            Console.WriteLine(" EJERCICIO 1: ");
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            metodo.DivisionPorCero(numero);
            
            //Ejercicio 2
            Console.WriteLine(" EJERCICIO 2: ");
            Console.Write("Ingrese un numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            metodo.DivisionPorCero2(numero1, numero2);

            //Ejercicio 3
            Console.WriteLine(" EJERCICIO 3: ");
            try
            {
                Logica logica = new Logica();
                logica.fueraRango();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            //Ejercicio 4
            Console.WriteLine(" EJERCICIO 4: ");
            try
            {
                Logica logica = new Logica();
                logica.fueraRango2();
            }
            catch (LogicException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            Console.ReadLine();
        }

       
    }
    
}
