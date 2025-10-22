namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pnlTitleBar = new Panel();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnInsertUpdate = new Button();
            btnSearch = new Button();
            txtEmailAddress = new TextBox();
            txtRequestorName = new TextBox();
            txtLocalNumber = new TextBox();
            txtEmpID = new TextBox();
            cmbSection = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlTitleBar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(201, 35);
            label1.TabIndex = 0;
            label1.Text = "👩🏻‍💼 Add Employee";
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.LightPink;
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(3, 4, 3, 4);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(914, 67);
            pnlTitleBar.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 79);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(697, 393);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(349, 255);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 43);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click_1;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.Location = new Point(170, 255);
            btnInsertUpdate.Margin = new Padding(3, 4, 3, 4);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(171, 43);
            btnInsertUpdate.TabIndex = 12;
            btnInsertUpdate.Text = "INSERT / UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = true;
            btnInsertUpdate.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(408, 39);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(166, 123);
            txtEmailAddress.Margin = new Padding(3, 4, 3, 4);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(330, 26);
            txtEmailAddress.TabIndex = 10;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(166, 77);
            txtRequestorName.Margin = new Padding(3, 4, 3, 4);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(330, 26);
            txtRequestorName.TabIndex = 8;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(166, 165);
            txtLocalNumber.Margin = new Padding(3, 4, 3, 4);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(223, 26);
            txtLocalNumber.TabIndex = 7;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(166, 39);
            txtEmpID.Margin = new Padding(3, 4, 3, 4);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(223, 26);
            txtEmpID.TabIndex = 6;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(166, 204);
            cmbSection.Margin = new Padding(3, 4, 3, 4);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(223, 29);
            cmbSection.TabIndex = 5;
            cmbSection.DropDown += cmbSection_DropDown;
            cmbSection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 208);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 4;
            label6.Text = "Section:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 161);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 3;
            label5.Text = "Local Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 123);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 2;
            label4.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 77);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 1;
            label3.Text = "Requestor Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 39);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 0;
            label2.Text = "Employee Number:";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitleBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel pnlTitleBar;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        private TextBox txtLocalNumber;
        private TextBox txtEmpID;
        private ComboBox cmbSection;
        private Button btnSearch;
        private Button btnInsertUpdate;
        private Button btnDelete;
    }
}