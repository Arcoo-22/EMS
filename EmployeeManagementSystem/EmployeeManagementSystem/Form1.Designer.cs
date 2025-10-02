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
            panel1 = new Panel();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            label1 = new Label();
            btnMinimize = new Button();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            btnMaximize = new Button();
            pnlStage = new Panel();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(btnAddEmp);
            panel1.Controls.Add(btnMasterData);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 447);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BackColor = SystemColors.GradientInactiveCaption;
            btnAddEmp.Dock = DockStyle.Top;
            btnAddEmp.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.Location = new Point(0, 42);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(224, 42);
            btnAddEmp.TabIndex = 1;
            btnAddEmp.Text = "👩🏻‍💼     Add Employee";
            btnAddEmp.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.BackColor = SystemColors.GradientInactiveCaption;
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(224, 42);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "👨🏻‍💻     Master Data";
            btnMasterData.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.LightPink;
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 50);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 10);
            label1.Name = "label1";
            label1.Size = new Size(290, 30);
            label1.TabIndex = 4;
            label1.Text = "Employee Management System";
            label1.Click += label1_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(713, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(31, 25);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "➖";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(786, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 25);
            btnClose.TabIndex = 2;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Location = new Point(750, 10);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(31, 25);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = SystemColors.Info;
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Location = new Point(224, 50);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(604, 447);
            pnlStage.TabIndex = 2;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(828, 497);
            Controls.Add(pnlStage);
            Controls.Add(panel1);
            Controls.Add(pnlTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMotherForm";
            Text = "Form1";
            Load += frmMotherForm_Load;
            panel1.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnMasterData;
        private Button btnAddEmp;
        private Panel pnlStage;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private Label label1;
    }
}
