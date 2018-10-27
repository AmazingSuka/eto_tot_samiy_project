using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    abstract class Table
    {
        protected internal string Name { get; set; }
        protected string[] Arguements { get; set; }
    }
}
