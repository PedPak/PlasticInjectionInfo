namespace TazrighInfo
{
    partial class frmOrderSearch
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchOrderCode = new System.Windows.Forms.Button();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductionCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwShowResult = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchOrderCode);
            this.groupBox2.Controls.Add(this.txtOrderCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(215, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 96);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو بر اساس شماره سفارش";
            // 
            // btnSearchOrderCode
            // 
            this.btnSearchOrderCode.Location = new System.Drawing.Point(13, 63);
            this.btnSearchOrderCode.Name = "btnSearchOrderCode";
            this.btnSearchOrderCode.Size = new System.Drawing.Size(142, 25);
            this.btnSearchOrderCode.TabIndex = 4;
            this.btnSearchOrderCode.Text = "جستجو شماره سفارش";
            this.btnSearchOrderCode.UseVisualStyleBackColor = true;
            this.btnSearchOrderCode.Click += new System.EventHandler(this.btnSearchOrderCode_Click);
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Location = new System.Drawing.Point(13, 31);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(150, 21);
            this.txtOrderCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "شماره سفارش";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCustomer);
            this.groupBox3.Controls.Add(this.txtProduct);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtProductionCode);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(465, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 164);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مشخصات كلي سفارش";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(20, 61);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(232, 21);
            this.txtCustomer.TabIndex = 41;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(20, 34);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(232, 21);
            this.txtProduct.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProductionCode
            // 
            this.txtProductionCode.Location = new System.Drawing.Point(109, 88);
            this.txtProductionCode.Name = "txtProductionCode";
            this.txtProductionCode.Size = new System.Drawing.Size(143, 21);
            this.txtProductionCode.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام قطعه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام مشتري";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "شماره توليد";
            // 
            // dgwShowResult
            // 
            this.dgwShowResult.AllowDrop = true;
            this.dgwShowResult.AllowUserToAddRows = false;
            this.dgwShowResult.AllowUserToDeleteRows = false;
            this.dgwShowResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgwShowResult.Location = new System.Drawing.Point(8, 197);
            this.dgwShowResult.Name = "dgwShowResult";
            this.dgwShowResult.Size = new System.Drawing.Size(806, 247);
            this.dgwShowResult.TabIndex = 39;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 31);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "مشاهده و انجام ويرايش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "شماره سفارش";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "نام قطعه";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CustomerName";
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "نام مشتري";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductionCode";
            this.Column4.HeaderText = "شماره توليد";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OrderDate";
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "تاريخ ثبت سفارش";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NumberofOrder";
            this.Column5.HeaderText = "تعداد سفارش";
            this.Column5.Name = "Column5";
            // 
            // frmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 478);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgwShowResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "جستجوي سفارش";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderSearch_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderSearch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchOrderCode;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProductionCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgwShowResult;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;









    }
}