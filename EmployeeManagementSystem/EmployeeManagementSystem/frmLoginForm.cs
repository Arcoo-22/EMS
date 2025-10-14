using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMotherForm DisplayMotherForm = new frmMotherForm();
            DisplayMotherForm.Show();
        }
    }
}
