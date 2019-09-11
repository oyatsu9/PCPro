namespace PCPRo商店.UI
{
    partial class ログイン画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(62, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 12);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "パスワード";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(62, 125);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 12);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "ユーザーＩＤ";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(125, 150);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(129, 19);
            this.txtPW.TabIndex = 21;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(125, 118);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(129, 19);
            this.txtUserID.TabIndex = 20;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogIn.Location = new System.Drawing.Point(195, 239);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(166, 50);
            this.btnLogIn.TabIndex = 19;
            this.btnLogIn.Text = "ログイン";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(38, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 50);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "閉じる";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(365, 64);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "ログイン画面";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ログイン画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 305);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Label1);
            this.Name = "ログイン画面";
            this.Text = "ログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPW;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.Button btnLogIn;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label Label1;
    }
}

