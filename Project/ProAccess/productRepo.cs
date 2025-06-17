using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ProAccess
{
    public class productRepo
    {
        private SqlConnection conn;
        public productRepo(SqlConnection connection)
        {
            conn = connection;
        }

        public void insertPro(products pro)
        {
            SqlCommand com = new SqlCommand("spInsertPro", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProName", pro.ProName);

            com.ExecuteNonQuery();  
        }
        public void editPro(products pro)
        {
            SqlCommand com = new SqlCommand("spEditPro", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", pro.Id);
            com.Parameters.AddWithValue("@Name", pro.ProName);

            com.ExecuteNonQuery();
        }

    
    }
}
