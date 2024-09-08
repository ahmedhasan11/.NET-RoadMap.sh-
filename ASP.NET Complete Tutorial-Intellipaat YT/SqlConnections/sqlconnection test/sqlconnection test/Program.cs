using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sqlconnection_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection("integrated security = true;data source = DESKTOP-6N5TH8D\\SQLEXPRESS;initial catalog =Employee");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employ" , conn); //retrieveing data from database
            DataSet ds =new DataSet();
            da.Fill(ds,"Employee"); //storing the data of the database that we retrieved by the dataadapter , we store it in the dataset
            foreach(DataRow dr in ds.Tables["Employ"].Rows)
            {
                Console.WriteLine("" + dr["empno"]);
                Console.WriteLine("" + dr["nam"]);
                Console.WriteLine("" + dr["dept"]);
                Console.WriteLine("" + dr["basics"]);
            }
        }
    }
}
