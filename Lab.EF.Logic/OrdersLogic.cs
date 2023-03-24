using Lab.EF.Entities;
using System;
using System.Linq;

namespace Lab.EF.Logic
{
    public class OrdersLogic : BaseLogic
    {
        // crear order logic para borrar la FK que relaciona los dos tablas.
        public void BorrarOrders(int ordersId)
        {
            try
            {
                Orders order = _northwindcontext.Orders.Find(ordersId);
                _northwindcontext.Orders.Remove(order);
                _northwindcontext.SaveChanges();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public void BorrarOrderDetail(int orderId, int productId) 
        {

            try 
            {
                Order_Details orderDetail = _northwindcontext.Order_Details.FirstOrDefault(od => od.OrderID == orderId && od.ProductID == productId);

                if (orderDetail != null)
                {
                    _northwindcontext.Order_Details.Remove(orderDetail);
                    _northwindcontext.SaveChanges();
                }

            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
           
        
        }
    }
}
