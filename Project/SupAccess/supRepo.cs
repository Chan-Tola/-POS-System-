using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project.SupAccess
{
    internal class supRepo
    {
        private SqlConnection conn;

        public supRepo (SqlConnection connection)
        {
            conn = connection;
        }
        public void insertSup(supplier sp)
        {
            SqlCommand com = new SqlCommand("spInsertSupplier", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Supplier", sp.Name);
            com.Parameters.AddWithValue("@SupAdd", sp.Address);
            com.Parameters.AddWithValue("@SupCon", sp.Contacts);    

            com.ExecuteNonQuery();
        }
        public void editSup(supplier sp)
        {
            SqlCommand com = new SqlCommand("spEditSupplier", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@supID", sp.Id);
            com.Parameters.AddWithValue("@Supplier", sp.Name);
            com.Parameters.AddWithValue("@SupAdd", sp.Address);
            com.Parameters.AddWithValue("@SupCon", sp.Contacts);
            com.ExecuteNonQuery();
        }

        

    }
}
