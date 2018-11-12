using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Partner : ITableAdapter
    {
        public int InsertParams => 3;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Partner WHERE partnerID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Partner SET name = @param1, adress = @param2, city = @param3 " +
                "WHERE partnerID = @param4", sqlConnection);

        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Partner VALUES(@param1, @param2, @param3)", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT " +
            "p.name, p.adress, p.city FROM Partner as p WHERE p.id = @param1");
        
    }
}
