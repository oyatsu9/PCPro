namespace PCPRo商店.UI
{
    partial class マスタ編集
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
            this.btnSupplierMaster = new System.Windows.Forms.Button();
            this.btnClientsMaster = new System.Windows.Forms.Button();
            this.btnGoodsMaster = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(20, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 50);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSupplierMaster
            // 
            this.btnSupplierMaster.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSupplierMaster.Location = new System.Drawing.Point(73, 265);
            this.btnSupplierMaster.Name = "btnSupplierMaster";
            this.btnSupplierMaster.Size = new System.Drawing.Size(255, 50);
            this.btnSupplierMaster.TabIndex = 13;
            this.btnSupplierMaster.Text = "仕入先マスタ";
            this.btnSupplierMaster.UseVisualStyleBackColor = true;
            // 
            // btnClientsMaster
            // 
            this.btnClientsMaster.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClientsMaster.Location = new System.Drawing.Point(73, 195);
            this.btnClientsMaster.Name = "btnClientsMaster";
            this.btnClientsMaster.Size = new System.Drawing.Size(255, 50);
            this.btnClientsMaster.TabIndex = 12;
            this.btnClientsMaster.Text = "納品先マスタ";
            this.btnClientsMaster.UseVisualStyleBackColor = true;
            // 
            // btnGoodsMaster
            // 
            this.btnGoodsMaster.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGoodsMaster.Location = new System.Drawing.Point(73, 126);
            this.btnGoodsMaster.Name = "btnGoodsMaster";
            this.btnGoodsMaster.Size = new System.Drawing.Size(255, 50);
            this.btnGoodsMaster.TabIndex = 11;
            this.btnGoodsMaster.Text = "商品マスタ";
            this.btnGoodsMaster.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(39, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(328, 64);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "マスタ編集";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // マスタ編集
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSupplierMaster);
            this.Controls.Add(this.btnClientsMaster);
            this.Controls.Add(this.btnGoodsMaster);
            this.Controls.Add(this.Label1);
            this.Name = "マスタ編集";
            this.Text = "マスタ編集";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnSupplierMaster;
        internal System.Windows.Forms.Button btnClientsMaster;
        internal System.Windows.Forms.Button btnGoodsMaster;
        internal System.Windows.Forms.Label Label1;
    }
}