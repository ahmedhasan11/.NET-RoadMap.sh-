using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace net_tut_connection_sql_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strcon = ConfigurationManager.ConnectionStrings["Employeeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter da =new SqlDataAdapter("select * from Emp",conn);
            DataSet ds =new DataSet();
            da.Fill(ds,"Emp");
            foreach(DataRow dr in ds.Tables["Emp"].Rows)
            {
                Console.WriteLine("" + dr["desig"]);
            }
            Console.ReadKey();
        }
    }
}
