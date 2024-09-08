using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace net_tutorial_making_sql_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6N5TH8D\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True ");
            SqlDataAdapter ad = new SqlDataAdapter("Select * from Emp",conn);
            DataSet ds = new DataSet();
            ad.Fill(ds,"Emp");
            foreach(DataRow dr in ds.Tables["Emp"].Rows)
            {
                Console.WriteLine("" + dr["empno"]);
                Console.WriteLine("" + dr["nam"]);
                Console.WriteLine("" + dr["desig"]);
            }
        }
    }
}
