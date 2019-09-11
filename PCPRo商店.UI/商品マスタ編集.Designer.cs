namespace PCPRo商店.UI
{
    partial class 商品マスタ編集
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
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(33, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 46);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "登録";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // chkbDelete
            // 
            this.chkbDelete.AutoSize = true;
            this.chkbDelete.Location = new System.Drawing.Point(112, 200);
            this.chkbDelete.Name = "chkbDelete";
            this.chkbDelete.Size = new System.Drawing.Size(15, 14);
            this.chkbDelete.TabIndex = 21;
            this.chkbDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Location = new System.Drawing.Point(112, 151);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(104, 20);
            this.cmbSupplierCode.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(86, 19);
            this.txtPrice.TabIndex = 19;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(112, 70);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(86, 19);
            this.txtGoodsName.TabIndex = 18;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(92, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 12);
            this.lblCode.TabIndex = 17;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(31, 202);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 12);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "削除";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(31, 159);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 12);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "仕入先コード";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "単価";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(31, 73);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 12);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "商品名";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 12);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "商品コード";
            // 
            // 商品マスタ編集
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 399);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkbDelete);
            this.Controls.Add(this.cmbSupplierCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "商品マスタ編集";
            this.Text = "商品マスタ編集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.CheckBox chkbDelete;
        internal System.Windows.Forms.ComboBox cmbSupplierCode;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtGoodsName;
        internal System.Windows.Forms.Label lblCode;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}