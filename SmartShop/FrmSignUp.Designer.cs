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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserNameSignUp = new System.Windows.Forms.TextBox();
            this.txtPasswordSingUp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combUserTypeSignIn = new System.Windows.Forms.ComboBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "User_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // txtUserNameSignUp
            // 
            this.txtUserNameSignUp.Location = new System.Drawing.Point(291, 115);
            this.txtUserNameSignUp.Name = "txtUserNameSignUp";
            this.txtUserNameSignUp.Size = new System.Drawing.Size(100, 26);
            this.txtUserNameSignUp.TabIndex = 6;
            // 
            // txtPasswordSingUp
            // 
            this.txtPasswordSingUp.Location = new System.Drawing.Point(291, 160);
            this.txtPasswordSingUp.Name = "txtPasswordSingUp";
            this.txtPasswordSingUp.Size = new System.Drawing.Size(100, 26);
            this.txtPasswordSingUp.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "UserType";
            // 
            // combUserTypeSignIn
            // 
            this.combUserTypeSignIn.FormattingEnabled = true;
            this.combUserTypeSignIn.Location = new System.Drawing.Point(291, 219);
            this.combUserTypeSignIn.Name = "combUserTypeSignIn";
            this.combUserTypeSignIn.Size = new System.Drawing.Size(100, 28);
            this.combUserTypeSignIn.TabIndex = 11;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(291, 293);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 39);
            this.btnSignIn.TabIndex = 12;
            this.btnSignIn.Text = "sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 493);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.combUserTypeSignIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPasswordSingUp);
            this.Controls.Add(this.txtUserNameSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmSignUp";
            this.Text = "FrmSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserNameSignUp;
        private System.Windows.Forms.TextBox txtPasswordSingUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combUserTypeSignIn;
        private System.Windows.Forms.Button btnSignIn;
    }
}