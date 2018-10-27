using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Contract
    {
        new readonly string Name = "Contract";
        new readonly string[] Arguements = new string[] { "contractID", "date", "depositPayed", "orderID", "contractTotalPrice"};
    }
}
