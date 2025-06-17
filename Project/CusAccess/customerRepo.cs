using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project.CusAccess
{
    
    public class customerRepo
    {
        private SqlConnection conn;
        public  customerRepo (SqlConnection connection)
        {
            conn = connection;
        }

        public void insertCustomer(customer cus)
        {
            SqlCommand com = new SqlCommand("spInsertCustomer", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cusName", cus.FullName);
            com.Parameters.AddWithValue("@cusPhone", cus.Phone);

            com.ExecuteNonQuery();
        }        
        public void editCustomer(customer cus)
        {
            SqlCommand com = new SqlCommand("spUpdateCus", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", cus.Id);
            com.Parameters.AddWithValue("@cname", cus.FullName);
            com.Parameters.AddWithValue("@cphone", cus.Phone);

            com.ExecuteNonQuery();
        }

    }
}
