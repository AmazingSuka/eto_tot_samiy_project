using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopNetwork
{
    class Tent:ITableAdapter
    {

        public int InsertParams => 5;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Tent WHERE tentID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Tent " +
                "SET model = @param1, tentType = @param2, " +
            "numbersOfSeats = @param3, color = @param4, basePrice = @param5 " +
            "WHERE tentID = @param6", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Tent " +
                "VALUES(@param1, @param2, @param3, @param4, @param5)", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT t.model," +
            "t.tentType, t.numberOfSeats, t.color, t.basePrice, FROM Tent as t WHERE t.id = @param1", sqlConnection);
        
    }
}
