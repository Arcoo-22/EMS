using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using EmployeeManagementSystem.CRUD;

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
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (OleDbConnection conn = new OleDbConnection(connection.connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tblLoginForm WHERE Username = ? AND Password = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("?", Username);
                        cmd.Parameters.AddWithValue("?", Password);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            frmMotherForm DisplayMotherForm = new frmMotherForm();
                            DisplayMotherForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
