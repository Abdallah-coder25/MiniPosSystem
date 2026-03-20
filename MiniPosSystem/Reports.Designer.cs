namespace MiniPosSystem
{
    partial class Reports
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
            this.lbReports = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbDate1 = new System.Windows.Forms.Label();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbDataNow = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReports
            // 
            this.lbReports.AutoSize = true;
            this.lbReports.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbReports.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbReports.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbReports.Location = new System.Drawing.Point(28, 25);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(155, 48);
            this.lbReports.TabIndex = 0;
            this.lbReports.Text = "Reports";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFrom.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFrom.Location = new System.Drawing.Point(216, 96);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(55, 24);
            this.lbFrom.TabIndex = 1;
            this.lbFrom.Text = "From";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTo.Location = new System.Drawing.Point(216, 149);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(33, 24);
            this.lbTo.TabIndex = 2;
            this.lbTo.Text = "To";
            // 
            // lbDate1
            // 
            this.lbDate1.AutoSize = true;
            this.lbDate1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDate1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDate1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDate1.Location = new System.Drawing.Point(327, 96);
            this.lbDate1.Name = "lbDate1";
            this.lbDate1.Size = new System.Drawing.Size(53, 24);
            this.lbDate1.TabIndex = 3;
            this.lbDate1.Text = "Date";
            // 
            // lbDate2
            // 
            this.lbDate2.AutoSize = true;
            this.lbDate2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDate2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDate2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDate2.Location = new System.Drawing.Point(327, 149);
            this.lbDate2.Name = "lbDate2";
            this.lbDate2.Size = new System.Drawing.Size(53, 24);
            this.lbDate2.TabIndex = 4;
            this.lbDate2.Text = "Date";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSearch.Location = new System.Drawing.Point(216, 221);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(70, 24);
            this.lbSearch.TabIndex = 6;
            this.lbSearch.Text = "Search";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(220, 302);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(669, 305);
            this.dgv.TabIndex = 8;
            // 
            // lbDataNow
            // 
            this.lbDataNow.AutoSize = true;
            this.lbDataNow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDataNow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDataNow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDataNow.Location = new System.Drawing.Point(433, 149);
            this.lbDataNow.Name = "lbDataNow";
            this.lbDataNow.Size = new System.Drawing.Size(0, 24);
            this.lbDataNow.TabIndex = 9;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDate.Location = new System.Drawing.Point(423, 96);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 24);
            this.lbDate.TabIndex = 10;
            // 
            // txDate
            // 
            this.txDate.Location = new System.Drawing.Point(331, 221);
            this.txDate.Name = "txDate";
            this.txDate.Size = new System.Drawing.Size(157, 27);
            this.txDate.TabIndex = 11;
            this.txDate.Text = "d/mm/yyy";
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txDate.TextChanged += new System.EventHandler(this.txDate_TextChanged);
            this.txDate.Enter += new System.EventHandler(this.txDate_Enter);
            this.txDate.Leave += new System.EventHandler(this.txDate_Leave);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 607);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbDataNow);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbDate2);
            this.Controls.Add(this.lbDate1);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbReports);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReports;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbDate1;
        private System.Windows.Forms.Label lbDate2;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbDataNow;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txDate;
    }
}