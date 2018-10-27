using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Partner : Table
    {
        new readonly string Name = "Partner";
        new readonly string[] Arguements = new string[] { "partnerID", "name", "adress", "city" };

    }
}
