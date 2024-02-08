using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp
{
    public class ConsoleConnection
    {
        public  SqlConnection cn;
        public  void CreateConnection()
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

        public void InsertValues()
        {
            Console.WriteLine("Enter the following values for insertion");
            Console.Write("Employee Name- ");
            String empName = Console.ReadLine();
            Console.Write("Department of Employee- ");
            String department = Console.ReadLine();
            Console.Write("Designation of Employee- ");
            String designation = Console.ReadLine();
            Console.WriteLine("Date of Joining");
            String joingDate = (String)Console.ReadLine();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Employee(EmpName,Department,Designation,JoiningDate) VALUES('" + empName + "','" + department + "','" + designation + "','" + joingDate + "')";
            cmd.Connection = cn;
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("Employee details inserted successfully");
            }
            else Console.WriteLine("Employee details insertion failed");

        }
        public  void UpdateTable()
        {
            Console.WriteLine("Enter the following for Updation");
            Console.Write("Enter EmployeeId that needs to be updated ");
            int id=int.Parse(Console.ReadLine());
            string[] cols = { "EmpName", "Department", "Designation", "JoiningDate" };
            foreach(string col in cols)
            {
                Console.WriteLine("Updating {0}?", col);
                string ans=Console.ReadLine();
                if(ans=="yes"|| ans == "y")
                {
                    Console.WriteLine("Enter value for updating {0}", col);
                    string val=Console.ReadLine();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE Employee SET "+col+"='"+val+"' WHERE EmpId ='"+id+"'";
                    cmd.Connection = cn;
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        Console.WriteLine("Employee details updated successfully");
                    }
                    else Console.WriteLine("Employee details updation failed");

                }
            }


        }

        public void DeleteValues()
        {
            Console.WriteLine("Enter the following for Deletion");
            Console.Write("Enter EmployeeId that needs to be deleted ");
            int id = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Employee WHERE EmpId ='" + id + "'";
            cmd.Connection = cn;
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("Employee deleted successfully");
            }
            else Console.WriteLine("Employee deletion failed");
        }

        public  void DisplayTable()
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
            Console.WriteLine("EmpId -- EmpName -- Department -- Designation -- JoiningDate");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow;
                drow = dt.Rows[i];
               Console.WriteLine(drow["EmpId"] + " -- " + drow["EmpName"] + " -- "+ drow["Department"] + " -- " + drow["Designation"]+" -- "+ drow["JoiningDate"]);
            }


        }
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {

            ConsoleConnection con= new ConsoleConnection();
            con.CreateConnection();
            bool cnt = true;
            while (cnt)
            {
                Console.WriteLine("Select Option");
                Console.WriteLine("1. Display Employee Table (DataReader)");
                Console.WriteLine("2. Insert into Employee Table");
                Console.WriteLine("3. Update into Employee Table");
                Console.WriteLine("5. Delete from Employee Table");
                Console.WriteLine("6. Display Employee Table (DataSet)");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        con.DisplayTable();
                        break;
                    case 2:
                        con.InsertValues();
                        break;
                    case 3:
                        con.UpdateTable();
                        break;
                    case 5:
                        con.DeleteValues();
                        break;
                    case 6:
                        con.DisplayTable2();
                        break;
                    default:
                        cnt = false;
                        Console.WriteLine("Closing ");
                        con.CloseConnection();
                        break;
                }
            }
            
        }

    }
}
