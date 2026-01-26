namespace CH08_Demo1
{
    partial class ShippingRateForm
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
            lblPrompt = new Label();
            txtWeight = new TextBox();
            btnCalculate = new Button();
            lblRateLabel = new Label();
            lblRate = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(46, 75);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(150, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Package Weight (lbs):";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(215, 75);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 27);
            txtWeight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(215, 120);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(88, 30);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblRateLabel
            // 
            lblRateLabel.AutoSize = true;
            lblRateLabel.Location = new Point(46, 190);
            lblRateLabel.Name = "lblRateLabel";
            lblRateLabel.Size = new Size(105, 20);
            lblRateLabel.TabIndex = 3;
            lblRateLabel.Text = "Shipping Rate:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(171, 190);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(50, 20);
            lblRate.TabIndex = 4;
            lblRate.Text = "label2";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(345, 75);
            lblError.Name = "lblError";
            lblError.Size = new Size(50, 20);
            lblError.TabIndex = 5;
            lblError.Text = "label3";
            // 
            // ShippingRateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lblRate);
            Controls.Add(lblRateLabel);
            Controls.Add(btnCalculate);
            Controls.Add(txtWeight);
            Controls.Add(lblPrompt);
            Name = "ShippingRateForm";
            Text = "Shipping Rate Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtWeight;
        private Button btnCalculate;
        private Label lblRateLabel;
        private Label lblRate;
        private Label lblError;
    }
}
