using EmployeeCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeCRUD;
using System.Windows.Forms;

namespace CRUDwindows
{
    public partial class Delete : Form
    {
        private int empid;
        public Delete()
        {
            InitializeComponent();
        }

        private void onDeleteId(object sender, EventArgs e)
        {
            this.empid = int.Parse(IdDelete.Text.Trim());
        }

        private void Delete_Load(object sender, EventArgs e)
        {
           
        }

        private void DeleteId(object sender, EventArgs e)
        {
            EmployeeOperations employeeOperations = new EmployeeOperations();
            employeeOperations.CreateConnection();
            int id = employeeOperations.DeleteValues(this.empid);
            if (id > 0)
            {
                MessageBox.Show("Employee Deleted!");
            }
            else
            {
                IdDelete.Text = "";
                MessageBox.Show("Deletion Failed");


            }
            Close();
            employeeOperations.CloseConnection();
            
        }
    }
}
