namespace SmartShop
{
    partial class FrmSellerInvoiceManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerIDtxt = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.InvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashierNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.GroupBox();
            this.EditInvoiceBtn = new System.Windows.Forms.Button();
            this.DeleteInvoiceBtn = new System.Windows.Forms.Button();
            this.AddInvoiceBtn = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).BeginInit();
            this.invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerIDtxt);
            this.groupBox1.Controls.Add(this.EnterBtn);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(575, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Customer ID:";
            // 
            // CustomerIDtxt
            // 
            this.CustomerIDtxt.Location = new System.Drawing.Point(160, 15);
            this.CustomerIDtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerIDtxt.Name = "CustomerIDtxt";
            this.CustomerIDtxt.Size = new System.Drawing.Size(132, 22);
            this.CustomerIDtxt.TabIndex = 1;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(315, 15);
            this.EnterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(100, 28);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            // 
            // InvoiceDataGridView
            // 
            this.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumber,
            this.InvoiceDateAndTime,
            this.CashierNumber,
            this.CustomerNumber,
            this.ProductName,
            this.Price});
            this.InvoiceDataGridView.Location = new System.Drawing.Point(4, 74);
            this.InvoiceDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvoiceDataGridView.Name = "InvoiceDataGridView";
            this.InvoiceDataGridView.Size = new System.Drawing.Size(575, 185);
            this.InvoiceDataGridView.TabIndex = 2;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.HeaderText = "Invoice Number";
            this.InvoiceNumber.Name = "InvoiceNumber";
            // 
            // InvoiceDateAndTime
            // 
            this.InvoiceDateAndTime.HeaderText = "Date And Time";
            this.InvoiceDateAndTime.Name = "InvoiceDateAndTime";
            // 
            // CashierNumber
            // 
            this.CashierNumber.HeaderText = "Cashier Number";
            this.CashierNumber.Name = "CashierNumber";
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.HeaderText = "Cusromer Number";
            this.CustomerNumber.Name = "CustomerNumber";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // invoice
            // 
            this.invoice.Controls.Add(this.EditInvoiceBtn);
            this.invoice.Controls.Add(this.DeleteInvoiceBtn);
            this.invoice.Controls.Add(this.AddInvoiceBtn);
            this.invoice.Location = new System.Drawing.Point(604, 4);
            this.invoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.invoice.Name = "invoice";
            this.invoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.invoice.Size = new System.Drawing.Size(397, 255);
            this.invoice.TabIndex = 3;
            this.invoice.TabStop = false;
            this.invoice.Text = "INVOICE";
            // 
            // EditInvoiceBtn
            // 
            this.EditInvoiceBtn.Location = new System.Drawing.Point(289, 150);
            this.EditInvoiceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditInvoiceBtn.Name = "EditInvoiceBtn";
            this.EditInvoiceBtn.Size = new System.Drawing.Size(100, 28);
            this.EditInvoiceBtn.TabIndex = 3;
            this.EditInvoiceBtn.Text = "Edit";
            this.EditInvoiceBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteInvoiceBtn
            // 
            this.DeleteInvoiceBtn.Location = new System.Drawing.Point(289, 219);
            this.DeleteInvoiceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteInvoiceBtn.Name = "DeleteInvoiceBtn";
            this.DeleteInvoiceBtn.Size = new System.Drawing.Size(100, 28);
            this.DeleteInvoiceBtn.TabIndex = 4;
            this.DeleteInvoiceBtn.Text = "Delete";
            this.DeleteInvoiceBtn.UseVisualStyleBackColor = true;
            // 
            // AddInvoiceBtn
            // 
            this.AddInvoiceBtn.Location = new System.Drawing.Point(289, 23);
            this.AddInvoiceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddInvoiceBtn.Name = "AddInvoiceBtn";
            this.AddInvoiceBtn.Size = new System.Drawing.Size(100, 28);
            this.AddInvoiceBtn.TabIndex = 2;
            this.AddInvoiceBtn.Text = "Add";
            this.AddInvoiceBtn.UseVisualStyleBackColor = true;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Producer,
            this.CreatDate,
            this.ExpireDate,
            this.ProductPrice,
            this.Quantity,
            this.Discount});
            this.ProductDataGridView.Location = new System.Drawing.Point(5, 266);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.Size = new System.Drawing.Size(996, 113);
            this.ProductDataGridView.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Producer
            // 
            this.Producer.HeaderText = "Producer";
            this.Producer.Name = "Producer";
            // 
            // CreatDate
            // 
            this.CreatDate.HeaderText = "Create Date";
            this.CreatDate.Name = "CreatDate";
            // 
            // ExpireDate
            // 
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.Name = "ExpireDate";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            // 
            // FrmSellerInvoiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 386);
            this.Controls.Add(this.InvoiceDataGridView);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.Name = "FrmSellerInvoiceManagement";
            this.Text = "FrmSellerInvoiceManagement";
            this.Load += new System.EventHandler(this.FrmSellerInvoiceManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).EndInit();
            this.invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView InvoiceDataGridView;
        private System.Windows.Forms.TextBox CustomerIDtxt;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashierNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.GroupBox invoice;
        private System.Windows.Forms.Button EditInvoiceBtn;
        private System.Windows.Forms.Button DeleteInvoiceBtn;
        private System.Windows.Forms.Button AddInvoiceBtn;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}