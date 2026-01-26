namespace CH08_Demo4
{
    partial class ProductCatalogSearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSearchTerm = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            lblProductName = new Label();
            lblCatLabel = new Label();
            lblCategory = new Label();
            lblPriceLabel = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblSearchTerm
            // 
            lblSearchTerm.AutoSize = true;
            lblSearchTerm.Location = new Point(26, 48);
            lblSearchTerm.Name = "lblSearchTerm";
            lblSearchTerm.Size = new Size(131, 20);
            lblSearchTerm.TabIndex = 0;
            lblSearchTerm.Text = "Enter Search Term:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(184, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(184, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 162);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Product:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(122, 162);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(50, 20);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "label2";
            // 
            // lblCatLabel
            // 
            lblCatLabel.AutoSize = true;
            lblCatLabel.Location = new Point(25, 198);
            lblCatLabel.Name = "lblCatLabel";
            lblCatLabel.Size = new Size(72, 20);
            lblCatLabel.TabIndex = 5;
            lblCatLabel.Text = "Category:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(122, 198);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(50, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "label2";
            // 
            // lblPriceLabel
            // 
            lblPriceLabel.AutoSize = true;
            lblPriceLabel.Location = new Point(26, 237);
            lblPriceLabel.Name = "lblPriceLabel";
            lblPriceLabel.Size = new Size(44, 20);
            lblPriceLabel.TabIndex = 7;
            lblPriceLabel.Text = "Price:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(122, 237);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "label2";
            // 
            // ProductCatalogSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice);
            Controls.Add(lblPriceLabel);
            Controls.Add(lblCategory);
            Controls.Add(lblCatLabel);
            Controls.Add(lblProductName);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearchTerm);
            Name = "ProductCatalogSearchForm";
            Text = "Product Catalog Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchTerm;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Label lblProductName;
        private Label lblCatLabel;
        private Label lblCategory;
        private Label lblPriceLabel;
        private Label lblPrice;
    }
}
