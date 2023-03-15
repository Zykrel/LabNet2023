using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string flag = "";

            Division division = new Division();

            do
            {
                Console.WriteLine("Lista de opciones: ");
                Console.WriteLine("1.Ejecutar primer ejercicio \n 2.Ejecutar segundo ejercicio \n 3.Ejecutar tercer ejercicio \n 4.Ejecutar cuarto ejercicio");
                Console.WriteLine("Escriba cual accion desea realizar: ");
                string accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":
                        Ejercicio1(division);
                        break;
                    case "2":
                        Ejercicio2(division);
                        break;
                    case "3":
                        Ejercicio3(division);
                        break;
                    case "4":
                        Ejercicio4(division);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.WriteLine("Desea continuar? Escriba No para terminar: ");
                flag = Console.ReadLine();

            } while (flag.PrimeraMayuscula() != "No");
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
       
        internal static void Ejercicio1(Division division)
        {
            Console.WriteLine(" EJERCICIO 1: ");

            bool pudoConvertir;
            int numero;
            do
            {
                Console.Write("Ingrese un numero: ");
                string entrada = Console.ReadLine();             
                pudoConvertir = int.TryParse(entrada, out numero);
            } while (!pudoConvertir);
            Console.WriteLine(division.ExceptionByZero(numero));
                        
        }

        internal static void Ejercicio2(Division division) 
        {
            Console.WriteLine("\n EJERCICIO 2: ");

            Console.Write("Ingrese un numero: ");
            string numero1 = (Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            string numero2 = (Console.ReadLine());
            try
            {
                double resultado = division.ExceptionByZero2(numero1, numero2);
                Console.WriteLine("el resultado es: " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void Ejercicio3(Division division) 
        {
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
        }

        internal static void Ejercicio4(Division division) 
        {
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
        }
       
    }
    
}
