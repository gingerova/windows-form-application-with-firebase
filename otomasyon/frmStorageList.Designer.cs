namespace otomasyon
{
    partial class frmStorageList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.storageName,
            this.storageUnit,
            this.storageBuyingPrice,
            this.storageSellingPrice,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "StorageId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // storageName
            // 
            this.storageName.HeaderText = "Storage Name";
            this.storageName.Name = "storageName";
            this.storageName.ReadOnly = true;
            this.storageName.Width = 200;
            // 
            // storageUnit
            // 
            this.storageUnit.HeaderText = "Storage Unit";
            this.storageUnit.Name = "storageUnit";
            this.storageUnit.ReadOnly = true;
            // 
            // storageBuyingPrice
            // 
            this.storageBuyingPrice.HeaderText = "Storage Buying Price";
            this.storageBuyingPrice.Name = "storageBuyingPrice";
            this.storageBuyingPrice.ReadOnly = true;
            // 
            // storageSellingPrice
            // 
            this.storageSellingPrice.HeaderText = "Storage Selling Prce";
            this.storageSellingPrice.Name = "storageSellingPrice";
            this.storageSellingPrice.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Storage Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 200;
            // 
            // frmStorageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStorageList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStorageList";
            this.Load += new System.EventHandler(this.frmStorageList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageBuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}