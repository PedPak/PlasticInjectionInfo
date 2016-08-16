namespace TazrighInfo
{
    partial class frmManageDatabase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackupFull = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectPath);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.btnBackupFull);
            this.groupBox1.Location = new System.Drawing.Point(199, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پشتيبان گيري";
            // 
            // btnBackupFull
            // 
            this.btnBackupFull.Location = new System.Drawing.Point(460, 64);
            this.btnBackupFull.Name = "btnBackupFull";
            this.btnBackupFull.Size = new System.Drawing.Size(127, 27);
            this.btnBackupFull.TabIndex = 0;
            this.btnBackupFull.Text = "پشتيبان گيري كامل";
            this.btnBackupFull.UseVisualStyleBackColor = true;
            this.btnBackupFull.Click += new System.EventHandler(this.btnBackupFull_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 24);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(103, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "D:\\BackUPDatabase";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(478, 24);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(109, 27);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "انتخاب مسير";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // frmManageDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 266);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDatabase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مديريت پايگاه داده";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageDatabase_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackupFull;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}