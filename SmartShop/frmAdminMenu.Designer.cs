namespace SmartShop
{
    partial class frmAdminMenu
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnStockClerk = new System.Windows.Forms.Button();
            this.btnSellClerk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(148, 91);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up!";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnStockClerk
            // 
            this.btnStockClerk.Location = new System.Drawing.Point(124, 137);
            this.btnStockClerk.Name = "btnStockClerk";
            this.btnStockClerk.Size = new System.Drawing.Size(125, 23);
            this.btnStockClerk.TabIndex = 0;
            this.btnStockClerk.Text = "Stock Clerk Menu!";
            this.btnStockClerk.UseVisualStyleBackColor = true;
            // 
            // btnSellClerk
            // 
            this.btnSellClerk.Location = new System.Drawing.Point(135, 185);
            this.btnSellClerk.Name = "btnSellClerk";
            this.btnSellClerk.Size = new System.Drawing.Size(101, 23);
            this.btnSellClerk.TabIndex = 0;
            this.btnSellClerk.Text = "SellClerkMenu!";
            this.btnSellClerk.UseVisualStyleBackColor = true;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 329);
            this.Controls.Add(this.btnSellClerk);
            this.Controls.Add(this.btnStockClerk);
            this.Controls.Add(this.btnSignUp);
            this.Name = "frmAdminMenu";
            this.Text = "frmAdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnStockClerk;
        private System.Windows.Forms.Button btnSellClerk;
    }
}