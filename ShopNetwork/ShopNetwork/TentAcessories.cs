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
                "SET acessoryID = @param1, boatID = @param2 " +
                "WHERE fitID = @param3", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO TentAcessories VALUES(@param1, @param2)", sqlConnection);
    }
}
