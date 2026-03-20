namespace MiniPosSystem
{
    partial class Update
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
            this.txName = new System.Windows.Forms.TextBox();
            this.lbEdit = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lnbSet = new System.Windows.Forms.LinkLabel();
            this.lnbRemove = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(180, 115);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(161, 27);
            this.txName.TabIndex = 0;
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Font = new System.Drawing.Font("Trebuchet MS", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbEdit.Location = new System.Drawing.Point(252, 23);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(285, 55);
            this.lbEdit.TabIndex = 1;
            this.lbEdit.Text = "Edit Product";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbName.Location = new System.Drawing.Point(12, 116);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 26);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Product Name";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(180, 184);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(161, 27);
            this.txPrice.TabIndex = 1;
            // 
            // txQuantity
            // 
            this.txQuantity.Location = new System.Drawing.Point(180, 245);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(161, 27);
            this.txQuantity.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPrice.Location = new System.Drawing.Point(12, 185);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(61, 26);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbQuantity.Location = new System.Drawing.Point(12, 246);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(97, 26);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(577, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(262, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(451, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lnbSet
            // 
            this.lnbSet.AutoSize = true;
            this.lnbSet.Location = new System.Drawing.Point(577, 68);
            this.lnbSet.Name = "lnbSet";
            this.lnbSet.Size = new System.Drawing.Size(81, 19);
            this.lnbSet.TabIndex = 12;
            this.lnbSet.TabStop = true;
            this.lnbSet.Text = "Set Image";
            this.lnbSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnbSet_LinkClicked);
            // 
            // lnbRemove
            // 
            this.lnbRemove.AutoSize = true;
            this.lnbRemove.Location = new System.Drawing.Point(672, 68);
            this.lnbRemove.Name = "lnbRemove";
            this.lnbRemove.Size = new System.Drawing.Size(116, 19);
            this.lnbRemove.TabIndex = 13;
            this.lnbRemove.TabStop = true;
            this.lnbRemove.Text = "Remove Image";
            this.lnbRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnbRemove_LinkClicked);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnbRemove);
            this.Controls.Add(this.lnbSet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txQuantity);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEdit);
            this.Controls.Add(this.txName);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel lnbSet;
        private System.Windows.Forms.LinkLabel lnbRemove;
    }
}