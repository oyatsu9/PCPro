namespace PCPRo商店.UI
{
    partial class 商品マスタ
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単価 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仕入先コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.削除 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.txtGoodsPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtGoodsCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品コード,
            this.商品名,
            this.単価,
            this.仕入先コード,
            this.削除});
            this.DataGridView1.Location = new System.Drawing.Point(21, 147);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 21;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(614, 297);
            this.DataGridView1.TabIndex = 17;
            // 
            // 商品コード
            // 
            this.商品コード.DataPropertyName = "商品コード";
            this.商品コード.FillWeight = 89.86514F;
            this.商品コード.HeaderText = "商品コード";
            this.商品コード.Name = "商品コード";
            this.商品コード.ReadOnly = true;
            this.商品コード.Width = 86;
            // 
            // 商品名
            // 
            this.商品名.DataPropertyName = "商品名";
            this.商品名.FillWeight = 154.9615F;
            this.商品名.HeaderText = "商品名";
            this.商品名.Name = "商品名";
            this.商品名.ReadOnly = true;
            this.商品名.Width = 218;
            // 
            // 単価
            // 
            this.単価.DataPropertyName = "単価";
            this.単価.FillWeight = 121.2792F;
            this.単価.HeaderText = "単価";
            this.単価.Name = "単価";
            this.単価.ReadOnly = true;
            // 
            // 仕入先コード
            // 
            this.仕入先コード.DataPropertyName = "仕入先コード";
            this.仕入先コード.FillWeight = 83.13275F;
            this.仕入先コード.HeaderText = "仕入先コード";
            this.仕入先コード.Name = "仕入先コード";
            this.仕入先コード.ReadOnly = true;
            this.仕入先コード.Width = 104;
            // 
            // 削除
            // 
            this.削除.DataPropertyName = "削除フラグ";
            this.削除.FillWeight = 50.76142F;
            this.削除.HeaderText = "削除";
            this.削除.Name = "削除";
            this.削除.ReadOnly = true;
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Location = new System.Drawing.Point(426, 122);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(104, 20);
            this.cmbSupplierCode.TabIndex = 16;
            // 
            // txtGoodsPrice
            // 
            this.txtGoodsPrice.Location = new System.Drawing.Point(325, 122);
            this.txtGoodsPrice.Name = "txtGoodsPrice";
            this.txtGoodsPrice.Size = new System.Drawing.Size(100, 19);
            this.txtGoodsPrice.TabIndex = 15;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(107, 122);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(218, 19);
            this.txtGoodsName.TabIndex = 14;
            // 
            // txtGoodsCode
            // 
            this.txtGoodsCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtGoodsCode.Location = new System.Drawing.Point(21, 122);
            this.txtGoodsCode.Name = "txtGoodsCode";
            this.txtGoodsCode.Size = new System.Drawing.Size(86, 19);
            this.txtGoodsCode.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(47, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(300, 48);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "商品マスタ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(469, 515);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 37);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 515);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(571, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(571, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // 商品マスタ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 580);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.cmbSupplierCode);
            this.Controls.Add(this.txtGoodsPrice);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsCode);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Name = "商品マスタ";
            this.Text = "商品マスタ";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 商品コード;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 商品名;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 単価;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 仕入先コード;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn 削除;
        internal System.Windows.Forms.ComboBox cmbSupplierCode;
        internal System.Windows.Forms.TextBox txtGoodsPrice;
        internal System.Windows.Forms.TextBox txtGoodsName;
        internal System.Windows.Forms.TextBox txtGoodsCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnClear;
    }
}