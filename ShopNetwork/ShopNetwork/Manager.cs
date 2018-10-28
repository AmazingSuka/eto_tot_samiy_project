using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Manager:ITableAdapter
    {
        public int InsertParams => 2;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Manager WHERE salesPersonID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Manager SET firstName = @param1, familyName = @param2 " +
            "WHERE salesPersonID = @param3", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Manager VALUES(@param1, @param2)", sqlConnection);
    }
}
