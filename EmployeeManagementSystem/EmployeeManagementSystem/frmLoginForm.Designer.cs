namespace EmployeeManagementSystem
{
    partial class frmLoginForm
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
            lblEMS = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblEMS
            // 
            lblEMS.AutoSize = true;
            lblEMS.Font = new Font("Sitka Display", 52.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEMS.Location = new Point(278, 51);
            lblEMS.Name = "lblEMS";
            lblEMS.Size = new Size(211, 126);
            lblEMS.TabIndex = 0;
            lblEMS.Text = "EMS";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(72, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 39);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(80, 271);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(125, 39);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(230, 201);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(439, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 283);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(439, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Sitka Display", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(575, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblEMS);
            Name = "frmLoginForm";
            Text = "frmLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEMS;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}