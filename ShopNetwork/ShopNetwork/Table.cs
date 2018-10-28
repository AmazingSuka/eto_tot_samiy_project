using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopNetwork
{
    interface ITableAdapter
    {
        int InsertParams { get; }
        SqlCommand Insert(SqlConnection sqlConnection);
        SqlCommand Edit(SqlConnection sqlConnection);
        SqlCommand Delete(SqlConnection sqlConection);
    }
}
