namespace TazrighInfo
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.شناسهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مشتريDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.قالبDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.قطعهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tazrighBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new TazrighInfo.DataSet1();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tazrighBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tazrighCustomerDataSet = new TazrighInfo.TazrighCustomerDataSet();
            this.tazrighTableAdapter = new TazrighInfo.TazrighCustomerDataSetTableAdapters.TazrighTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tazrighBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tazrighBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tazrighCustomerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.شناسهDataGridViewTextBoxColumn,
            this.مشتريDataGridViewTextBoxColumn,
            this.قالبDataGridViewTextBoxColumn,
            this.قطعهDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tazrighBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // شناسهDataGridViewTextBoxColumn
            // 
            this.شناسهDataGridViewTextBoxColumn.DataPropertyName = "شناسه";
            this.شناسهDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.شناسهDataGridViewTextBoxColumn.Name = "شناسهDataGridViewTextBoxColumn";
            // 
            // مشتريDataGridViewTextBoxColumn
            // 
            this.مشتريDataGridViewTextBoxColumn.DataPropertyName = "مشتري";
            this.مشتريDataGridViewTextBoxColumn.HeaderText = "مشتري";
            this.مشتريDataGridViewTextBoxColumn.Name = "مشتريDataGridViewTextBoxColumn";
            // 
            // قالبDataGridViewTextBoxColumn
            // 
            this.قالبDataGridViewTextBoxColumn.DataPropertyName = "قالب";
            this.قالبDataGridViewTextBoxColumn.HeaderText = "قالب";
            this.قالبDataGridViewTextBoxColumn.Name = "قالبDataGridViewTextBoxColumn";
            // 
            // قطعهDataGridViewTextBoxColumn
            // 
            this.قطعهDataGridViewTextBoxColumn.DataPropertyName = "قطعه";
            this.قطعهDataGridViewTextBoxColumn.HeaderText = "قطعه";
            this.قطعهDataGridViewTextBoxColumn.Name = "قطعهDataGridViewTextBoxColumn";
            // 
            // tazrighBindingSource
            // 
            this.tazrighBindingSource.DataMember = "Tazrigh";
            this.tazrighBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT     ID AS شناسه, Customer AS مشتري, CastFormat AS قالب, ProductName AS قطع" +
                "ه\r\nFROM         Tazrigh";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Tazrigh.accdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Tazrigh` (`Customer`, `CastFormat`, `ProductName`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("مشتري", System.Data.OleDb.OleDbType.VarWChar, 0, "مشتري"),
            new System.Data.OleDb.OleDbParameter("قالب", System.Data.OleDb.OleDbType.VarWChar, 0, "قالب"),
            new System.Data.OleDb.OleDbParameter("قطعه", System.Data.OleDb.OleDbType.VarWChar, 0, "قطعه")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("مشتري", System.Data.OleDb.OleDbType.VarWChar, 0, "مشتري"),
            new System.Data.OleDb.OleDbParameter("قالب", System.Data.OleDb.OleDbType.VarWChar, 0, "قالب"),
            new System.Data.OleDb.OleDbParameter("قطعه", System.Data.OleDb.OleDbType.VarWChar, 0, "قطعه"),
            new System.Data.OleDb.OleDbParameter("Original_شناسه", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "شناسه", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_مشتري", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "مشتري", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_مشتري", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "مشتري", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_قالب", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "قالب", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_قالب", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "قالب", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_قطعه", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "قطعه", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_قطعه", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "قطعه", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_شناسه", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "شناسه", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_مشتري", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "مشتري", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_مشتري", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "مشتري", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_قالب", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "قالب", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_قالب", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "قالب", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_قطعه", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "قطعه", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_قطعه", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "قطعه", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tazrigh", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("شناسه", "شناسه"),
                        new System.Data.Common.DataColumnMapping("مشتري", "مشتري"),
                        new System.Data.Common.DataColumnMapping("قالب", "قالب"),
                        new System.Data.Common.DataColumnMapping("قطعه", "قطعه")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tazrighBindingSource1;
            this.comboBox1.DisplayMember = "Customer";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID";
            // 
            // tazrighBindingSource1
            // 
            this.tazrighBindingSource1.DataMember = "Tazrigh";
            this.tazrighBindingSource1.DataSource = this.tazrighCustomerDataSet;
            // 
            // tazrighCustomerDataSet
            // 
            this.tazrighCustomerDataSet.DataSetName = "TazrighCustomerDataSet";
            this.tazrighCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tazrighTableAdapter
            // 
            this.tazrighTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tazrighBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tazrighBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tazrighCustomerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tazrighBindingSource;
        private DataSet1 dataSet11;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private TazrighCustomerDataSet tazrighCustomerDataSet;
        private System.Windows.Forms.BindingSource tazrighBindingSource1;
        private TazrighCustomerDataSetTableAdapters.TazrighTableAdapter tazrighTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn شناسهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مشتريDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn قالبDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn قطعهDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}