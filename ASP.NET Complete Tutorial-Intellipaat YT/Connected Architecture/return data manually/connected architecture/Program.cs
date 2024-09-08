using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace connected_architecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6N5TH8D\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmpShow" , conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr =cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("" + dr["empno"]);
                Console.WriteLine("" + dr["empno"]);
                Console.WriteLine("" + dr["empno"]);
            }
        }
    }
}
