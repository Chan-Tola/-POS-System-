using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project.staffAccess
{
    public class staffRepository
    {
        private SqlConnection conn;
        //SqlCommand com;

        public staffRepository(SqlConnection connection)
        {
            conn = connection;
        }

        public void InsertStaff(staff staff)
        {
            //values(@id, @fn, @g, @dob, @ps, @sl, @sw, @ph)
            SqlCommand com = new SqlCommand("spInsertstaff", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", staff.Id);
            com.Parameters.AddWithValue("@fn", staff.FullName);
            com.Parameters.AddWithValue("@g", staff.Gender);
            com.Parameters.AddWithValue("@dob", staff.DOB);
            com.Parameters.AddWithValue("@ps", staff.Position);
            com.Parameters.AddWithValue("@sl", staff.Salary);
            com.Parameters.AddWithValue("@sw", staff.stopwork);
            com.Parameters.AddWithValue("@ph", staff.Photo ?? (object)DBNull.Value);

            com.ExecuteNonQuery();

        }
        public void UpdatedStaff(staff staff)
        {
            //values(@id, @fn, @g, @dob, @ps, @sl, @sw, @ph)
            SqlCommand com = new SqlCommand("spUpdatedstaff", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", staff.Id);
            com.Parameters.AddWithValue("@fn", staff.FullName);
            com.Parameters.AddWithValue("@g", staff.Gender);
            com.Parameters.AddWithValue("@dob", staff.DOB);
            com.Parameters.AddWithValue("@ps", staff.Position);
            com.Parameters.AddWithValue("@sl", staff.Salary);
            com.Parameters.AddWithValue("@sw", staff.stopwork);
            com.Parameters.AddWithValue("@ph", staff.Photo ?? (object)DBNull.Value);

            com.ExecuteNonQuery();

        }
    }
}
