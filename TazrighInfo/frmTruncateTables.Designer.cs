namespace TazrighInfo
{
    partial class frmTruncateTables
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
            this.lbTables = new System.Windows.Forms.ListBox();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Items.AddRange(new object[] {
            "Orders",
            "Production",
            "Product",
            "Customer",
            "CastFormat",
            "Machine"});
            this.lbTables.Location = new System.Drawing.Point(25, 25);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(129, 95);
            this.lbTables.TabIndex = 0;
            // 
            // btnTruncate
            // 
            this.btnTruncate.Location = new System.Drawing.Point(26, 146);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(127, 26);
            this.btnTruncate.TabIndex = 1;
            this.btnTruncate.Text = "truncate";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // frmTruncateTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTruncate);
            this.Controls.Add(this.lbTables);
            this.Name = "frmTruncateTables";
            this.Text = "frmTruncateTables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTruncateTables_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.Label label1;
    }
}