using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDwindows
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var insertForm = new Insert();
            insertForm.Show(this);
            
            
            
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            var deleteForm = new Delete();
            deleteForm.Show(this);
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var updateForm = new Update();
            updateForm.Show(this);
            
        }

        private void Display_onclick(object sender, EventArgs e)
        {
            var displayForm = new Display();
            displayForm.Show(this);
            
        }
    }
}
