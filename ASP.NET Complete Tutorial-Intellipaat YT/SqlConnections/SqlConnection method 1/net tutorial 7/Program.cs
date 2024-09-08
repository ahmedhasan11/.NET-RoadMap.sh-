using System;
using System.Collections.Generic;



//notice that we added the  using System.Data.SqlClient ,,,,,,, and System.Data
using System.Data.SqlClient;
using System.Data;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_tutorial_7
{
    internal class Program
    { 
        //how to make the console related with the database , retrieve data from the database
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6N5TH8D\\SQLEXPRESS;Initial Catalog=ahmed;Integrated Security=True") ;
            SqlDataAdapter ad = new SqlDataAdapter("Select * FROM mahmoud" , conn);
            DataSet ds = new DataSet() ;
            ad.Fill(ds , "mahmoud");

            foreach (DataRow dr in ds.Tables["mahmoud"].Rows) //ds.Tables["table name"].Rows
            {
                Console.WriteLine("" + dr["empno"] ); //dr["column name"]
            }
        }
    }
}
