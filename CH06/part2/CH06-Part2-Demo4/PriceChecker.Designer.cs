namespace CH06_Part2_Demo4
{
    partial class PriceChecker
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
            txtPrice1 = new TextBox();
            txtPrice2 = new TextBox();
            txtPrice3 = new TextBox();
            txtPrice4 = new TextBox();
            txtPrice5 = new TextBox();
            lblError1 = new Label();
            lblError2 = new Label();
            lblError3 = new Label();
            lblError4 = new Label();
            lblError5 = new Label();
            lblCheapest = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblMostExpensive = new Label();
            lblAverage = new Label();
            btnAnalyze = new Button();
            SuspendLayout();
            // 
            // txtPrice1
            // 
            txtPrice1.Location = new Point(56, 66);
            txtPrice1.Name = "txtPrice1";
            txtPrice1.Size = new Size(100, 27);
            txtPrice1.TabIndex = 1;
            // 
            // txtPrice2
            // 
            txtPrice2.Location = new Point(195, 66);
            txtPrice2.Name = "txtPrice2";
            txtPrice2.Size = new Size(100, 27);
            txtPrice2.TabIndex = 2;
            // 
            // txtPrice3
            // 
            txtPrice3.Location = new Point(325, 66);
            txtPrice3.Name = "txtPrice3";
            txtPrice3.Size = new Size(100, 27);
            txtPrice3.TabIndex = 3;
            // 
            // txtPrice4
            // 
            txtPrice4.Location = new Point(468, 66);
            txtPrice4.Name = "txtPrice4";
            txtPrice4.Size = new Size(100, 27);
            txtPrice4.TabIndex = 4;
            // 
            // txtPrice5
            // 
            txtPrice5.Location = new Point(598, 66);
            txtPrice5.Name = "txtPrice5";
            txtPrice5.Size = new Size(100, 27);
            txtPrice5.TabIndex = 5;
            // 
            // lblError1
            // 
            lblError1.AutoSize = true;
            lblError1.Location = new Point(56, 107);
            lblError1.Name = "lblError1";
            lblError1.Size = new Size(0, 20);
            lblError1.TabIndex = 5;
            // 
            // lblError2
            // 
            lblError2.AutoSize = true;
            lblError2.Location = new Point(195, 107);
            lblError2.Name = "lblError2";
            lblError2.Size = new Size(0, 20);
            lblError2.TabIndex = 6;
            // 
            // lblError3
            // 
            lblError3.AutoSize = true;
            lblError3.Location = new Point(340, 107);
            lblError3.Name = "lblError3";
            lblError3.Size = new Size(0, 20);
            lblError3.TabIndex = 7;
            // 
            // lblError4
            // 
            lblError4.AutoSize = true;
            lblError4.Location = new Point(478, 107);
            lblError4.Name = "lblError4";
            lblError4.Size = new Size(0, 20);
            lblError4.TabIndex = 8;
            // 
            // lblError5
            // 
            lblError5.AutoSize = true;
            lblError5.Location = new Point(627, 107);
            lblError5.Name = "lblError5";
            lblError5.Size = new Size(0, 20);
            lblError5.TabIndex = 9;
            // 
            // lblCheapest
            // 
            lblCheapest.AutoSize = true;
            lblCheapest.Location = new Point(195, 242);
            lblCheapest.Name = "lblCheapest";
            lblCheapest.Size = new Size(0, 20);
            lblCheapest.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 242);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = "Cheapest:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 286);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 12;
            label2.Text = "Most Expensive:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 330);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 13;
            label3.Text = "Average:";
            // 
            // lblMostExpensive
            // 
            lblMostExpensive.AutoSize = true;
            lblMostExpensive.Location = new Point(195, 286);
            lblMostExpensive.Name = "lblMostExpensive";
            lblMostExpensive.Size = new Size(0, 20);
            lblMostExpensive.TabIndex = 8;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(195, 330);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(0, 20);
            lblAverage.TabIndex = 9;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(340, 144);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(85, 37);
            btnAnalyze.TabIndex = 6;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // PriceChecker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnalyze);
            Controls.Add(lblAverage);
            Controls.Add(lblMostExpensive);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCheapest);
            Controls.Add(lblError5);
            Controls.Add(lblError4);
            Controls.Add(lblError3);
            Controls.Add(lblError2);
            Controls.Add(lblError1);
            Controls.Add(txtPrice5);
            Controls.Add(txtPrice4);
            Controls.Add(txtPrice3);
            Controls.Add(txtPrice2);
            Controls.Add(txtPrice1);
            Name = "PriceChecker";
            Text = "Price Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrice1;
        private TextBox txtPrice2;
        private TextBox txtPrice3;
        private TextBox txtPrice4;
        private TextBox txtPrice5;
        private Label lblError1;
        private Label lblError2;
        private Label lblError3;
        private Label lblError4;
        private Label lblError5;
        private Label lblCheapest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMostExpensive;
        private Label lblAverage;
        private Button btnAnalyze;
    }
}
