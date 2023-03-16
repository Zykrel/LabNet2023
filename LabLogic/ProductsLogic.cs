using Lab.EF.Data2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLogic
{
    public class ProductsLogic : LogicaBase
    {
        // 2. Query para devolver todos los productos sin stock
        public List<Products> ObtenerProductosSinStock() 
        {
            var query = from p
                        in _northwindcontext.Products
                        where p.UnitsInStock == 0
                        select p;
            return query.ToList();
        }
        //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
        public List<Products> ObtenerProductosConStock() 
        {
            var query = from p
                        in _northwindcontext.Products
                        where p.UnitsInStock > 0 
                        && p.UnitPrice > 3
                        select p;
            return query.ToList();
        }

        //5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789
        public Products ObtenerPrimerElementoONulo() 
        { 
            return _northwindcontext.Products.FirstOrDefault(p => p.ProductID == 789);

        }

        //9. Query para devolver lista de productos ordenados por nombre

        public List<Products> ListaOrdenadaPorNombre() 
        { 
            return _northwindcontext.Products.OrderBy(p => p.ProductName).ToList();
        }

        // 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.

        public List<Products> ProductosOrdenados() 
        {
            return _northwindcontext.Products.OrderByDescending(p => p.UnitsInStock).ToList();
        }



        //11. Query para devolver las distintas categorías asociadas a los productos

        public 

        //12. Query para devolver el primer elemento de una lista de productos

        public Products ObtenerPrimerElemento() 
        { 
            return _northwindcontext.Products.First();

        }
    }
}
