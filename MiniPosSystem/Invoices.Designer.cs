namespace MiniPosSystem
{
    partial class Invoices
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
            this.lbCreate = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.txQuan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCreate.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCreate.Location = new System.Drawing.Point(45, 18);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(274, 48);
            this.lbCreate.TabIndex = 0;
            this.lbCreate.Text = "Create Invoice";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbQuantity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbQuantity.Location = new System.Drawing.Point(57, 149);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(118, 29);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity :";
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProducts.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbProducts.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbProducts.Location = new System.Drawing.Point(57, 89);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(109, 29);
            this.lbProducts.TabIndex = 2;
            this.lbProducts.Text = "Product :";
            // 
            // cbProd
            // 
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(249, 89);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(150, 27);
            this.cbProd.TabIndex = 3;
            // 
            // txQuan
            // 
            this.txQuan.Location = new System.Drawing.Point(249, 149);
            this.txQuan.Name = "txQuan";
            this.txQuan.Size = new System.Drawing.Size(150, 27);
            this.txQuan.TabIndex = 4;
            this.txQuan.Validating += new System.ComponentModel.CancelEventHandler(this.txQuan_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(62, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add To Invoice";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProduct,
            this.clPrice,
            this.clQuantity,
            this.clSubTotal,
            this.clIdProd});
            this.dataGridView1.Location = new System.Drawing.Point(53, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 227);
            this.dataGridView1.TabIndex = 6;
            // 
            // clProduct
            // 
            this.clProduct.HeaderText = "Product";
            this.clProduct.MinimumWidth = 8;
            this.clProduct.Name = "clProduct";
            this.clProduct.ReadOnly = true;
            this.clProduct.Width = 150;
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Price";
            this.clPrice.MinimumWidth = 8;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 150;
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Quantity";
            this.clQuantity.MinimumWidth = 8;
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.ReadOnly = true;
            this.clQuantity.Width = 150;
            // 
            // clSubTotal
            // 
            this.clSubTotal.HeaderText = "SubTotal";
            this.clSubTotal.MinimumWidth = 8;
            this.clSubTotal.Name = "clSubTotal";
            this.clSubTotal.ReadOnly = true;
            this.clSubTotal.Width = 150;
            // 
            // clIdProd
            // 
            this.clIdProd.HeaderText = "id";
            this.clIdProd.MinimumWidth = 8;
            this.clIdProd.Name = "clIdProd";
            this.clIdProd.ReadOnly = true;
            this.clIdProd.Visible = false;
            this.clIdProd.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(1022, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTotal.Location = new System.Drawing.Point(58, 566);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 24);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 637);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txQuan);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbCreate);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.TextBox txQuan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdProd;
    }
}