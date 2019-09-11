namespace PCPRo商店.UI
{
    partial class 受注確認
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
            this.納品先コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納品先名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単価 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小計 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.削除 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.納品先コード,
            this.納品先名,
            this.商品コード,
            this.商品名,
            this.単価,
            this.数量,
            this.小計,
            this.削除});
            this.DataGridView1.Location = new System.Drawing.Point(32, 152);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 21;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(717, 289);
            this.DataGridView1.TabIndex = 14;
            // 
            // 納品先コード
            // 
            this.納品先コード.DataPropertyName = "納品先コード";
            this.納品先コード.HeaderText = "納品先コード";
            this.納品先コード.Name = "納品先コード";
            this.納品先コード.Visible = false;
            // 
            // 納品先名
            // 
            this.納品先名.DataPropertyName = "納品先名";
            this.納品先名.HeaderText = "納品先名";
            this.納品先名.Name = "納品先名";
            // 
            // 商品コード
            // 
            this.商品コード.DataPropertyName = "商品コード";
            this.商品コード.HeaderText = "商品コード";
            this.商品コード.Name = "商品コード";
            // 
            // 商品名
            // 
            this.商品名.DataPropertyName = "商品名";
            this.商品名.HeaderText = "商品名";
            this.商品名.Name = "商品名";
            // 
            // 単価
            // 
            this.単価.DataPropertyName = "単価";
            this.単価.HeaderText = "単価";
            this.単価.Name = "単価";
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            // 
            // 小計
            // 
            this.小計.DataPropertyName = "小計";
            this.小計.HeaderText = "小計";
            this.小計.Name = "小計";
            // 
            // 削除
            // 
            this.削除.DataPropertyName = "削除フラグ";
            this.削除.HeaderText = "削除";
            this.削除.Name = "削除";
            this.削除.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.削除.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Red;
            this.btnConfirm.Location = new System.Drawing.Point(554, 31);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 92);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "確　定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(138, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(365, 64);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "受注確認";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(32, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 50);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(521, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 50);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "閉じる";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // 受注確認
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 531);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Name = "受注確認";
            this.Text = "受注確認";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 納品先コード;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 納品先名;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 商品コード;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 商品名;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 単価;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 小計;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn 削除;
        internal System.Windows.Forms.Button btnConfirm;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnExit;
    }
}