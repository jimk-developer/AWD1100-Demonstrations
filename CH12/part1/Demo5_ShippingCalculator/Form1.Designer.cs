namespace Demo5_ShippingCalculator
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
            this.lblDescPrompt = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblWeightPrompt = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.lblRatePrompt = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRateUnit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 25);
            this.lblTitle.Text = "Shipping Calculator";
            // 
            // lblDescPrompt
            // 
            this.lblDescPrompt.AutoSize = true;
            this.lblDescPrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescPrompt.Location = new System.Drawing.Point(20, 55);
            this.lblDescPrompt.Name = "lblDescPrompt";
            this.lblDescPrompt.Size = new System.Drawing.Size(81, 19);
            this.lblDescPrompt.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(20, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 25);
            // 
            // lblWeightPrompt
            // 
            this.lblWeightPrompt.AutoSize = true;
            this.lblWeightPrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeightPrompt.Location = new System.Drawing.Point(20, 115);
            this.lblWeightPrompt.Name = "lblWeightPrompt";
            this.lblWeightPrompt.Size = new System.Drawing.Size(54, 19);
            this.lblWeightPrompt.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWeight.Location = new System.Drawing.Point(20, 137);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 25);
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeightUnit.Location = new System.Drawing.Point(125, 140);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(25, 19);
            this.lblWeightUnit.Text = "lbs";
            // 
            // lblRatePrompt
            // 
            this.lblRatePrompt.AutoSize = true;
            this.lblRatePrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRatePrompt.Location = new System.Drawing.Point(20, 175);
            this.lblRatePrompt.Name = "lblRatePrompt";
            this.lblRatePrompt.Size = new System.Drawing.Size(101, 19);
            this.lblRatePrompt.Text = "Rate Per Pound:";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRate.Location = new System.Drawing.Point(20, 197);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 25);
            // 
            // lblRateUnit
            // 
            this.lblRateUnit.AutoSize = true;
            this.lblRateUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRateUnit.Location = new System.Drawing.Point(125, 200);
            this.lblRateUnit.Name = "lblRateUnit";
            this.lblRateUnit.Size = new System.Drawing.Size(35, 19);
            this.lblRateUnit.Text = "$/lb";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalculate.Location = new System.Drawing.Point(20, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 32);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(130, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResult.Location = new System.Drawing.Point(270, 55);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(10);
            this.lblResult.Size = new System.Drawing.Size(280, 260);
            this.lblResult.Text = "Enter shipment details and click Calculate.\n\nHandling fee: $4.50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 335);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescPrompt);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblWeightPrompt);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeightUnit);
            this.Controls.Add(this.lblRatePrompt);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRateUnit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo 5: Shipping Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescPrompt;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblWeightPrompt;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.Label lblRatePrompt;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRateUnit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
    }
}
