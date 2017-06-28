namespace SmartShop
{
    partial class FrmSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserNameSignUp = new System.Windows.Forms.TextBox();
            this.txtPasswordSingUp = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "User_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(308, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtUserNameSignUp
            // 
            this.txtUserNameSignUp.Location = new System.Drawing.Point(308, 231);
            this.txtUserNameSignUp.Name = "txtUserNameSignUp";
            this.txtUserNameSignUp.Size = new System.Drawing.Size(100, 26);
            this.txtUserNameSignUp.TabIndex = 6;
            // 
            // txtPasswordSingUp
            // 
            this.txtPasswordSingUp.Location = new System.Drawing.Point(308, 279);
            this.txtPasswordSingUp.Name = "txtPasswordSingUp";
            this.txtPasswordSingUp.Size = new System.Drawing.Size(100, 26);
            this.txtPasswordSingUp.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(308, 182);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 26);
            this.txtUserID.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(308, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // combStatus
            // 
            this.combStatus.FormattingEnabled = true;
            this.combStatus.Location = new System.Drawing.Point(308, 327);
            this.combStatus.Name = "combStatus";
            this.combStatus.Size = new System.Drawing.Size(100, 28);
            this.combStatus.TabIndex = 11;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 493);
            this.Controls.Add(this.combStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtPasswordSingUp);
            this.Controls.Add(this.txtUserNameSignUp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSignUp";
            this.Text = "FrmSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserNameSignUp;
        private System.Windows.Forms.TextBox txtPasswordSingUp;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combStatus;
    }
}