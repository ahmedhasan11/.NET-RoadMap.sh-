using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_tutorial_sql_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strcon = ConfigurationManager.ConnectionStrings["Employeeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            int empno;
            empno = Convert.ToInt32(Console.ReadLine());
            SqlDataAdapter ad = new SqlDataAdapter("Select * from Where Empno=@empno", conn);
            ad.SelectCommand.Parameters.AddWithValue("@empno", empno);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Emp");
            int count = ds.Tables["Emp"].Rows.Count;
            if (count == 1)
            {

                Console.WriteLine("" + ds.Tables["Emp"].Rows[0]["nam"]);
                Console.WriteLine("" + ds.Tables["Emp"].Rows[0]["desig"]);
            }
        }
    }
}
