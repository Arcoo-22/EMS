using EmployeeManagementSystem.CRUD;
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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public static string fullname, Section, Age;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter Username and Password.", "LOGIN",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Query to validate login and fetch details
            string sql = $"SELECT [FullName], [Section], [Age] FROM tblUsers WHERE Username='{username}' AND [Password]='{password}'";
            bool isLogin = CRUD.CRUD.RETRIEVESINGLE(sql);


            if (isLogin)
            {
                // Retrieve values from CRUD.dt since RETRIEVESINGLE fills it
                fullname = CRUD.CRUD.dt.Rows[0]["FullName"].ToString();
                Section = CRUD.CRUD.dt.Rows[0]["Section"].ToString();
                Age = CRUD.CRUD.dt.Rows[0]["Age"].ToString();

                MessageBox.Show(
                    $"Welcome {fullname}",
                    "LOGIN SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Example: pass to Form1
                this.Hide();
                frmMotherForm main = new frmMotherForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linklblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSettings settingsForm = new frmSettings();
            settingsForm.ShowOnlyRegistration = true; 
            settingsForm.Show();
            this.Hide();
        }
    }
}
