using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSignup
{
    public class UserCRUD
    {
        public SqlConnection cn;
        public void CreateConnection()
        {
            this.cn = new SqlConnection();
            this.cn.ConnectionString = "data source=EPINHYDW0BEE\\SQLEXPRESS; Initial Catalog= WordVoyager; Integrated Security=True";
            this.cn.Open();
            Console.WriteLine("Successfully Connected with SQL Server");
        }

        public void CloseConnection()
        {
            this.cn.Close();
            Console.WriteLine("Connection Closed");
        }

        public int InsertValues(string empName, string department, string designation, string joingDate)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Employee(EmpName,Department,Designation,JoiningDate) VALUES('" + empName + "','" + department + "','" + designation + "','" + joingDate + "');" + "SELECT SCOPE_IDENTITY()";
            cmd.Connection = cn;
            try
            {
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch
            {
                return -1;
            }

        }
    }
}
