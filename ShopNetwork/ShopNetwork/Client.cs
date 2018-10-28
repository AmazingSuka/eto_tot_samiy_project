using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNetwork
{
    class Client:ITableAdapter
    {
        public int InsertParams => 10;

        public SqlCommand Delete(SqlConnection sqlConnection) => new SqlCommand("DELETE FROM Client WHERE customerID = @param1", sqlConnection);

        public SqlCommand Edit(SqlConnection sqlConnection) => new SqlCommand("UPDATE Client " +
            "SET firstName = @param1, familyName = @param2, dateOfBirth = @param3, " +
            "organisationName = @param4, adress = @param5, city = @param6, email = @param7 " +
            "phone = @param8, IDNumber = @param9, IDDocumentName = @param10 WHERE customerID = @param11", sqlConnection);


        public SqlCommand Insert(SqlConnection sqlConnection) => new SqlCommand("INSERT INTO Client VALUES(@param1, @param2, @param3, " +
            "@param4, @param5, @param6, @param7, @param8, @param9, @param10)", sqlConnection);

        public SqlCommand Select(SqlConnection sqlConnection) => new SqlCommand("SELECT firstName, familyName, dateofBitrh, " +
            "organisationName, adress, city, email, phone, IDNumber, IDDocumentName WHERE id = @param1", sqlConnection);
        
    }
}
