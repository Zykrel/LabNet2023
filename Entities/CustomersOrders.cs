using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomersOrders
    {
        public string customerID { get; set; }
        public string region { get; set; }
        public int orderID { get; set; }
        public DateTime? orderDate { get; set; }
        public CustomersOrders(string customerID, string region, int orderID, DateTime? orderDate) 
        {
            this.customerID = customerID;
            this.region = region;
            this.orderID = orderID;
            this.orderDate = orderDate;

        }
        
    }
}
