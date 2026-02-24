namespace Demo3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpSearch = new GroupBox();
            lblSearchPrompt = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            grpFilter = new GroupBox();
            lblType = new Label();
            cmbType = new ComboBox();
            btnFilterByType = new Button();
            btnShowAll = new Button();
            grpResults = new GroupBox();
            lblResult = new Label();
            lblTitle = new Label();
            grpSearch.SuspendLayout();
            grpFilter.SuspendLayout();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(lblSearchPrompt);
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Font = new Font("Segoe UI", 10F);
            grpSearch.Location = new Point(20, 55);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(280, 120);
            grpSearch.TabIndex = 1;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search Hero";
            // 
            // lblSearchPrompt
            // 
            lblSearchPrompt.AutoSize = true;
            lblSearchPrompt.Location = new Point(15, 30);
            lblSearchPrompt.Name = "lblSearchPrompt";
            lblSearchPrompt.Size = new Size(118, 19);
            lblSearchPrompt.TabIndex = 0;
            lblSearchPrompt.Text = "Enter Hero Name:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 25);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(15, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(lblType);
            grpFilter.Controls.Add(cmbType);
            grpFilter.Controls.Add(btnFilterByType);
            grpFilter.Controls.Add(btnShowAll);
            grpFilter.Font = new Font("Segoe UI", 10F);
            grpFilter.Location = new Point(20, 185);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(280, 130);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter by Type";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(15, 30);
            lblType.Name = "lblType";
            lblType.Size = new Size(74, 19);
            lblType.TabIndex = 0;
            lblType.Text = "Hero Type:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(15, 52);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 25);
            cmbType.TabIndex = 1;
            // 
            // btnFilterByType
            // 
            btnFilterByType.Location = new Point(15, 90);
            btnFilterByType.Name = "btnFilterByType";
            btnFilterByType.Size = new Size(100, 30);
            btnFilterByType.TabIndex = 2;
            btnFilterByType.Text = "Filter";
            btnFilterByType.UseVisualStyleBackColor = true;
            btnFilterByType.Click += btnFilterByType_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(125, 90);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(140, 30);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Show All Heroes";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblResult);
            grpResults.Font = new Font("Segoe UI", 10F);
            grpResults.Location = new Point(320, 55);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(420, 500);
            grpResults.TabIndex = 3;
            grpResults.TabStop = false;
            grpResults.Text = "Hero Information";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Consolas", 10F);
            lblResult.Location = new Point(14, 21);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(400, 476);
            lblResult.TabIndex = 0;
            lblResult.Text = resources.GetString("lblResult.Text");
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Superhero Database";
            // 
            // Form1
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 567);
            Controls.Add(lblTitle);
            Controls.Add(grpSearch);
            Controls.Add(grpFilter);
            Controls.Add(grpResults);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demo 3: Superhero Database";
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            grpResults.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchPrompt;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnFilterByType;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox grpResults;
        private Label lblResult;
    }
}