namespace PCPRo商店.UI
{
    partial class 納品マスタ編集
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkbDelete = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtClientsName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 39);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(44, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 46);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "登録";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // chkbDelete
            // 
            this.chkbDelete.AutoSize = true;
            this.chkbDelete.Location = new System.Drawing.Point(123, 191);
            this.chkbDelete.Name = "chkbDelete";
            this.chkbDelete.Size = new System.Drawing.Size(15, 14);
            this.chkbDelete.TabIndex = 31;
            this.chkbDelete.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(86, 19);
            this.txtAddress.TabIndex = 30;
            // 
            // txtClientsName
            // 
            this.txtClientsName.Location = new System.Drawing.Point(123, 61);
            this.txtClientsName.Name = "txtClientsName";
            this.txtClientsName.Size = new System.Drawing.Size(86, 19);
            this.txtClientsName.TabIndex = 29;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(121, 22);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 12);
            this.lblCode.TabIndex = 28;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(42, 193);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 12);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "削除";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(42, 107);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "住所";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(42, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 12);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "納品先名";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(27, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 12);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "納品先コード";
            // 
            // 納品マスタ編集
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 410);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkbDelete);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtClientsName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "納品マスタ編集";
            this.Text = "納品マスタ編集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.CheckBox chkbDelete;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtClientsName;
        internal System.Windows.Forms.Label lblCode;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}