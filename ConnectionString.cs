using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management
{
    public static class ConnectionString
    {
        public static SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=CEYHUNKUTAHYALI\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}