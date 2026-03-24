namespace Demo6_InventoryTracker
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
            this.grpAddItem = new System.Windows.Forms.GroupBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpRemove = new System.Windows.Forms.GroupBox();
            this.lblRemoveId = new System.Windows.Forms.Label();
            this.txtRemoveId = new System.Windows.Forms.TextBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.rtbInventory = new System.Windows.Forms.RichTextBox();
            this.grpAddItem.SuspendLayout();
            this.grpRemove.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddItem
            // 
            this.grpAddItem.Controls.Add(this.lblItemId);
            this.grpAddItem.Controls.Add(this.txtItemId);
            this.grpAddItem.Controls.Add(this.lblItemName);
            this.grpAddItem.Controls.Add(this.txtItemName);
            this.grpAddItem.Controls.Add(this.lblCategory);
            this.grpAddItem.Controls.Add(this.txtCategory);
            this.grpAddItem.Controls.Add(this.lblPrice);
            this.grpAddItem.Controls.Add(this.txtPrice);
            this.grpAddItem.Controls.Add(this.lblStock);
            this.grpAddItem.Controls.Add(this.txtStock);
            this.grpAddItem.Controls.Add(this.btnAddItem);
            this.grpAddItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpAddItem.Location = new System.Drawing.Point(15, 10);
            this.grpAddItem.Name = "grpAddItem";
            this.grpAddItem.Size = new System.Drawing.Size(280, 225);
            this.grpAddItem.Text = "Add New Item";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(10, 25);
            this.lblItemId.Text = "Item ID:";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(85, 22);
            this.txtItemId.Size = new System.Drawing.Size(180, 23);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(10, 55);
            this.lblItemName.Text = "Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(85, 52);
            this.txtItemName.Size = new System.Drawing.Size(180, 23);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(10, 85);
            this.lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(85, 82);
            this.txtCategory.Size = new System.Drawing.Size(180, 23);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 115);
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 112);
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(10, 145);
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(85, 142);
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(85, 180);
            this.btnAddItem.Size = new System.Drawing.Size(180, 30);
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grpRemove
            // 
            this.grpRemove.Controls.Add(this.lblRemoveId);
            this.grpRemove.Controls.Add(this.txtRemoveId);
            this.grpRemove.Controls.Add(this.btnRemoveItem);
            this.grpRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpRemove.Location = new System.Drawing.Point(15, 245);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Size = new System.Drawing.Size(280, 65);
            this.grpRemove.Text = "Remove Item";
            // 
            // lblRemoveId
            // 
            this.lblRemoveId.AutoSize = true;
            this.lblRemoveId.Location = new System.Drawing.Point(10, 28);
            this.lblRemoveId.Text = "Item ID:";
            // 
            // txtRemoveId
            // 
            this.txtRemoveId.Location = new System.Drawing.Point(70, 25);
            this.txtRemoveId.Size = new System.Drawing.Size(100, 23);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(180, 23);
            this.btnRemoveItem.Size = new System.Drawing.Size(85, 27);
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchId);
            this.grpSearch.Controls.Add(this.txtSearchId);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblSearchResult);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpSearch.Location = new System.Drawing.Point(15, 320);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(280, 90);
            this.grpSearch.Text = "Search by ID";
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Location = new System.Drawing.Point(10, 28);
            this.lblSearchId.Text = "Item ID:";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(70, 25);
            this.txtSearchId.Size = new System.Drawing.Size(100, 23);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(180, 23);
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblSearchResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSearchResult.Location = new System.Drawing.Point(10, 58);
            this.lblSearchResult.Size = new System.Drawing.Size(260, 25);
            // 
            // rtbInventory
            // 
            this.rtbInventory.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbInventory.Location = new System.Drawing.Point(310, 10);
            this.rtbInventory.ReadOnly = true;
            this.rtbInventory.Size = new System.Drawing.Size(365, 400);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 425);
            this.Controls.Add(this.grpAddItem);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.rtbInventory);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddItem.ResumeLayout(false);
            this.grpAddItem.PerformLayout();
            this.grpRemove.ResumeLayout(false);
            this.grpRemove.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddItem;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox grpRemove;
        private System.Windows.Forms.Label lblRemoveId;
        private System.Windows.Forms.TextBox txtRemoveId;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.RichTextBox rtbInventory;
    }
}
