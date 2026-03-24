namespace Demo4_ProductSearch
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSearchBySku = new System.Windows.Forms.Label();
            this.txtSearchSku = new System.Windows.Forms.TextBox();
            this.btnSearchSku = new System.Windows.Forms.Button();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblSku = new System.Windows.Forms.Label();
            this.lblSkuValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchBySku
            // 
            this.lblSearchBySku.AutoSize = true;
            this.lblSearchBySku.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchBySku.Location = new System.Drawing.Point(20, 20);
            this.lblSearchBySku.Name = "lblSearchBySku";
            this.lblSearchBySku.Size = new System.Drawing.Size(105, 19);
            this.lblSearchBySku.Text = "Search by SKU:";
            // 
            // txtSearchSku
            // 
            this.txtSearchSku.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchSku.Location = new System.Drawing.Point(20, 45);
            this.txtSearchSku.Name = "txtSearchSku";
            this.txtSearchSku.Size = new System.Drawing.Size(310, 25);
            // 
            // btnSearchSku
            // 
            this.btnSearchSku.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchSku.Location = new System.Drawing.Point(340, 43);
            this.btnSearchSku.Name = "btnSearchSku";
            this.btnSearchSku.Size = new System.Drawing.Size(100, 30);
            this.btnSearchSku.Text = "Search";
            this.btnSearchSku.Click += new System.EventHandler(this.btnSearchSku_Click);
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchByName.Location = new System.Drawing.Point(20, 85);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(119, 19);
            this.lblSearchByName.Text = "Search by Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchName.Location = new System.Drawing.Point(20, 110);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(310, 25);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchName.Location = new System.Drawing.Point(340, 108);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(100, 30);
            this.btnSearchName.Text = "Search";
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblSku);
            this.grpResults.Controls.Add(this.lblSkuValue);
            this.grpResults.Controls.Add(this.lblName);
            this.grpResults.Controls.Add(this.lblNameValue);
            this.grpResults.Controls.Add(this.lblBrand);
            this.grpResults.Controls.Add(this.lblBrandValue);
            this.grpResults.Controls.Add(this.lblPrice);
            this.grpResults.Controls.Add(this.lblPriceValue);
            this.grpResults.Controls.Add(this.lblQuantity);
            this.grpResults.Controls.Add(this.lblQuantityValue);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpResults.Location = new System.Drawing.Point(20, 155);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(420, 210);
            this.grpResults.Text = "Product Details";
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSku.Location = new System.Drawing.Point(15, 35);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(38, 19);
            this.lblSku.Text = "SKU:";
            // 
            // lblSkuValue
            // 
            this.lblSkuValue.AutoSize = true;
            this.lblSkuValue.Location = new System.Drawing.Point(130, 35);
            this.lblSkuValue.Name = "lblSkuValue";
            this.lblSkuValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(15, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 19);
            this.lblName.Text = "Name:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(130, 70);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(15, 105);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(51, 19);
            this.lblBrand.Text = "Brand:";
            // 
            // lblBrandValue
            // 
            this.lblBrandValue.AutoSize = true;
            this.lblBrandValue.Location = new System.Drawing.Point(130, 105);
            this.lblBrandValue.Name = "lblBrandValue";
            this.lblBrandValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(15, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 19);
            this.lblPrice.Text = "Price:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(130, 140);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(0, 19);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(15, 175);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 19);
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Location = new System.Drawing.Point(130, 175);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(0, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 385);
            this.Controls.Add(this.lblSearchBySku);
            this.Controls.Add(this.txtSearchSku);
            this.Controls.Add(this.btnSearchSku);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.grpResults);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSearchBySku;
        private System.Windows.Forms.TextBox txtSearchSku;
        private System.Windows.Forms.Button btnSearchSku;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.Label lblSkuValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityValue;
    }
}
