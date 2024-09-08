using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace connected_arch_2
{
    //enter empno and return all data of the employee
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            Console.WriteLine("enter empno");
            empno = int.Parse(Console.ReadLine());
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6N5TH8D\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmpSearch", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno",empno);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("" + dr["desig"]);
                Console.WriteLine("" + dr["nam"]);
            }
            Console.ReadKey();


        }
    }
}
