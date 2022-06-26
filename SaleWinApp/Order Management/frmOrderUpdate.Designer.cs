namespace SaleWinApp
{
    partial class frmOrderUpdate
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_OrderId = new System.Windows.Forms.Label();
            this.label_Member = new System.Windows.Forms.Label();
            this.label_OrderDate = new System.Windows.Forms.Label();
            this.label_RequiredDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Freight = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.mTB_OrderId = new System.Windows.Forms.MaskedTextBox();
            this.cB_Member = new System.Windows.Forms.ComboBox();
            this.dTP_RequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_ShippedDate = new System.Windows.Forms.DateTimePicker();
            this.mTB_Freight = new System.Windows.Forms.MaskedTextBox();
            this.dTP_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(298, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(181, 36);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Update Order";
            // 
            // label_OrderId
            // 
            this.label_OrderId.AutoSize = true;
            this.label_OrderId.Location = new System.Drawing.Point(209, 103);
            this.label_OrderId.Name = "label_OrderId";
            this.label_OrderId.Size = new System.Drawing.Size(83, 25);
            this.label_OrderId.TabIndex = 1;
            this.label_OrderId.Text = "Order Id:";
            // 
            // label_Member
            // 
            this.label_Member.AutoSize = true;
            this.label_Member.Location = new System.Drawing.Point(209, 152);
            this.label_Member.Name = "label_Member";
            this.label_Member.Size = new System.Drawing.Size(83, 25);
            this.label_Member.TabIndex = 2;
            this.label_Member.Text = "Member:";
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.AutoSize = true;
            this.label_OrderDate.Location = new System.Drawing.Point(205, 211);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(104, 25);
            this.label_OrderDate.TabIndex = 3;
            this.label_OrderDate.Text = "Order Date:";
            // 
            // label_RequiredDate
            // 
            this.label_RequiredDate.AutoSize = true;
            this.label_RequiredDate.Location = new System.Drawing.Point(205, 264);
            this.label_RequiredDate.Name = "label_RequiredDate";
            this.label_RequiredDate.Size = new System.Drawing.Size(128, 25);
            this.label_RequiredDate.TabIndex = 4;
            this.label_RequiredDate.Text = "Required Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipped Date:";
            // 
            // label_Freight
            // 
            this.label_Freight.AutoSize = true;
            this.label_Freight.Location = new System.Drawing.Point(250, 362);
            this.label_Freight.Name = "label_Freight";
            this.label_Freight.Size = new System.Drawing.Size(71, 25);
            this.label_Freight.TabIndex = 6;
            this.label_Freight.Text = "Freight:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(265, 421);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(429, 421);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 34);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // mTB_OrderId
            // 
            this.mTB_OrderId.Enabled = false;
            this.mTB_OrderId.Location = new System.Drawing.Point(397, 103);
            this.mTB_OrderId.Mask = "00000";
            this.mTB_OrderId.Name = "mTB_OrderId";
            this.mTB_OrderId.Size = new System.Drawing.Size(182, 31);
            this.mTB_OrderId.TabIndex = 9;
            this.mTB_OrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mTB_OrderId.ValidatingType = typeof(int);
            // 
            // cB_Member
            // 
            this.cB_Member.AllowDrop = true;
            this.cB_Member.FormattingEnabled = true;
            this.cB_Member.Location = new System.Drawing.Point(360, 152);
            this.cB_Member.Name = "cB_Member";
            this.cB_Member.Size = new System.Drawing.Size(300, 33);
            this.cB_Member.Sorted = true;
            this.cB_Member.TabIndex = 10;
            // 
            // dTP_RequiredDate
            // 
            this.dTP_RequiredDate.Location = new System.Drawing.Point(360, 264);
            this.dTP_RequiredDate.Name = "dTP_RequiredDate";
            this.dTP_RequiredDate.Size = new System.Drawing.Size(300, 31);
            this.dTP_RequiredDate.TabIndex = 11;
            // 
            // dTP_ShippedDate
            // 
            this.dTP_ShippedDate.Location = new System.Drawing.Point(360, 319);
            this.dTP_ShippedDate.Name = "dTP_ShippedDate";
            this.dTP_ShippedDate.Size = new System.Drawing.Size(300, 31);
            this.dTP_ShippedDate.TabIndex = 12;
            this.dTP_ShippedDate.Value = new System.DateTime(2022, 6, 27, 1, 59, 1, 0);
            // 
            // mTB_Freight
            // 
            this.mTB_Freight.Location = new System.Drawing.Point(397, 362);
            this.mTB_Freight.Mask = "0000000000";
            this.mTB_Freight.Name = "mTB_Freight";
            this.mTB_Freight.Size = new System.Drawing.Size(182, 31);
            this.mTB_Freight.TabIndex = 13;
            this.mTB_Freight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mTB_Freight.ValidatingType = typeof(int);
            // 
            // dTP_OrderDate
            // 
            this.dTP_OrderDate.Enabled = false;
            this.dTP_OrderDate.Location = new System.Drawing.Point(360, 211);
            this.dTP_OrderDate.Name = "dTP_OrderDate";
            this.dTP_OrderDate.Size = new System.Drawing.Size(300, 31);
            this.dTP_OrderDate.TabIndex = 14;
            // 
            // frmOrderUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.dTP_OrderDate);
            this.Controls.Add(this.mTB_Freight);
            this.Controls.Add(this.dTP_ShippedDate);
            this.Controls.Add(this.dTP_RequiredDate);
            this.Controls.Add(this.cB_Member);
            this.Controls.Add(this.mTB_OrderId);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label_Freight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_RequiredDate);
            this.Controls.Add(this.label_OrderDate);
            this.Controls.Add(this.label_Member);
            this.Controls.Add(this.label_OrderId);
            this.Controls.Add(this.label_Title);
            this.Name = "frmOrderUpdate";
            this.Text = "Update Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_OrderId;
        private System.Windows.Forms.Label label_Member;
        private System.Windows.Forms.Label label_OrderDate;
        private System.Windows.Forms.Label label_RequiredDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Freight;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.MaskedTextBox mTB_OrderId;
        private System.Windows.Forms.ComboBox cB_Member;
        private System.Windows.Forms.DateTimePicker dTP_RequiredDate;
        private System.Windows.Forms.DateTimePicker dTP_ShippedDate;
        private System.Windows.Forms.MaskedTextBox mTB_Freight;
        private System.Windows.Forms.DateTimePicker dTP_OrderDate;
    }
}