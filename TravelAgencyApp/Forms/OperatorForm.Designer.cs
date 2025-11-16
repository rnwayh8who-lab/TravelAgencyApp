namespace TravelAgencyApp
{
    partial class OperatorForm
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
            dataGridViewOrders = new DataGridView();
            txtClientName = new TextBox();
            btnAddClient = new Button();
            txtClientNameOrder = new TextBox();
            txtTour = new TextBox();
            btnCreateOrder = new Button();
            comboStatus = new ComboBox();
            btnSetStatus = new Button();
            btnPickTour = new Button();
            lblClientName = new Label();
            lblOrderClient = new Label();
            lblTour = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(12, 12);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowTemplate.Height = 29;
            dataGridViewOrders.Size = new Size(500, 300);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(580, 40);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(180, 23);
            txtClientName.TabIndex = 1;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(580, 70);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(180, 30);
            btnAddClient.TabIndex = 2;
            btnAddClient.Text = "Добавить клиента";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // txtClientNameOrder
            // 
            txtClientNameOrder.Location = new Point(580, 130);
            txtClientNameOrder.Name = "txtClientNameOrder";
            txtClientNameOrder.Size = new Size(180, 23);
            txtClientNameOrder.TabIndex = 3;
            // 
            // txtTour
            // 
            txtTour.Location = new Point(580, 170);
            txtTour.Name = "txtTour";
            txtTour.Size = new Size(180, 23);
            txtTour.TabIndex = 4;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(580, 210);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(180, 30);
            btnCreateOrder.TabIndex = 5;
            btnCreateOrder.Text = "Создать заказ";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "принят", "оплачен" });
            comboStatus.Location = new Point(580, 270);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(180, 23);
            comboStatus.TabIndex = 6;
            // 
            // btnSetStatus
            // 
            btnSetStatus.Location = new Point(580, 310);
            btnSetStatus.Name = "btnSetStatus";
            btnSetStatus.Size = new Size(180, 30);
            btnSetStatus.TabIndex = 7;
            btnSetStatus.Text = "Изменить статус";
            btnSetStatus.UseVisualStyleBackColor = true;
            btnSetStatus.Click += btnSetStatus_Click;
            // 
            // btnPickTour
            // 
            btnPickTour.Location = new Point(580, 360);
            btnPickTour.Name = "btnPickTour";
            btnPickTour.Size = new Size(180, 30);
            btnPickTour.TabIndex = 8;
            btnPickTour.Text = "Подобрать тур";
            btnPickTour.UseVisualStyleBackColor = true;
            btnPickTour.Click += btnPickTour_Click;
            // 
            // lblClientName
            // 
            lblClientName.Location = new Point(518, 40);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(50, 27);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "Клиент:";
            // 
            // lblOrderClient
            // 
            lblOrderClient.Location = new Point(518, 126);
            lblOrderClient.Name = "lblOrderClient";
            lblOrderClient.Size = new Size(51, 27);
            lblOrderClient.TabIndex = 2;
            lblOrderClient.Text = "Клиент:";
            // 
            // lblTour
            // 
            lblTour.Location = new Point(518, 170);
            lblTour.Name = "lblTour";
            lblTour.Size = new Size(53, 27);
            lblTour.TabIndex = 1;
            lblTour.Text = "Тур:";
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(518, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 27);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Статус:";
            // 
            // OperatorForm
            // 
            ClientSize = new Size(800, 420);
            Controls.Add(lblStatus);
            Controls.Add(lblTour);
            Controls.Add(lblOrderClient);
            Controls.Add(lblClientName);
            Controls.Add(btnPickTour);
            Controls.Add(btnSetStatus);
            Controls.Add(comboStatus);
            Controls.Add(btnCreateOrder);
            Controls.Add(txtTour);
            Controls.Add(txtClientNameOrder);
            Controls.Add(btnAddClient);
            Controls.Add(txtClientName);
            Controls.Add(dataGridViewOrders);
            Name = "OperatorForm";
            Text = "Оператор Call-центра";
            Load += OperatorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtClientNameOrder;
        private System.Windows.Forms.TextBox txtTour;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.Button btnPickTour;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblOrderClient;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblStatus;
    }
}
