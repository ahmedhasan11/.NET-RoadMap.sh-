using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace deleting_row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            string name, desig;
            Console.WriteLine("enter empno");
            empno = int.Parse(Console.ReadLine());
            string strcon = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Where empno=@empno", conn);
            da.SelectCommand.Parameters.AddWithValue("@empno", empno);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Emp");
            DataRow dr = ds.Tables["Emp"].Rows[0];
            dr.Delete();
            da.Update(ds, "Emp");
        }
    }
}
