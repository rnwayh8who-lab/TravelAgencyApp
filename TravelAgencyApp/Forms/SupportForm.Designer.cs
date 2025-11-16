namespace TravelAgencyApp
{
    partial class SupportForm
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
            comboStatus = new ComboBox();
            btnSetStatus = new Button();
            btnGiveVoucher = new Button();
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
            dataGridViewOrders.Size = new Size(480, 300);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "принят", "в работе", "завершен" });
            comboStatus.Location = new Point(580, 40);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(180, 23);
            comboStatus.TabIndex = 1;
            // 
            // btnSetStatus
            // 
            btnSetStatus.Location = new Point(560, 90);
            btnSetStatus.Name = "btnSetStatus";
            btnSetStatus.Size = new Size(220, 40);
            btnSetStatus.TabIndex = 2;
            btnSetStatus.Text = "Изменить статус";
            btnSetStatus.UseVisualStyleBackColor = true;
            btnSetStatus.Click += btnSetStatus_Click;
            // 
            // btnGiveVoucher
            // 
            btnGiveVoucher.Location = new Point(560, 150);
            btnGiveVoucher.Name = "btnGiveVoucher";
            btnGiveVoucher.Size = new Size(220, 40);
            btnGiveVoucher.TabIndex = 3;
            btnGiveVoucher.Text = "Выдать путёвку";
            btnGiveVoucher.UseVisualStyleBackColor = true;
            btnGiveVoucher.Click += btnGiveVoucher_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(500, 40);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 28);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Статус:";
            lblStatus.Click += lblStatus_Click;
            // 
            // SupportForm
            // 
            ClientSize = new Size(800, 330);
            Controls.Add(lblStatus);
            Controls.Add(btnGiveVoucher);
            Controls.Add(btnSetStatus);
            Controls.Add(comboStatus);
            Controls.Add(dataGridViewOrders);
            Name = "SupportForm";
            Text = "Специалист по сопровождению";
            Load += SupportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.Button btnGiveVoucher;
        private System.Windows.Forms.Label lblStatus;
    }
}
