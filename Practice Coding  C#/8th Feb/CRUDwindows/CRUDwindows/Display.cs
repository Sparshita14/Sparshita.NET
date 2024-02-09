using EmployeeCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDwindows
{
    public partial class Display : Form
    {
        DataTable dt;
        int RowIndex;
        DataRow drow;
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=EPINHYDW0BEE\\SQLEXPRESS; Initial Catalog= WordVoyager; Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Employee", cn);
            //DataSet impl
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable impl
            DataTable dt;
            dt = ds.Tables[0];
            //presentation / buffer logic
           dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
