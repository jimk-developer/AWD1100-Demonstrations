namespace Demo1
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
            lblCreditScore = new Label();
            txtCreditScore = new TextBox();
            lblIncome = new Label();
            txtIncome = new TextBox();
            btnCheckLoan = new Button();
            lblErrorResult = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblCreditScore
            // 
            lblCreditScore.AutoSize = true;
            lblCreditScore.Location = new Point(12, 34);
            lblCreditScore.Name = "lblCreditScore";
            lblCreditScore.Size = new Size(90, 20);
            lblCreditScore.TabIndex = 0;
            lblCreditScore.Text = "Credit Score";
            // 
            // txtCreditScore
            // 
            txtCreditScore.Location = new Point(125, 34);
            txtCreditScore.Name = "txtCreditScore";
            txtCreditScore.Size = new Size(100, 27);
            txtCreditScore.TabIndex = 1;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(266, 34);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(108, 20);
            lblIncome.TabIndex = 2;
            lblIncome.Text = "Annual Income";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(380, 34);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(100, 27);
            txtIncome.TabIndex = 3;
            // 
            // btnCheckLoan
            // 
            btnCheckLoan.Location = new Point(199, 95);
            btnCheckLoan.Name = "btnCheckLoan";
            btnCheckLoan.Size = new Size(121, 36);
            btnCheckLoan.TabIndex = 4;
            btnCheckLoan.Text = "Check Elgibility";
            btnCheckLoan.UseVisualStyleBackColor = true;
            btnCheckLoan.Click += btnCheckLoan_Click;
            // 
            // lblErrorResult
            // 
            lblErrorResult.Location = new Point(12, 190);
            lblErrorResult.Name = "lblErrorResult";
            lblErrorResult.Size = new Size(468, 20);
            lblErrorResult.TabIndex = 5;
            lblErrorResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(230, 153);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(lblResult);
            Controls.Add(lblErrorResult);
            Controls.Add(btnCheckLoan);
            Controls.Add(txtIncome);
            Controls.Add(lblIncome);
            Controls.Add(txtCreditScore);
            Controls.Add(lblCreditScore);
            Name = "Form1";
            Text = "Loan Approval";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreditScore;
        private TextBox txtCreditScore;
        private Label lblIncome;
        private TextBox txtIncome;
        private Button btnCheckLoan;
        private Label lblErrorResult;
        private Label lblResult;
    }
}
