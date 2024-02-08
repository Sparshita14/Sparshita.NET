using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ConnectDBSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=EPINHYDW0BEE\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True;";
            cn.Open();
           Console.WriteLine("Successfully Connected with SQL Server");
            cn.Close();


        }
    }
}
