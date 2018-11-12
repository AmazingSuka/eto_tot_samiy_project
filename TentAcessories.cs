using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopNetwork
{
    class TentAcessories:ITableAdapter
    {
        public int InsertParams => 2;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM TentAcessories WHERE fitID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE TentAcessories " +
                "SET acessoryID = (SELECT a.id FROM Acessories as a WHERE a.name = @param1), " +
                "boatID = (SELECT t.id FROM Tent as t WHERE t.model = @param2) " +
                "WHERE fitID = @param3", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO TentAcessories " +
            "VALUES((SELECT a.id FROM Acessories as a WHERE a.name = @param1), " +
            "(SELECT t.id FROM Tent as t WHERE t.model = @param2))", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT a.name, t.model FROM TentAcessories as ta " +
                                  "JOIN Acessories as a ON a.id = t.acessoryID " +
                                  "JOIN Tent as t ON t.id = ta.boatID " +
                                  "WHERE ta.id = @param1", sqlConnection);
    }
}
