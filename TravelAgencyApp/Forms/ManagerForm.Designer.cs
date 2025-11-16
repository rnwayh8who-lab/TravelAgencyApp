namespace TravelAgencyApp
{
    partial class ManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewEmployees = new DataGridView();
            txtName = new TextBox();
            txtPosition = new TextBox();
            btnAddEmployee = new Button();
            btnFire = new Button();
            btnSetCashier = new Button();
            btnSetOperator = new Button();
            btnSetShift = new Button();
            lblName = new Label();
            lblPosition = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 12);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 29;
            dataGridViewEmployees.Size = new Size(500, 300);
            dataGridViewEmployees.TabIndex = 0;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(640, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(640, 80);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(180, 23);
            txtPosition.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(620, 130);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(220, 40);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Добавить сотрудника";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnFire
            // 
            btnFire.Location = new Point(620, 190);
            btnFire.Name = "btnFire";
            btnFire.Size = new Size(220, 40);
            btnFire.TabIndex = 4;
            btnFire.Text = "Уволить";
            btnFire.UseVisualStyleBackColor = true;
            btnFire.Click += btnFire_Click;
            // 
            // btnSetCashier
            // 
            btnSetCashier.Location = new Point(620, 240);
            btnSetCashier.Name = "btnSetCashier";
            btnSetCashier.Size = new Size(220, 40);
            btnSetCashier.TabIndex = 5;
            btnSetCashier.Text = "Назначить кассиром";
            btnSetCashier.UseVisualStyleBackColor = true;
            btnSetCashier.Click += btnSetCashier_Click;
            // 
            // btnSetOperator
            // 
            btnSetOperator.Location = new Point(620, 290);
            btnSetOperator.Name = "btnSetOperator";
            btnSetOperator.Size = new Size(220, 40);
            btnSetOperator.TabIndex = 6;
            btnSetOperator.Text = "Назначить оператором";
            btnSetOperator.UseVisualStyleBackColor = true;
            btnSetOperator.Click += btnSetOperator_Click;
            // 
            // btnSetShift
            // 
            btnSetShift.Location = new Point(620, 340);
            btnSetShift.Name = "btnSetShift";
            btnSetShift.Size = new Size(220, 40);
            btnSetShift.TabIndex = 7;
            btnSetShift.Text = "Назначить на смену";
            btnSetShift.UseVisualStyleBackColor = true;
            btnSetShift.Click += btnSetShift_Click;
            // 
            // lblName
            // 
            lblName.Location = new Point(530, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 27);
            lblName.TabIndex = 1;
            lblName.Text = "ФИО:";
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(530, 80);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(100, 27);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "Должность:";
            // 
            // ManagerForm
            // 
            ClientSize = new Size(860, 400);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Controls.Add(btnSetShift);
            Controls.Add(btnSetOperator);
            Controls.Add(btnSetCashier);
            Controls.Add(btnFire);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtPosition);
            Controls.Add(txtName);
            Controls.Add(dataGridViewEmployees);
            Name = "ManagerForm";
            Text = "Менеджер";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnSetCashier;
        private System.Windows.Forms.Button btnSetOperator;
        private System.Windows.Forms.Button btnSetShift;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
    }
}
