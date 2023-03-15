using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public class Division
    {
        //1) Realizar una método que al ingresar un valor genere una simple excepción 
        //al intentar hacer una división por cero.
        //Esta misma excepción deberá ser capturada, 
        //mostrando el mensaje de la excepción y siempre deberá avisar cuando terminó 
        //de realizarse la operación haya sido exitosa o no.



        public string ExceptionByZero(int num)
        {
            string resultado = "";

            try
            {
               resultado = (num / 0).ToString();
            }
            catch(DivideByZeroException ex)
            { 
                resultado = (ex.Message);
            }
            finally 
            { 
               resultado = resultado + "\n" + "Se termino la operacion";
            }
                return resultado;            
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
         

        public double ExceptionByZero2(string num1, string num2)
        {
            double resultado = 0.0;
            try
            {
                double numero1 = Convert.ToDouble(num1);
                double numero2 = Convert.ToDouble(num2);
                resultado = numero1 / numero2;
            }
            catch(DivideByZeroException e)
            {
                throw new Exception("Intentaste dividir por el saldo de mi cuenta bancaria :( " + e.Message);
            }
            catch(Exception e)
            {
                throw new Exception("Seguro Ingreso una letra o no ingreso nada");
            }
            return resultado;
        }




    }
}
