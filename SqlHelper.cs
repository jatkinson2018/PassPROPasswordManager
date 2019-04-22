using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace PasswordManager2019
{
    public class SqlHelper
    {
        SqlConnection con;
        public SqlHelper(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();

                return true;

            }
        }
    }
}
