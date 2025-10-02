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
            button1 = new Button();
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "👩🏻‍💼 Add Employee";
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.LightPink;
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(800, 50);
            pnlTitleBar.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(button1);
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
            groupBox1.Location = new Point(8, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 295);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details Manual(Insert and Update)";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(305, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 32);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click_1;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.Location = new Point(149, 191);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(150, 32);
            btnInsertUpdate.TabIndex = 12;
            btnInsertUpdate.Text = "INSERT / UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = true;
            btnInsertUpdate.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(357, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(145, 92);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(289, 23);
            txtEmailAddress.TabIndex = 10;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(145, 58);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(289, 23);
            txtRequestorName.TabIndex = 8;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(145, 124);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(196, 23);
            txtLocalNumber.TabIndex = 7;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(145, 29);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(196, 23);
            txtEmpID.TabIndex = 6;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(145, 153);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(196, 26);
            cmbSection.TabIndex = 5;
            cmbSection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 156);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 4;
            label6.Text = "Section:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 121);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 3;
            label5.Text = "Local Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 92);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 2;
            label4.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 58);
            label3.Name = "label3";
            label3.Size = new Size(97, 18);
            label3.TabIndex = 1;
            label3.Text = "Requestor Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 29);
            label2.Name = "label2";
            label2.Size = new Size(107, 18);
            label2.TabIndex = 0;
            label2.Text = "Employee Number:";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitleBar);
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
        private Button button1;
        private Button btnInsertUpdate;
        private Button btnDelete;
    }
}