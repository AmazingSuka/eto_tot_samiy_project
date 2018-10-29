using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Contract:ITableAdapter
    {
        public int InsertParams => 4;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Contract WHERE contractID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Contract " +
                "SET date = @param1, depositPayed = @param2, orderID = @param3, contractTotalPrice = @param4 " +
                "WHERE contractID = @param5", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Contract VALUES(@param1, @param2, @param3, @param4)", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT date, depositPayed, order_id, contractTotalPrice FROM Contract " +
            "WHERE id = @param1", sqlConnection);
        
    }
}
