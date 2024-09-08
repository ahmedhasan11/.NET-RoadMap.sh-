using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace net_tutorial_10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            string desig, nam;
            Console.WriteLine("enter employee num ");
           empno=int.Parse( Console.ReadLine());
            Console.WriteLine("enter desig ");
            desig= Console.ReadLine();
            Console.WriteLine("enter nam ");
            nam=Console.ReadLine();


            string strcon = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
            SqlConnection conn=new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Emp",conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Emp");
            DataRow dr = ds.Tables["Emp"].NewRow();//creates a new row in the table
            dr["empno"] = empno;
            dr["nam"] = nam;
            dr["desig"] = desig;
            ds.Tables["Emp"].Rows.Add(dr);
            da.Update(ds,"Emp");




        }
    }
}
