namespace EmployeeManagementSystem
{
    partial class frmMasterData
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
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            btnEditData = new Button();
            lblTransactionNo = new Label();
            pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.AccessibleDescription = "";
            pnlChildTitle.AccessibleName = "";
            pnlChildTitle.BackColor = SystemColors.GradientInactiveCaption;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Margin = new Padding(3, 4, 3, 4);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(855, 67);
            pnlChildTitle.TabIndex = 0;
            pnlChildTitle.TabStop = true;
            pnlChildTitle.Paint += pnlChildTitle_Paint;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(14, 12);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(204, 39);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "👨🏻‍💻  Master Data";
            lblMasterData.Click += lblMasterData_Click;
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = SystemColors.Info;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgMasterData.Location = new Point(0, 67);
            dtgMasterData.Margin = new Padding(3, 4, 3, 4);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.RowHeadersWidth = 51;
            dtgMasterData.Size = new Size(855, 363);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellClick += dtgMasterData_CellClick;
            dtgMasterData.CellContentClick += dtgMasterData_CellContentClick;
            dtgMasterData.RowHeaderMouseClick += dtgMasterData_RowHeaderMouseClick;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditData.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditData.Location = new Point(733, 445);
            btnEditData.Margin = new Padding(3, 4, 3, 4);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(104, 47);
            btnEditData.TabIndex = 2;
            btnEditData.Text = "Edit Data";
            btnEditData.UseVisualStyleBackColor = true;
            btnEditData.Click += btnEditData_Click;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionNo.Location = new Point(25, 453);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(252, 29);
            lblTransactionNo.TabIndex = 3;
            lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            lblTransactionNo.Click += lblTransactionNo_Click;
            // 
            // frmMasterData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(855, 497);
            Controls.Add(lblTransactionNo);
            Controls.Add(btnEditData);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMasterData";
            Padding = new Padding(0, 0, 0, 67);
            Text = "frmMasterData";
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChildTitle;
        private Label lblMasterData;
        private DataGridView dtgMasterData;
        private Button btnEditData;
        private Label lblTransactionNo;
    }
}