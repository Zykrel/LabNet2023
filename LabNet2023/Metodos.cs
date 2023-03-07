using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public class Metodos
    {   
        //1) Realizar una método que al ingresar un valor genere una simple excepción 
        //al intentar hacer una división por cero.
        //Esta misma excepción deberá ser capturada, 
        //mostrando el mensaje de la excepción y siempre deberá avisar cuando terminó 
        //de realizarse la operación haya sido exitosa o no.



        public bool DivisionPorCero(int num)
        {
            bool retorna = false;
            try
            {
                Console.WriteLine(num / 0);
            }
            catch(DivideByZeroException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                Console.WriteLine("Se termino la operacion"); 
            }
            return retorna;
        }

         
         //  2) Realizar un método que permita ingresar 2 números 
         //  (dividendo y divisor) y realice la división de los mismos.
         //  Se deberán mostrar el resultado (Si es un Unit Test tener 
         //  en cuenta los Assert). 
         //  Si hay una excepción de división por cero se deberá mostrar
         //  el siguiente mensaje: “Solo Chuck Norris divide por cero!” 
         //  (Se acepta todo tipo de creatividad) más el mensaje de la 
         //  excepción propia. También se deberá capturar una excepción 
         //  si el usuario no ingresa ningún número o el mismo no es un 
         //  número válido, informando la situación de “Seguro Ingreso 
         //  una letra o no ingreso nada!”.
         

        public bool DivisionPorCero2(int num1, int num2)
        {
            bool retorna = false;
            try
            {
                Console.WriteLine(num1 / num2);
                retorna= true;
            }
            catch(DivideByZeroException ex)
            {

                Console.WriteLine("Ni Einstein hubiera hecho esta división");
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Dato ingresado no valido");
            }
            finally
            {
                Console.WriteLine("Termino la operacion");

            }
            return retorna;
        }




    }
}
