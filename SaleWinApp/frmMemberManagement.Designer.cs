namespace SaleWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_MemberMana_Add = new System.Windows.Forms.Button();
            this.btn_MemberMana_Delete = new System.Windows.Forms.Button();
            this.btn_MemberMana_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberEmail,
            this.MemberCompanyName,
            this.MemberCity,
            this.MemberCountry});
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(759, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // MemberEmail
            // 
            this.MemberEmail.HeaderText = "Email";
            this.MemberEmail.MinimumWidth = 8;
            this.MemberEmail.Name = "MemberEmail";
            this.MemberEmail.ReadOnly = true;
            this.MemberEmail.Width = 150;
            // 
            // MemberCompanyName
            // 
            this.MemberCompanyName.HeaderText = "CompanyName";
            this.MemberCompanyName.MinimumWidth = 8;
            this.MemberCompanyName.Name = "MemberCompanyName";
            this.MemberCompanyName.ReadOnly = true;
            this.MemberCompanyName.Width = 150;
            // 
            // MemberCity
            // 
            this.MemberCity.HeaderText = "City";
            this.MemberCity.MinimumWidth = 8;
            this.MemberCity.Name = "MemberCity";
            this.MemberCity.ReadOnly = true;
            this.MemberCity.Width = 150;
            // 
            // MemberCountry
            // 
            this.MemberCountry.HeaderText = "Country";
            this.MemberCountry.MinimumWidth = 8;
            this.MemberCountry.Name = "MemberCountry";
            this.MemberCountry.ReadOnly = true;
            this.MemberCountry.Width = 150;
            // 
            // btn_MemberMana_Add
            // 
            this.btn_MemberMana_Add.Location = new System.Drawing.Point(29, 61);
            this.btn_MemberMana_Add.Name = "btn_MemberMana_Add";
            this.btn_MemberMana_Add.Size = new System.Drawing.Size(186, 34);
            this.btn_MemberMana_Add.TabIndex = 1;
            this.btn_MemberMana_Add.Text = "Add a new member";
            this.btn_MemberMana_Add.UseVisualStyleBackColor = true;
            // 
            // btn_MemberMana_Delete
            // 
            this.btn_MemberMana_Delete.Location = new System.Drawing.Point(594, 61);
            this.btn_MemberMana_Delete.Name = "btn_MemberMana_Delete";
            this.btn_MemberMana_Delete.Size = new System.Drawing.Size(177, 34);
            this.btn_MemberMana_Delete.TabIndex = 2;
            this.btn_MemberMana_Delete.Text = "Delete member";
            this.btn_MemberMana_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_MemberMana_Update
            // 
            this.btn_MemberMana_Update.Location = new System.Drawing.Point(321, 61);
            this.btn_MemberMana_Update.Name = "btn_MemberMana_Update";
            this.btn_MemberMana_Update.Size = new System.Drawing.Size(167, 34);
            this.btn_MemberMana_Update.TabIndex = 3;
            this.btn_MemberMana_Update.Text = "Update member";
            this.btn_MemberMana_Update.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 655);
            this.Controls.Add(this.btn_MemberMana_Update);
            this.Controls.Add(this.btn_MemberMana_Delete);
            this.Controls.Add(this.btn_MemberMana_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCountry;
        private System.Windows.Forms.Button btn_MemberMana_Add;
        private System.Windows.Forms.Button btn_MemberMana_Delete;
        private System.Windows.Forms.Button btn_MemberMana_Update;
    }
}