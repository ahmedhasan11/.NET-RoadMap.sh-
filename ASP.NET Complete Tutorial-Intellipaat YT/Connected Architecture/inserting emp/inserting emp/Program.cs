using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace inserting_emp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            string desig, nam;
            Console.WriteLine("empno");
            empno =int.Parse(Console.ReadLine());
            Console.WriteLine("desig");
            desig =Console.ReadLine();
            Console.WriteLine("nam");
            nam =Console.ReadLine();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6N5TH8D\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmpInsert1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno",empno);
            cmd.Parameters.AddWithValue("@desig",desig);
            cmd.Parameters.AddWithValue("@nam",nam);
            cmd.ExecuteNonQuery();
            Console.WriteLine("record added");
            Console.ReadKey();




        }
    }
}
