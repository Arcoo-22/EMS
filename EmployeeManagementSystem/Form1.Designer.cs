namespace EmployeeManagementSystem
{
    partial class frmMotherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotherForm));
            pnlSideBar = new Panel();
            lblsection1 = new Label();
            lblAge = new Label();
            lblUsername = new Label();
            btnSettings = new Button();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            lblSection = new Label();
            btnMinimize = new Button();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            btnMaximize = new Button();
            pnlStage = new Panel();
            bindingSource1 = new BindingSource(components);
            pnlSideBar.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.LightPink;
            pnlSideBar.Controls.Add(lblsection1);
            pnlSideBar.Controls.Add(lblAge);
            pnlSideBar.Controls.Add(lblUsername);
            pnlSideBar.Controls.Add(btnSettings);
            pnlSideBar.Controls.Add(btnAddEmp);
            pnlSideBar.Controls.Add(btnMasterData);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 67);
            pnlSideBar.Margin = new Padding(3, 4, 3, 4);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(256, 596);
            pnlSideBar.TabIndex = 0;
            pnlSideBar.Paint += panel1_Paint;
            // 
            // lblsection1
            // 
            lblsection1.AutoSize = true;
            lblsection1.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsection1.Location = new Point(28, 76);
            lblsection1.Name = "lblsection1";
            lblsection1.Size = new Size(117, 29);
            lblsection1.TabIndex = 6;
            lblsection1.Text = "<SECTION>";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(28, 120);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(74, 29);
            lblAge.TabIndex = 5;
            lblAge.Text = "<AGE>";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(28, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(159, 33);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "<USERNAME>";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = SystemColors.GradientInactiveCaption;
            btnSettings.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(0, 281);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(256, 56);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "⛯      Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BackColor = SystemColors.GradientInactiveCaption;
            btnAddEmp.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.Location = new Point(0, 225);
            btnAddEmp.Margin = new Padding(3, 4, 3, 4);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(256, 56);
            btnAddEmp.TabIndex = 1;
            btnAddEmp.Text = "👩🏻‍💼     Add Employee";
            btnAddEmp.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.BackColor = SystemColors.GradientInactiveCaption;
            btnMasterData.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.Location = new Point(0, 169);
            btnMasterData.Margin = new Padding(3, 4, 3, 4);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(256, 56);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "👨🏻‍💻     Master Data";
            btnMasterData.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.LightPink;
            pnlTitleBar.Controls.Add(lblSection);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(3, 4, 3, 4);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(946, 67);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(69, 13);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(369, 39);
            lblSection.TabIndex = 4;
            lblSection.Text = "Employee Management System";
            lblSection.Click += label1_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(815, 13);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 33);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "➖";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(14, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(898, 13);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 33);
            btnClose.TabIndex = 2;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Location = new Point(857, 13);
            btnMaximize.Margin = new Padding(3, 4, 3, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 33);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = SystemColors.Info;
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Location = new Point(256, 67);
            pnlStage.Margin = new Padding(3, 4, 3, 4);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(690, 596);
            pnlStage.TabIndex = 2;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(946, 663);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMotherForm";
            Text = "Form1";
            Load += frmMotherForm_Load;
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnMasterData;
        private Button btnAddEmp;
        private Panel pnlStage;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private Label lblSection;
        private Button btnSettings;
        private Label lblsection1;
        private Label lblAge;
        private Label lblUsername;
    }
}
