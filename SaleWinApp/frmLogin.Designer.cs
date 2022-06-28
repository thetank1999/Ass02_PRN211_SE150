namespace SaleWinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_LoginTitle = new System.Windows.Forms.Label();
            this.label_LoginPassword = new System.Windows.Forms.Label();
            this.label_LoginEmail = new System.Windows.Forms.Label();
            this.tB_EmailAddress = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_LoginTitle
            // 
            this.label_LoginTitle.AutoSize = true;
            this.label_LoginTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LoginTitle.Location = new System.Drawing.Point(166, 32);
            this.label_LoginTitle.Name = "label_LoginTitle";
            this.label_LoginTitle.Size = new System.Drawing.Size(489, 54);
            this.label_LoginTitle.TabIndex = 0;
            this.label_LoginTitle.Text = "Welcom to Sale Win App";
            // 
            // label_LoginPassword
            // 
            this.label_LoginPassword.AutoSize = true;
            this.label_LoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LoginPassword.Location = new System.Drawing.Point(193, 222);
            this.label_LoginPassword.Name = "label_LoginPassword";
            this.label_LoginPassword.Size = new System.Drawing.Size(97, 25);
            this.label_LoginPassword.TabIndex = 1;
            this.label_LoginPassword.Text = "Password:";
            // 
            // label_LoginEmail
            // 
            this.label_LoginEmail.AutoSize = true;
            this.label_LoginEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LoginEmail.Location = new System.Drawing.Point(193, 156);
            this.label_LoginEmail.Name = "label_LoginEmail";
            this.label_LoginEmail.Size = new System.Drawing.Size(141, 25);
            this.label_LoginEmail.TabIndex = 2;
            this.label_LoginEmail.Text = "Email Address: ";
            // 
            // tB_EmailAddress
            // 
            this.tB_EmailAddress.Location = new System.Drawing.Point(391, 156);
            this.tB_EmailAddress.Name = "tB_EmailAddress";
            this.tB_EmailAddress.Size = new System.Drawing.Size(233, 31);
            this.tB_EmailAddress.TabIndex = 3;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(391, 216);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(233, 31);
            this.tB_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(416, 309);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 34);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Register.Location = new System.Drawing.Point(222, 309);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(112, 34);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_EmailAddress);
            this.Controls.Add(this.label_LoginEmail);
            this.Controls.Add(this.label_LoginPassword);
            this.Controls.Add(this.label_LoginTitle);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LoginTitle;
        private System.Windows.Forms.Label label_LoginPassword;
        private System.Windows.Forms.Label label_LoginEmail;
        private System.Windows.Forms.TextBox tB_EmailAddress;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
    }
}
