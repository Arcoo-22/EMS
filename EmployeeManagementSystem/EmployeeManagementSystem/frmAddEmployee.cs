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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblEmployeeData] where EmployeeNumber = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
            

            if (string.IsNullOrEmpty(txtEmpID.Text) || string.IsNullOrEmpty(txtRequestorName.Text) || string.IsNullOrEmpty(txtEmailAddress.Text) || string.IsNullOrEmpty(cmbSection.Text) || string.IsNullOrEmpty(txtLocalNumber.Text))
            {
                MessageBox.Show("Information Incomplete, Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmailAddress.Text.Contains("@firstasia.edu.ph") == false)
            {
                MessageBox.Show("Please enter your first asia email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtg_addrequestor == true)
            {

                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists!, Do you want to update the record?", "Information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    string update_requestor = "Update [tblEmployeeData] set [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' where [EmployeeNumber] = '" + txtEmpID.Text + "'";
                    CRUD.CRUD.CUD(update_requestor);
                    MessageBox.Show("Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else 
                {
                    txtEmailAddress.Clear();
                    txtEmpID.Clear();
                    txtLocalNumber.Clear();
                    txtRequestorName.Clear();
                    this.Close();
                }
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }
            else
            {
                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber],[RequestorName],[RequestorEmail],[Section],[LocalNumber]) " +
                    "values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmailAddress.Text = frmMasterData.selectedTransaction;
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmpID.Text = frmMasterData.EmployeeNumber;
            cmbSection.Text = frmMasterData.cmbSection;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this data?", "Delete Data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE * FROM [tblEmployeeData] WHERE ID = '" + frmMasterData.selectedTransaction + "'";
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Data has been deleted.", MessageBoxButtons.OK, MessageBoxIcons.Information);
                this.Close();
            }
        }
    }
}
