namespace PCPRo商店.UI
{
    partial class 受注一覧
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
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbGoodsName = new System.Windows.Forms.ComboBox();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.cmbOrderMonthTo = new System.Windows.Forms.ComboBox();
            this.cmbOrderYearTo = new System.Windows.Forms.ComboBox();
            this.cmbOrderMonthFrom = new System.Windows.Forms.ComboBox();
            this.cmbOrderYearFrom = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(35, 588);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 40);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(352, 108);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(17, 12);
            this.Label9.TabIndex = 48;
            this.Label9.Text = "年";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(248, 108);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(17, 12);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "～";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(469, 108);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(17, 12);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "月";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(225, 108);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(17, 12);
            this.Label7.TabIndex = 45;
            this.Label7.Text = "月";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(121, 108);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(17, 12);
            this.Label5.TabIndex = 44;
            this.Label5.Text = "年";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(283, 137);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 12);
            this.Label4.TabIndex = 43;
            this.Label4.Text = "商品名";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(33, 137);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 12);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "お客様名";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(33, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "受注年月日";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(35, 183);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 21;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(655, 399);
            this.DataGridView1.TabIndex = 40;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Location = new System.Drawing.Point(539, 155);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(75, 23);
            this.btnPrinting.TabIndex = 39;
            this.btnPrinting.Text = "印刷";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(539, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(539, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbGoodsName
            // 
            this.cmbGoodsName.FormattingEnabled = true;
            this.cmbGoodsName.Location = new System.Drawing.Point(285, 157);
            this.cmbGoodsName.Name = "cmbGoodsName";
            this.cmbGoodsName.Size = new System.Drawing.Size(192, 20);
            this.cmbGoodsName.TabIndex = 36;
            // 
            // cmbClientName
            // 
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(35, 157);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(184, 20);
            this.cmbClientName.TabIndex = 35;
            // 
            // cmbOrderMonthTo
            // 
            this.cmbOrderMonthTo.FormattingEnabled = true;
            this.cmbOrderMonthTo.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbOrderMonthTo.Location = new System.Drawing.Point(388, 100);
            this.cmbOrderMonthTo.Name = "cmbOrderMonthTo";
            this.cmbOrderMonthTo.Size = new System.Drawing.Size(75, 20);
            this.cmbOrderMonthTo.TabIndex = 34;
            // 
            // cmbOrderYearTo
            // 
            this.cmbOrderYearTo.FormattingEnabled = true;
            this.cmbOrderYearTo.Location = new System.Drawing.Point(271, 100);
            this.cmbOrderYearTo.Name = "cmbOrderYearTo";
            this.cmbOrderYearTo.Size = new System.Drawing.Size(75, 20);
            this.cmbOrderYearTo.TabIndex = 33;
            // 
            // cmbOrderMonthFrom
            // 
            this.cmbOrderMonthFrom.FormattingEnabled = true;
            this.cmbOrderMonthFrom.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbOrderMonthFrom.Location = new System.Drawing.Point(144, 100);
            this.cmbOrderMonthFrom.Name = "cmbOrderMonthFrom";
            this.cmbOrderMonthFrom.Size = new System.Drawing.Size(75, 20);
            this.cmbOrderMonthFrom.TabIndex = 32;
            // 
            // cmbOrderYearFrom
            // 
            this.cmbOrderYearFrom.FormattingEnabled = true;
            this.cmbOrderYearFrom.Location = new System.Drawing.Point(35, 100);
            this.cmbOrderYearFrom.Name = "cmbOrderYearFrom";
            this.cmbOrderYearFrom.Size = new System.Drawing.Size(75, 20);
            this.cmbOrderYearFrom.TabIndex = 31;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(141, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(365, 51);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "受注一覧";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 受注一覧
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 643);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbGoodsName);
            this.Controls.Add(this.cmbClientName);
            this.Controls.Add(this.cmbOrderMonthTo);
            this.Controls.Add(this.cmbOrderYearTo);
            this.Controls.Add(this.cmbOrderMonthFrom);
            this.Controls.Add(this.cmbOrderYearFrom);
            this.Controls.Add(this.Label1);
            this.Name = "受注一覧";
            this.Text = "受注一覧";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnPrinting;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.ComboBox cmbGoodsName;
        internal System.Windows.Forms.ComboBox cmbClientName;
        internal System.Windows.Forms.ComboBox cmbOrderMonthTo;
        internal System.Windows.Forms.ComboBox cmbOrderYearTo;
        internal System.Windows.Forms.ComboBox cmbOrderMonthFrom;
        internal System.Windows.Forms.ComboBox cmbOrderYearFrom;
        internal System.Windows.Forms.Label Label1;
    }
}