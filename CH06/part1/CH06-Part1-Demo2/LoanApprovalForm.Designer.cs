namespace CH06_Part1_Demo2
{
    partial class LoanApprovalForm
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
            label1 = new Label();
            txtCreditScore = new TextBox();
            txtIncome = new TextBox();
            label2 = new Label();
            btnCheck = new Button();
            lblResult = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Credit Score:";
            // 
            // txtCreditScore
            // 
            txtCreditScore.Location = new Point(154, 65);
            txtCreditScore.Name = "txtCreditScore";
            txtCreditScore.Size = new Size(100, 27);
            txtCreditScore.TabIndex = 1;
            txtCreditScore.Click += TextBox_Enter;
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(154, 121);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(100, 27);
            txtIncome.TabIndex = 3;
            txtIncome.Click += TextBox_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 121);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Annual Income:";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(32, 164);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(128, 31);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "&Check Eligibility";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Green;
            lblResult.Location = new Point(102, 223);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(179, 164);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 7;
            button2.Text = "C&lear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoanApprovalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 334);
            Controls.Add(button2);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtIncome);
            Controls.Add(label2);
            Controls.Add(txtCreditScore);
            Controls.Add(label1);
            Name = "LoanApprovalForm";
            Text = "Loan Approval";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCreditScore;
        private TextBox txtIncome;
        private Label label2;
        private Button btnCheck;
        private Label lblResult;
        private Button button2;
    }
}
