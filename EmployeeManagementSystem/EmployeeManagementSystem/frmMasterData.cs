using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }
        public void RefreshDataGrid(string query)
        {
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, query);
        }


        private void lblMasterData_Click(object sender, EventArgs e)
        {

        }

        private void pnlChildTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public static string selectedTransaction, RequestorEmail, RequestorName, EmployeeNumber, Section, LocalNumber, cmbSection;

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void dtgMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            EmployeeNumber = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            RequestorEmail = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            cmbSection = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
        }
        public void Refresh()
        {
            string select_tblrequestorlist = "select * from tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        public static string TextBoxData;
        private void btnEditData_Click(object sender, EventArgs e)
        {
            TextBoxData = dtgMasterData.Text;
            frmAddEmployee DisplayfrmEmployee = new frmAddEmployee();
            DisplayfrmEmployee.FormClosed += (s, args) => Refresh();
            DisplayfrmEmployee.ShowDialog();
            this.Refresh();
        }
    }
}
