namespace EmployeeManagementSystem
{
    partial class frmSettings
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
            tabControl1 = new TabControl();
            tpageUserRegistration = new TabPage();
            dgvUsers = new DataGridView();
            pnlSideBar = new Panel();
            btnDownload = new Button();
            btnExecute = new Button();
            lblNumber = new Label();
            lblMatch = new Label();
            txtConfirmPassword = new TextBox();
            lblConPass = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            cbSection = new ComboBox();
            lblSection = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            tpageSectionRegistration = new TabPage();
            tabControl1.SuspendLayout();
            tpageUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tpageUserRegistration);
            tabControl1.Controls.Add(tpageSectionRegistration);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1342, 726);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tpageUserRegistration
            // 
            tpageUserRegistration.Controls.Add(dgvUsers);
            tpageUserRegistration.Controls.Add(pnlSideBar);
            tpageUserRegistration.Location = new Point(4, 29);
            tpageUserRegistration.Name = "tpageUserRegistration";
            tpageUserRegistration.Padding = new Padding(3);
            tpageUserRegistration.Size = new Size(1334, 693);
            tpageUserRegistration.TabIndex = 0;
            tpageUserRegistration.Text = "User Registration";
            tpageUserRegistration.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(292, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1039, 687);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(btnDownload);
            pnlSideBar.Controls.Add(btnExecute);
            pnlSideBar.Controls.Add(lblNumber);
            pnlSideBar.Controls.Add(lblMatch);
            pnlSideBar.Controls.Add(txtConfirmPassword);
            pnlSideBar.Controls.Add(lblConPass);
            pnlSideBar.Controls.Add(txtPassword);
            pnlSideBar.Controls.Add(lblPassword);
            pnlSideBar.Controls.Add(txtAge);
            pnlSideBar.Controls.Add(lblAge);
            pnlSideBar.Controls.Add(cbSection);
            pnlSideBar.Controls.Add(lblSection);
            pnlSideBar.Controls.Add(txtFullName);
            pnlSideBar.Controls.Add(lblFullName);
            pnlSideBar.Controls.Add(txtUserName);
            pnlSideBar.Controls.Add(lblUserName);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(3, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(289, 687);
            pnlSideBar.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(175, 524);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 29);
            btnDownload.TabIndex = 15;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(175, 564);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(94, 29);
            btnExecute.TabIndex = 14;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(39, 499);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(74, 21);
            lblNumber.TabIndex = 13;
            lblNumber.Text = "✓ Number";
            lblNumber.Click += lblNumber_Click;
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatch.Location = new Point(39, 478);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(63, 21);
            lblMatch.TabIndex = 12;
            lblMatch.Text = "✓ Match";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(15, 448);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(242, 27);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // lblConPass
            // 
            lblConPass.AutoSize = true;
            lblConPass.Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConPass.Location = new Point(15, 414);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(153, 21);
            lblConPass.TabIndex = 10;
            lblConPass.Text = "Password Confirmation";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(15, 384);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 27);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged_1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(15, 349);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(15, 319);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(242, 27);
            txtAge.TabIndex = 7;
            txtAge.TextChanged += textBox1_TextChanged;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(15, 284);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 21);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age";
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(15, 253);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(239, 28);
            cbSection.TabIndex = 5;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Sitka Display", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(15, 215);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(58, 24);
            lblSection.TabIndex = 4;
            lblSection.Text = "Section";
            lblSection.Click += lblSection_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 185);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(242, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Sitka Display", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(15, 148);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(78, 24);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 118);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(242, 27);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUsername_TextChanged;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Sitka Display", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(12, 80);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 24);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName";
            lblUserName.Click += lblUsername_Click;
            // 
            // tpageSectionRegistration
            // 
            tpageSectionRegistration.Location = new Point(4, 29);
            tpageSectionRegistration.Name = "tpageSectionRegistration";
            tpageSectionRegistration.Padding = new Padding(3);
            tpageSectionRegistration.Size = new Size(1334, 693);
            tpageSectionRegistration.TabIndex = 1;
            tpageSectionRegistration.Text = "Section Registration";
            tpageSectionRegistration.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 726);
            Controls.Add(tabControl1);
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            tabControl1.ResumeLayout(false);
            tpageUserRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpageUserRegistration;
        private DataGridView dgvUsers;
        private Panel pnlSideBar;
        private TabPage tpageSectionRegistration;
        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblSection;
        private Label lblAge;
        private ComboBox cbSection;
        private TextBox txtAge;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnExecute;
        private Label lblNumber;
        private Label lblMatch;
        private TextBox txtConfirmPassword;
        private Label lblConPass;
        private Button btnDownload;
    }
}