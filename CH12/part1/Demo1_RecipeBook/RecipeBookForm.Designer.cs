namespace Demo1_RecipeBook
{
    partial class RecipeBookForm
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblIngredientsPrompt = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.lblInstructionsPrompt = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrompt.Location = new System.Drawing.Point(20, 20);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(130, 19);
            this.lblPrompt.Text = "Enter Recipe Name:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRecipeName.Location = new System.Drawing.Point(20, 45);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(250, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(280, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblIngredientsPrompt
            // 
            this.lblIngredientsPrompt.AutoSize = true;
            this.lblIngredientsPrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIngredientsPrompt.Location = new System.Drawing.Point(20, 85);
            this.lblIngredientsPrompt.Name = "lblIngredientsPrompt";
            this.lblIngredientsPrompt.Size = new System.Drawing.Size(80, 19);
            this.lblIngredientsPrompt.Text = "Ingredients:";
            this.lblIngredientsPrompt.Visible = false;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIngredients.Location = new System.Drawing.Point(20, 107);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIngredients.Size = new System.Drawing.Size(360, 80);
            this.txtIngredients.Visible = false;
            // 
            // lblInstructionsPrompt
            // 
            this.lblInstructionsPrompt.AutoSize = true;
            this.lblInstructionsPrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstructionsPrompt.Location = new System.Drawing.Point(20, 195);
            this.lblInstructionsPrompt.Name = "lblInstructionsPrompt";
            this.lblInstructionsPrompt.Size = new System.Drawing.Size(83, 19);
            this.lblInstructionsPrompt.Text = "Instructions:";
            this.lblInstructionsPrompt.Visible = false;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInstructions.Location = new System.Drawing.Point(20, 217);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstructions.Size = new System.Drawing.Size(360, 80);
            this.txtInstructions.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(20, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.Text = "Add Recipe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResult.Location = new System.Drawing.Point(400, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(350, 350);
            this.lblResult.Text = "Enter a recipe name to search...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 390);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblIngredientsPrompt);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lblInstructionsPrompt);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo 1: Recipe Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblIngredientsPrompt;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Label lblInstructionsPrompt;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
    }
}
