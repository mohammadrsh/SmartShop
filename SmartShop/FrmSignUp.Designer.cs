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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.combUserTypeSignIn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordSingUp = new System.Windows.Forms.TextBox();
            this.txtUserNameSignUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.combUserTypeSignIn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPasswordSingUp);
            this.groupBox1.Controls.Add(this.txtUserNameSignUp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(96, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 252);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User Form";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 193);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(255, 31);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add This User";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // combUserTypeSignIn
            // 
            this.combUserTypeSignIn.FormattingEnabled = true;
            this.combUserTypeSignIn.Location = new System.Drawing.Point(185, 127);
            this.combUserTypeSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combUserTypeSignIn.Name = "combUserTypeSignIn";
            this.combUserTypeSignIn.Size = new System.Drawing.Size(139, 24);
            this.combUserTypeSignIn.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "UserType";
            // 
            // txtPasswordSingUp
            // 
            this.txtPasswordSingUp.Location = new System.Drawing.Point(185, 80);
            this.txtPasswordSingUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordSingUp.Name = "txtPasswordSingUp";
            this.txtPasswordSingUp.Size = new System.Drawing.Size(139, 22);
            this.txtPasswordSingUp.TabIndex = 16;
            // 
            // txtUserNameSignUp
            // 
            this.txtUserNameSignUp.Location = new System.Drawing.Point(185, 44);
            this.txtUserNameSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNameSignUp.Name = "txtUserNameSignUp";
            this.txtUserNameSignUp.Size = new System.Drawing.Size(139, 22);
            this.txtUserNameSignUp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "User_Name";
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 394);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSignUp";
            this.Text = "FrmSignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox combUserTypeSignIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordSingUp;
        private System.Windows.Forms.TextBox txtUserNameSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}