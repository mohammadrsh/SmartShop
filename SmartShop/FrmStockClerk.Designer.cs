namespace SmartShop
{
    partial class FrmStockClerk
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
            this.components = new System.ComponentModel.Container();
            this.lblPageName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kalaDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalaRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartShopDataSet = new SmartShop.SmartShopDataSet();
            this.smartShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartShopDataSet1 = new SmartShop.SmartShopDataSet1();
            this.kalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalaTableAdapter = new SmartShop.SmartShopDataSet1TableAdapters.KalaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockClerkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageName
            // 
            this.lblPageName.AutoSize = true;
            this.lblPageName.Location = new System.Drawing.Point(44, 21);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(116, 17);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.Text = "Stock Clerk Page";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.creatDateDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.submitDateDataGridViewTextBoxColumn,
            this.stockClerkidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kalaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // kalaDataTableBindingSource
            // 
            this.kalaDataTableBindingSource.DataSource = typeof(SmartShop.SmartShopDataSet.KalaDataTable);
            // 
            // kalaRowBindingSource
            // 
            this.kalaRowBindingSource.DataSource = typeof(SmartShop.SmartShopDataSet.KalaRow);
            // 
            // smartShopDataSet
            // 
            this.smartShopDataSet.DataSetName = "SmartShopDataSet";
            this.smartShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartShopDataSetBindingSource
            // 
            this.smartShopDataSetBindingSource.DataSource = this.smartShopDataSet;
            this.smartShopDataSetBindingSource.Position = 0;
            // 
            // smartShopDataSet1
            // 
            this.smartShopDataSet1.DataSetName = "SmartShopDataSet1";
            this.smartShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalaBindingSource
            // 
            this.kalaBindingSource.DataMember = "Kala";
            this.kalaBindingSource.DataSource = this.smartShopDataSet1;
            // 
            // kalaTableAdapter
            // 
            this.kalaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "producer";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            // 
            // creatDateDataGridViewTextBoxColumn
            // 
            this.creatDateDataGridViewTextBoxColumn.DataPropertyName = "creatDate";
            this.creatDateDataGridViewTextBoxColumn.HeaderText = "creatDate";
            this.creatDateDataGridViewTextBoxColumn.Name = "creatDateDataGridViewTextBoxColumn";
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "expireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "expireDate";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "seller";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            // 
            // submitDateDataGridViewTextBoxColumn
            // 
            this.submitDateDataGridViewTextBoxColumn.DataPropertyName = "submitDate";
            this.submitDateDataGridViewTextBoxColumn.HeaderText = "submitDate";
            this.submitDateDataGridViewTextBoxColumn.Name = "submitDateDataGridViewTextBoxColumn";
            // 
            // stockClerkidDataGridViewTextBoxColumn
            // 
            this.stockClerkidDataGridViewTextBoxColumn.DataPropertyName = "stockClerk_id";
            this.stockClerkidDataGridViewTextBoxColumn.HeaderText = "stockClerk_id";
            this.stockClerkidDataGridViewTextBoxColumn.Name = "stockClerkidDataGridViewTextBoxColumn";
            // 
            // FrmStockClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 585);
            this.Controls.Add(this.lblPageName);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStockClerk";
            this.Text = "FrmStockClerk";
            this.Load += new System.EventHandler(this.FrmStockClerk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource smartShopDataSetBindingSource;
        private SmartShopDataSet smartShopDataSet;
        private System.Windows.Forms.BindingSource kalaDataTableBindingSource;
        private System.Windows.Forms.BindingSource kalaRowBindingSource;
        private SmartShopDataSet1 smartShopDataSet1;
        private System.Windows.Forms.BindingSource kalaBindingSource;
        private SmartShopDataSet1TableAdapters.KalaTableAdapter kalaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockClerkidDataGridViewTextBoxColumn;
    }
}