using Lab.EF.Data2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLogic
{
    public class CustomerLogic : LogicaBase
    {
        // 1.Query para devolver objeto customer


        //Devuelvo Customer por ID
         public Customers ObtenerCustomerPorID(string id)
        {
            var query = from c 
                        in _northwindcontext.Customers
                        where c.CustomerID == id
                        select c;
            return query.Single();
        }

        //Devuelvo el primero
        public Customers ObtenerCustomer()
        {
            var query = from c
                        in _northwindcontext.Customers                        
                        select c;
            return query.FirstOrDefault();
        }

        //4. Query para devolver todos los customers de la Región WA

        public List<Customers> ObtenerCustomerDeWA() 
        {
            var query = from c
                        in _northwindcontext.Customers
                        where c.Region == "WA"
                        select c;
            return query.ToList();
        }

        //6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.

        public List<string> ListaDeNombres() 
        {
            var query = from c
                        in _northwindcontext.Customers
                        select new
                        {
                            nombreMayuscula = c.ContactName.ToUpper(),
                            nombreMinuscula = c.ContactName.ToLower()

                        };
            List<string> strings= new List<string>();

            foreach (var item in query.ToList())
            {
                strings.Add($"Nombre Mayuscula: {item.nombreMayuscula} | Nombre Minuscula: {item.nombreMinuscula}");
            }
            return strings;
        }

        // 7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.

        public List<string> ObtenerJoinOrders() 
        {
            List<string> listaJ = new List<string>();
            var query = from c
                        in _northwindcontext.Customers
                        join o
                        in _northwindcontext.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region == "WA"
                        && o.OrderDate > new DateTime(1997, 01, 01)
                        select new
                        {
                           customerID = c.CustomerID,
                           region =  c.Region,
                           orderID = o.OrderID,
                           orderDate = o.OrderDate
                        };

            foreach (var o in query.ToList() ) 
            { 
                listaJ.Add($"Customers: {o.customerID} Order ID: {o.orderID} Fecha de order: {o.orderDate}" );
            }

            return listaJ;
        }

        // 8. Query para devolver los primeros 3 Customers de la  Región WA

        public List<Customers> ObtenerTresPrimerosCustomersDeWA() 
        {
            return _northwindcontext.Customers.Where(c => c.Region == "WA").Take(3).ToList();
        }


        //TODO: 13.Query para devolver los customer con la cantidad de ordenes asociadas

        public List<string> CantidadDeOrdenesAsociadas()
        {
            List<string> lista = new List<string>();
            var customers = _northwindcontext.Customers.Select(c => new
            {
                nombreCustomers = c.ContactName,
                orders = c.Orders

            }).ToList();
            string cantidadDeOrdenesAsociadas = "";
            foreach ( var c in customers )
            {
                cantidadDeOrdenesAsociadas = $"Customer: {c.nombreCustomers} --- Cantidad de ordenes: {c.orders.Count()}";
                lista.Add(cantidadDeOrdenesAsociadas);

            }
            return lista;

        }
    }
}
