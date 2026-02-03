namespace CH06_Part1_Demo4
{
    partial class FlooringCostEstimatorForm
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
            lblLengthPrompt = new Label();
            txtLength = new TextBox();
            lblWidthPrompt = new Label();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            label1 = new Label();
            lblArea = new Label();
            label3 = new Label();
            lblCost = new Label();
            SuspendLayout();
            // 
            // lblLengthPrompt
            // 
            lblLengthPrompt.AutoSize = true;
            lblLengthPrompt.Location = new Point(40, 47);
            lblLengthPrompt.Name = "lblLengthPrompt";
            lblLengthPrompt.Size = new Size(125, 20);
            lblLengthPrompt.TabIndex = 0;
            lblLengthPrompt.Text = "Room Length (ft):";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(183, 47);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 27);
            txtLength.TabIndex = 1;
            // 
            // lblWidthPrompt
            // 
            lblWidthPrompt.AutoSize = true;
            lblWidthPrompt.Location = new Point(40, 90);
            lblWidthPrompt.Name = "lblWidthPrompt";
            lblWidthPrompt.Size = new Size(120, 20);
            lblWidthPrompt.TabIndex = 2;
            lblWidthPrompt.Text = "Room Width (ft):";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(183, 90);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 27);
            txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(183, 137);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(90, 32);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 212);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "Total Area:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(183, 212);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(50, 20);
            lblArea.TabIndex = 6;
            lblArea.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 247);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 7;
            label3.Text = "Estimated Cost:";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(183, 247);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(50, 20);
            lblCost.TabIndex = 8;
            lblCost.Text = "label4";
            // 
            // FlooringCostEstimatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCost);
            Controls.Add(label3);
            Controls.Add(lblArea);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(lblWidthPrompt);
            Controls.Add(txtLength);
            Controls.Add(lblLengthPrompt);
            Name = "FlooringCostEstimatorForm";
            Text = "Flooring Cost Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLengthPrompt;
        private TextBox txtLength;
        private Label lblWidthPrompt;
        private TextBox txtWidth;
        private Button btnCalculate;
        private Label label1;
        private Label lblArea;
        private Label label3;
        private Label lblCost;
    }
}
