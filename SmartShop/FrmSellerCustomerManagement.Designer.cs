namespace SmartShop
{
    partial class FrmSellerCustomerManagement
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
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCharje = new System.Windows.Forms.TextBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerDgv = new System.Windows.Forms.DataGridView();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EditCustomerBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(338, 49);
            this.AddCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(88, 28);
            this.AddCustomerBtn.TabIndex = 18;
            this.AddCustomerBtn.Text = "Add";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(243, 27);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(68, 20);
            this.txtCustomerAddress.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 62);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(68, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // txtCharje
            // 
            this.txtCharje.Location = new System.Drawing.Point(243, 65);
            this.txtCharje.Margin = new System.Windows.Forms.Padding(2);
            this.txtCharje.Name = "txtCharje";
            this.txtCharje.Size = new System.Drawing.Size(68, 20);
            this.txtCharje.TabIndex = 15;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(79, 27);
            this.txtNameCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(68, 20);
            this.txtNameCustomer.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Charj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddCustomerBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EditCustomerBtn);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCharje);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Location = new System.Drawing.Point(38, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 203);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CustomerDgv
            // 
            this.CustomerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNumber,
            this.CustomerName,
            this.CustomerAddress,
            this.Charj});
            this.CustomerDgv.Location = new System.Drawing.Point(38, 12);
            this.CustomerDgv.Name = "CustomerDgv";
            this.CustomerDgv.Size = new System.Drawing.Size(443, 123);
            this.CustomerDgv.TabIndex = 21;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.HeaderText = "Customer Number";
            this.CustomerNumber.Name = "CustomerNumber";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.HeaderText = "Customer Address";
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // Charj
            // 
            this.Charj.HeaderText = "Charj";
            this.Charj.Name = "Charj";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Select Customer To Edit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Select Customer To Delete";
            // 
            // EditCustomerBtn
            // 
            this.EditCustomerBtn.Location = new System.Drawing.Point(338, 103);
            this.EditCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditCustomerBtn.Name = "EditCustomerBtn";
            this.EditCustomerBtn.Size = new System.Drawing.Size(88, 28);
            this.EditCustomerBtn.TabIndex = 23;
            this.EditCustomerBtn.Text = "Edit";
            this.EditCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // FrmSellerCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 356);
            this.Controls.Add(this.CustomerDgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSellerCustomerManagement";
            this.Text = "SellerCustomerManagementFrm";
            this.Load += new System.EventHandler(this.SellClreckfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCharje;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CustomerDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditCustomerBtn;
    }
}