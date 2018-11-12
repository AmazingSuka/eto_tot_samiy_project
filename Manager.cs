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
        public int InsertParams => 1;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Manager WHERE salesPersonID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Manager SET name = @param1 WHERE salesPersonID = @param2", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Manager VALUES(@param1)", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT name FROM Manager", sqlConnection);
        
    }
}
