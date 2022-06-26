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
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_MemberMana_Add = new System.Windows.Forms.Button();
            this.btn_MemberMana_Delete = new System.Windows.Forms.Button();
            this.btn_MemberMana_Update = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Members
            // 
            this.dgv_Members.AllowUserToAddRows = false;
            this.dgv_Members.AllowUserToDeleteRows = false;
            this.dgv_Members.AllowUserToOrderColumns = true;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberId,
            this.MemberEmail,
            this.MemberCompanyName,
            this.MemberCity,
            this.MemberCountry});
            this.dgv_Members.Location = new System.Drawing.Point(14, 234);
            this.dgv_Members.MultiSelect = false;
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.ReadOnly = true;
            this.dgv_Members.RowHeadersWidth = 62;
            this.dgv_Members.RowTemplate.Height = 33;
            this.dgv_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Members.Size = new System.Drawing.Size(818, 409);
            this.dgv_Members.TabIndex = 0;
            this.dgv_Members.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Members_CellClick);
            // 
            // MemberId
            // 
            this.MemberId.HeaderText = "Member ID";
            this.MemberId.MinimumWidth = 8;
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            this.MemberId.Width = 150;
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
            this.btn_MemberMana_Add.Click += new System.EventHandler(this.btn_MemberMana_Add_Click);
            // 
            // btn_MemberMana_Delete
            // 
            this.btn_MemberMana_Delete.Enabled = false;
            this.btn_MemberMana_Delete.Location = new System.Drawing.Point(655, 61);
            this.btn_MemberMana_Delete.Name = "btn_MemberMana_Delete";
            this.btn_MemberMana_Delete.Size = new System.Drawing.Size(177, 34);
            this.btn_MemberMana_Delete.TabIndex = 2;
            this.btn_MemberMana_Delete.Text = "Delete member";
            this.btn_MemberMana_Delete.UseVisualStyleBackColor = true;
            this.btn_MemberMana_Delete.Click += new System.EventHandler(this.btn_MemberMana_Delete_Click);
            // 
            // btn_MemberMana_Update
            // 
            this.btn_MemberMana_Update.Enabled = false;
            this.btn_MemberMana_Update.Location = new System.Drawing.Point(321, 61);
            this.btn_MemberMana_Update.Name = "btn_MemberMana_Update";
            this.btn_MemberMana_Update.Size = new System.Drawing.Size(167, 34);
            this.btn_MemberMana_Update.TabIndex = 3;
            this.btn_MemberMana_Update.Text = "Update member";
            this.btn_MemberMana_Update.UseVisualStyleBackColor = true;
            this.btn_MemberMana_Update.Click += new System.EventHandler(this.btn_MemberMana_Update_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(678, 184);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(153, 34);
            this.btn_Reload.TabIndex = 4;
            this.btn_Reload.Text = "Reload Data";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 655);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_MemberMana_Update);
            this.Controls.Add(this.btn_MemberMana_Delete);
            this.Controls.Add(this.btn_MemberMana_Add);
            this.Controls.Add(this.dgv_Members);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.Button btn_MemberMana_Add;
        private System.Windows.Forms.Button btn_MemberMana_Delete;
        private System.Windows.Forms.Button btn_MemberMana_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCountry;
        private System.Windows.Forms.Button btn_Reload;
    }
}