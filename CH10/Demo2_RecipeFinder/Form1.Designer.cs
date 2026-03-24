namespace Demo2_RecipeFinder
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
            this.lblCategories = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategories.Location = new System.Drawing.Point(20, 15);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(180, 20);
            this.lblCategories.Text = "Select Recipe Categories:";
            // 
            // lstCategories
            // 
            this.lstCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCategories.Location = new System.Drawing.Point(20, 45);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCategories.Size = new System.Drawing.Size(300, 160);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(20, 220);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(300, 40);
            this.btnSearch.Text = "Find Recipes";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lblInstructions.Location = new System.Drawing.Point(20, 270);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(300, 20);
            this.lblInstructions.Text = "Hold Ctrl to select multiple categories.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 300);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInstructions;
    }
}
