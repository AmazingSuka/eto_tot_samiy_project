using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Order:ITableAdapter
    {
        public int InsertParams => 2;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Orders WHERE orderID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Orders SET date = @param1, " +
            "salesPersonID = (SELECT m.id FROM Manager WHERE m.name @param2) " +
            "customerID = @param3 " +
            "WHERE orderID = @param4", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Orders VALUES(@param1, " +
            "(SELECT m.id FROM Manager WHERE m.name @param2))", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT o.date, m.name FROM Orders as o " +
                                                                                "JOIN Manager as m ON m.id = o.salesPersonID " +
                                                                                "WHERE o.id = @param1", sqlConnection);
    }
}
