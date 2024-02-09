using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD
{
    public class EmployeeOperations
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

        public int InsertValues(string empName, string department, string designation,string joingDate)
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

        public int UpdateTable(int empid,string empName, string department, string designation, string joingDate)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Employee SET EmpName='"+empName+ "', Department='"+ department+ "', Designation='"+ designation+"', JoiningDate='"+ joingDate+"' WHERE EmpId='"+empid+"'" ;
            cmd.Connection = cn;
            int n = cmd.ExecuteNonQuery();
            return n;


        }

        public int DeleteValues(int id)
        {
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Employee WHERE EmpId ='" + id + "'";
            cmd.Connection = cn;
          
                int n = cmd.ExecuteNonQuery();
                return n;
           
           
           
        }

        public void DisplayTable()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Employee";
            cmd.Connection = cn;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            /*Console.WriteLine("EmpName\t\tDepartment\t\tDesignation\t\tJoiningDate");
            while (dr.Read() == true)
            {
               Console.WriteLine(dr[0] + "\t\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3]);
            }*/

            Console.WriteLine("| EmployeeId | EmployeeName | Department | Designation | Joining Date ");
            Console.WriteLine(new string('-', 75));
            while (dr.Read())
            {
                Console.WriteLine($"| {dr[0],-10} | {dr[1],-12} | {dr[2],-10} | {dr[3],-11} |{dr[4],-10} ");
            }
            dr.Close();
        }
        public void DisplayTable2()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Employee", cn);
            //DataSet impl
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable impl
            DataTable dt;
            dt = ds.Tables[0];

        }
    }
}