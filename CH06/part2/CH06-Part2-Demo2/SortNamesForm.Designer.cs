namespace CH06_Part2_Demo2
{
    partial class SortNamesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare controls based on the image_1.png table
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblResult;

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
            lblPrompt = new Label();
            txtNames = new TextBox();
            btnSort = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(34, 40);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(224, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter names (comma separated)";
            // 
            // txtNames
            // 
            txtNames.Location = new Point(34, 73);
            txtNames.Margin = new Padding(3, 4, 3, 4);
            txtNames.Name = "txtNames";
            txtNames.Size = new Size(342, 27);
            txtNames.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(34, 127);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(114, 40);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort Names";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(34, 187);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(343, 199);
            lblResult.TabIndex = 3;
            // 
            // SortNamesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 428);
            Controls.Add(lblResult);
            Controls.Add(btnSort);
            Controls.Add(txtNames);
            Controls.Add(lblPrompt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SortNamesForm";
            Text = "Name Sorter";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}