using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeCRUD;

namespace CRUDwindows
{
    public partial class Insert : Form
    {
        private string name;
        private string department;
        private string designation;
        private string joingDate;
        public Insert()
        {
            InitializeComponent();
        }


        private void Insert_Load(object sender, EventArgs e)
        {
        }

        private void InsertSubmit(object sender, EventArgs e)
        {

            EmployeeOperations employeeOperations = new EmployeeOperations();
            employeeOperations.CreateConnection();
            int id = employeeOperations.InsertValues(this.name, this.department, this.designation, this.joingDate);
            if (id > 1)
            {
                MessageBox.Show("Employee Insert! Employee Id= " + id);
            }
            else
            {
                Empname.Text = "";
                Department.Text = "";
                Designation.Text = "";
                DateJoing.Text = "";
                MessageBox.Show("Insertion Failed");
                

            }
            employeeOperations.CloseConnection();
            Close();
           
        }

        private void OnEmployeeName(object sender, EventArgs e)
        {
            this.name = Empname.Text.Trim();

        }

        private void OnDepartment(object sender, EventArgs e)
        {
            this.department= Department.Text.Trim();
        }

        private void OnDesignation(object sender, EventArgs e)
        {
            this.designation = Designation.Text.Trim();
        }

        private void DateJoining(object sender, EventArgs e)
        {
            this.joingDate = DateJoing.Text.Trim();
        }
    }
}
