using Lab.EF.Entities;
using Lab.EF.Logic;
using System;


namespace LabNet2023
{
    class Program
    {
        static void Main(string[] args)

        {
            string flag = "";
            ShippersLogic shippersLogic = new ShippersLogic();
            do
            {
                Console.WriteLine("Lista de opciones: ");
                Console.WriteLine("1.Mostrar Shippers \n2.Mostrar Categories \n3.Crear Shipper \n4.Modificar Shipper \n5.Eliminar Shipper");
                Console.Write("Escriba el número de la acción a realizar: ");
                string accion = Console.ReadLine();
                switch (accion)
                {
                    case "1": MostrarShippers(shippersLogic);
                                break;
                    case "2": MostrarCategories(); 
                                break;
                    case "3": InsertarShipper(shippersLogic);
                        break;
                    case "4": ModificarShipper(shippersLogic);
                    break;
                    case "5": EliminarShipper(shippersLogic);
                        break;
                    default: Console.WriteLine("Opcion no válida");
                        break;

                }
                Console.WriteLine("Desea Continuar? Escriba NO para terminar: ");
                flag = Console.ReadLine();

            } while (flag.ToUpper() != "NO");

            Console.WriteLine("Fin del programa");
            Console.ReadKey();

        }

        internal static void MostrarShippers(ShippersLogic shippersLogic)
        {

            Console.WriteLine("-Llamado a Shippers y mostrando Id, Company Name: ");

            foreach (Shippers shipper in shippersLogic.ObtenerTodo())
            {
                Console.WriteLine($"{shipper.ShipperID} {shipper.CompanyName}");
            }

        }

        internal static void MostrarCategories()
        {
            Console.WriteLine("\n-Llamado a Categories y mostrando Category Name: ");

            CategoriesLogic categoriesLogic = new CategoriesLogic();

            foreach (Categories categories in categoriesLogic.ObtenerTodo())
            {
                Console.WriteLine($"{categories.CategoryName}");
            }

        }

        internal static void InsertarShipper(ShippersLogic shippersLogic)
        {
            Console.WriteLine("\n-Insert de Shippers");

            Console.WriteLine("Escriba nombre de compania");
            string companyName = Console.ReadLine();
            Console.WriteLine("escriba numero de telefono");
            string phone = Console.ReadLine();

            Shippers shipperData = new Shippers();
            shipperData.CompanyName = companyName;
            shipperData.Phone = phone;
            shippersLogic.InsertarData(shipperData);
        }

        internal static void EliminarShipper(ShippersLogic shippersLogic)
        {
            Console.WriteLine("\nEscriba el id de la compania de transporte que desea eliminar");

            int id = (int.Parse(Console.ReadLine()));
            Shippers companiaAEliminar = shippersLogic.ObtenerShipperPorId(id);
            if (companiaAEliminar != null)
            {
                shippersLogic.Borrar(companiaAEliminar);
            }
            else
            {
                Console.WriteLine("No se encuentra nada para eliminar");
            }
        }

        internal static void ModificarShipper(ShippersLogic shippersLogic)
        {
            Console.WriteLine("\nEscriba el id de la compania de transporte que desea modificar");
            int idUpdate = (int.Parse(Console.ReadLine()));
            Shippers shipperUpdate = shippersLogic.ObtenerShipperPorId(idUpdate);
            if (shipperUpdate != null) 
            {
                Console.WriteLine("Escriba nuevo nombre");
                shipperUpdate.CompanyName = Console.ReadLine();
                Console.WriteLine("Escriba nuevo numero de telefono");
                shipperUpdate.Phone = Console.ReadLine();
                shippersLogic.Modificar(shipperUpdate);
            }
            else
            {
                Console.WriteLine("La compañia no existe");
            }

        }

    }
}
