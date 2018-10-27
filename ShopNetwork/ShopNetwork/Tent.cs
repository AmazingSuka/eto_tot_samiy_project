using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Tent:Table
    {
        new readonly string Name = "Tent";
        new readonly string[] Arguements = new string[] { "tentID", "model", "tentType", "numberOfSeats", "color", "basePrice" };
    }
}
