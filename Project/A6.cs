using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class A6
    {
        public SqlConnection conn;
        string str = "Data Source=.; Initial Catalog= A6Y2025; Integrated security = true";
        public void Connection()
        {
            SqlDependency.Stop(str);
            SqlDependency.Start(str);
            conn = new SqlConnection(str);
            conn.Open();
        }
    }
}
