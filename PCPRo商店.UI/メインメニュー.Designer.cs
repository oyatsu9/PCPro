namespace PCPRo商店.UI
{
    partial class メインメニュー
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMasterEditing = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(225, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "閉じる";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnMasterEditing
            // 
            this.btnMasterEditing.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMasterEditing.Location = new System.Drawing.Point(32, 276);
            this.btnMasterEditing.Name = "btnMasterEditing";
            this.btnMasterEditing.Size = new System.Drawing.Size(255, 50);
            this.btnMasterEditing.TabIndex = 8;
            this.btnMasterEditing.Text = "マスタ編集";
            this.btnMasterEditing.UseVisualStyleBackColor = true;
            // 
            // btnOrderList
            // 
            this.btnOrderList.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOrderList.Location = new System.Drawing.Point(32, 206);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(255, 50);
            this.btnOrderList.TabIndex = 7;
            this.btnOrderList.Text = "受注一覧";
            this.btnOrderList.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOrder.Location = new System.Drawing.Point(32, 137);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(255, 50);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "受注オペレーション";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(12, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(365, 64);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "メインメニュー";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // メインメニュー
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMasterEditing);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.Label1);
            this.Name = "メインメニュー";
            this.Text = "メインメニュー";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnMasterEditing;
        internal System.Windows.Forms.Button btnOrderList;
        internal System.Windows.Forms.Button btnOrder;
        internal System.Windows.Forms.Label Label1;
    }
}