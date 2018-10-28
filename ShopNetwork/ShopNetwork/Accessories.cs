using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Accessories:ITableAdapter
    {
        public int InsertParams => 4;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Acessories WHERE acessoryID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Acessories " +
            "SET name = @param1, price = @param2, inventory = @param3, inventory = @param4 " +
            "WHERE acessoryID = @param5", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Acessories " +
            "VALUES(@param1, @param2, @param3, @param4)", sqlConnection);
    }
}
