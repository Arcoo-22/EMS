using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSection_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblNumber.Text = "✓ Number";
                lblNumber.ForeColor = Color.Green;
            }
            else
            {
                lblNumber.Text = "❌ Number";
                lblNumber.ForeColor = Color.Red;
            }
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }


        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Match()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✓ Match";
                lblMatch.ForeColor = Color.Green;
            }
            else
            {
                lblMatch.Text = "❌ Match";
                lblMatch.ForeColor = Color.Red;
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(cbSection.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Information Incomplete, Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "Insert into [tblUsers] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                    CRUD.CRUD.CUD(query);
                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [tblUsers] ");
                }
            }
        }
        public bool ShowOnlyRegistration { get; set; } = false;
        private void frmSettings_Load(object sender, EventArgs e)
        {
            CRUD.CRUD.RETRIEVECBO(cbSection, "SELECT [ID], [Section] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [tblUsers]");

            lblNumber.Text = "❌ Number";
            lblNumber.ForeColor = Color.Red;

            lblMatch.Text = "✓ Green";
            lblMatch.ForeColor = Color.Green;

            if (ShowOnlyRegistration)
            {
                this.Text = "User Registration";
                dgvUsers.Visible = false;
                btnDownload.Visible = false;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.ControlBox = true;
                this.Size = new Size(290, 700);

                btnBackToLogin.Visible = true;
            }
            else
            {
                btnBackToLogin.Visible = false;
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string TemplatePath = @"C:\Users\User0\Downloads\Employee_Details_Template.xlsx";
            string SavePath = @"C:\Users\User0\Downloads\Employee_Details_Template.xlsx";

            ExportCellFromDgv.ExportFromTemplate(TemplatePath,
        SavePath,
        "B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
        "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
        "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
        "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
        "A32", frmLoginForm.fullname,
        "A33", DateTime.Now.ToString("yyyy-MM-dd")
    );
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ExportDgv.ExportToExcel(dgvUsers, "ExportedData_" + DateTime.Now.ToString("MM-dd-yyyy"));
        }

        private void lblMatch_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmLoginForm loginForm = new frmLoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
