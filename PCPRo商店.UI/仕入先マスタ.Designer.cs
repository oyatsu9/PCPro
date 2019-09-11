namespace PCPRo商店.UI
{
    partial class 仕入先マスタ
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBack.Location = new System.Drawing.Point(55, 513);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 40);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(562, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(562, 74);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridView1.Location = new System.Drawing.Point(47, 145);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 21;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(579, 297);
            this.DataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "仕入先コード";
            this.Column1.FillWeight = 104F;
            this.Column1.HeaderText = "仕入先コード";
            this.Column1.Name = "Column1";
            this.Column1.Width = 104;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "仕入先名";
            this.Column2.HeaderText = "仕入先名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "住所";
            this.Column3.HeaderText = "住所";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(494, 513);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 37);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(304, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(197, 19);
            this.txtAddress.TabIndex = 34;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(152, 120);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(155, 19);
            this.txtSupplierName.TabIndex = 33;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(49, 120);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(102, 19);
            this.txtSupplierCode.TabIndex = 32;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(73, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(398, 48);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "　　仕入先マスタ　　";
            // 
            // 仕入先マスタ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 580);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.Label1);
            this.Name = "仕入先マスタ";
            this.Text = "仕入先マスタ";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtSupplierName;
        internal System.Windows.Forms.TextBox txtSupplierCode;
        internal System.Windows.Forms.Label Label1;
    }
}