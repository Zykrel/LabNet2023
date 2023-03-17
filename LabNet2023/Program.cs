using Entities;
using Lab.EF.Data2;
using LabLogic;
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
            string flag = "";
            Console.WriteLine("Elija la opcion deseada: ");
            Console.WriteLine("1.Obtener objeto Customer \n 2. devolver todos los productos sin stock" +
                "\n 3.devolver todos los productos que tienen stock y que cuestan más de 3 por unidad " +
                "\n 4.devolver todos los customers de la Región WA \n 5.devolver primer elemonto o nulo de una lista con ID 789" +
                "\n 6.devolver lista de customers en Mayuscula y Minuscula \n 7.devuelve join entre customers y orders" +
                "\n 8.devolver los primeros 3 Customers de la  Región WA \n 9.devolver lista de productos ordenados por nombre" +
                "\n 10.devolver lista de productos ordenados por unit in stock de mayor a menor " +
                "\n 11.devolver las distintas categorías asociadas a los productos" +
                "\n 12.devolver el primer elemento de una lista de productos \n 13.devolver los customer con la cantidad de ordenes asociadas ");
            do
            {
                string opcion = Console.ReadLine();
                Menu(opcion);
                Console.WriteLine("Desea continuar? Escriba No para Finalizar");
                flag = Console.ReadLine();

            } while (flag.ToUpper() != "NO");
        }

        internal static void Menu(string opcion) 
        {
            CustomerLogic customerLogic = new CustomerLogic();
            ProductsLogic productsLogic = new ProductsLogic();
            switch(opcion)
            {
                case "1":  Customers customer = customerLogic.ObtenerCustomer();
               Console.WriteLine($"Customer ID: {customer.CustomerID} \n Contact Name: {customer.ContactName}");
                                               break;
                case "2": List<Products> prodSinStock = productsLogic.ObtenerProductosSinStock();
                    prodSinStock.ForEach(product => Console.WriteLine($"ID: {product.ProductID} Product Name: {product.ProductName} Stock: {product.UnitsInStock}"));
                                               break;
                case "3": List<Products> prodConStock = productsLogic.ObtenerProductosConStock();
                    prodConStock.ForEach(product => Console.WriteLine($"ID: {product.ProductID} Product Name: {product.ProductName} Stock: {product.UnitsInStock}"));
                    break;
                case "4": List<Customers> customerRegionWA = customerLogic.ObtenerCustomerDeWA();
                    customerRegionWA.ForEach(c => Console.WriteLine($"Customer: {c.CustomerID}  Region {c.Region}"));
                                               break;
                case "5": Products prod = productsLogic.ObtenerPrimerElementoONulo();
                    Console.WriteLine(prod != null ? $"{prod.ProductName}" : "Es nulo");
                                               break;
                case "6": List<string> customers = customerLogic.ListaDeNombres();
                    customers.ForEach(c => Console.WriteLine(c));
                                               break;
                case "7": List<CustomersOrders> cust = customerLogic.ObtenerJoinOrders();
                    cust.ForEach(c => Console.WriteLine($"Customers: {c.customerID} Order ID: {c.orderID} Fecha de order: {c.orderDate} "));
                                               break;
                case "8": List<Customers> custo = customerLogic.ObtenerTresPrimerosCustomersDeWA();
                    custo.ForEach(c => Console.WriteLine($"Customer: {c.ContactName} Region: {c.Region}"));
                                               break;
                case "9": List<Products> produtsL = productsLogic.ListaOrdenadaPorNombre();
                    produtsL.ForEach(p => Console.WriteLine($"Productos: {p.ProductName}"));
                                                break;
                case "10": List<Products> prodUnitStock = productsLogic.ProductosOrdenados();
                    prodUnitStock.ForEach(p => Console.WriteLine($"Products: {p.ProductName} Stock: {p.UnitsInStock}"));
                                                break;
                case "11": List<string> list = productsLogic.ObtenerProductosYCategorias();
                    list.ForEach(p => Console.WriteLine(p));
                                                break;
                case "12": Products primerElemento = productsLogic.ObtenerPrimerElemento();
                    Console.WriteLine($"Primer elemento: {primerElemento.ProductName} ID: {primerElemento.ProductID}" );
                                                break;



                default: Console.WriteLine("Opcion incorrecta");
                                               break;





            }        
        }
    }
}
