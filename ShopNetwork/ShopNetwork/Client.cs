using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Client
    {
        new readonly string Name = "Client";
        new readonly string[] Arguements = new string[] { "customerID", "firstName", "familyName",
            "dateOfBirth", "organisationName", "adress", "city", "email", "phone", "IDNumber", "IDDocumentName"};
    }
}
