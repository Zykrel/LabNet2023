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
            Division metodo = new Division();
            //Ejercicio 1
            Console.WriteLine(" EJERCICIO 1: ");
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            metodo.ExceptionByZero(numero);
            
            //Ejercicio 2
            Console.WriteLine("\n EJERCICIO 2: ");
            Console.Write("Ingrese un numero: ");
            string numero1 = (Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            string numero2 = (Console.ReadLine());
            double resultado = metodo.ExceptionByZero2(numero1, numero2);


            //Ejercicio 3
            Console.WriteLine("\n EJERCICIO 3: ");
            try
            {
                Logic logica = new Logic();
                logica.FueraRango();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            //Ejercicio 4
            Console.WriteLine("\n EJERCICIO 4: ");
            try
            {
                Logic logica = new Logic();
                logica.LanzarException();
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

       
    }
    
}
