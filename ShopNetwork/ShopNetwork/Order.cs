using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Order
    {
        new readonly string Name = "Order";
        new readonly string[] Arguements = new string[] { "orderID", "date", "salesPersonID",
            "customerID", "boatID", "deliveryAdress", "city"};
    }
}
