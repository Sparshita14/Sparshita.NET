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
    public partial class Update : Form
    {
        private int empid;
        private string epmname;
        private string department;
        private string designation;
        private string joiningdate;
        public Update()
        {
            InitializeComponent();
        }


        private void OnEmpIdChange(object sender, EventArgs e)
        {
            dynamic id=EmpId.Text.Trim();
            this.empid = int.Parse(id);
        }

        private void onDesignationChange(object sender, EventArgs e)
        {
            this.designation = Designation.Text.Trim();
        }

        private void OnDepartmentChange(object sender, EventArgs e)
        {
            this.department = Department.Text.Trim();
        }

        private void OnEmpNameChange(object sender, EventArgs e)
        {
            this.epmname= EmpName.Text.Trim();
        }

        private void OnJoiningDateChange(object sender, EventArgs e)
        {
            this.joiningdate= JoiningDate.Text.Trim();
        }

        private void OnSubmitUpdate(object sender, EventArgs e)
        {
            EmployeeOperations employeeOperations = new EmployeeOperations();
            employeeOperations.CreateConnection();
            int id=employeeOperations.UpdateTable(empid, epmname,department,designation,joiningdate);
            if (id >0)
            {
                MessageBox.Show("Updated Successfully id= " + id);
            }
            else
            {
                EmpId.Text = "";
                EmpName.Text = "";
                Department.Text = "";
                Designation.Text = "";
                JoiningDate.Text = "";
                MessageBox.Show("Update Failed");
            }
            employeeOperations.CloseConnection();
            Close();
        }
    }
}
