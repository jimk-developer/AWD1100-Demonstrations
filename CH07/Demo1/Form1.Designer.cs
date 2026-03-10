namespace Demo1_TipCalculator
{
    partial class TipCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMealTotal;
        private System.Windows.Forms.TextBox txtMealTotal;
        private System.Windows.Forms.Label lblTipPercent;
        private System.Windows.Forms.ComboBox cmbTipPercent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMealTotal = new System.Windows.Forms.Label();
            this.txtMealTotal = new System.Windows.Forms.TextBox();
            this.lblTipPercent = new System.Windows.Forms.Label();
            this.cmbTipPercent = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblMealTotal
            this.lblMealTotal.AutoSize = true;
            this.lblMealTotal.Location = new System.Drawing.Point(30, 30);
            this.lblMealTotal.Text = "Meal Total ($):";

            // txtMealTotal
            this.txtMealTotal.Location = new System.Drawing.Point(160, 27);
            this.txtMealTotal.Size = new System.Drawing.Size(150, 23);

            // lblTipPercent
            this.lblTipPercent.AutoSize = true;
            this.lblTipPercent.Location = new System.Drawing.Point(30, 70);
            this.lblTipPercent.Text = "Tip %:";

            // cmbTipPercent
            this.cmbTipPercent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipPercent.Location = new System.Drawing.Point(160, 67);
            this.cmbTipPercent.Size = new System.Drawing.Size(150, 23);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(30, 120);
            this.btnCalculate.Size = new System.Drawing.Size(130, 35);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(180, 120);
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblTipAmount
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipAmount.Location = new System.Drawing.Point(30, 180);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(30, 210);

            // lblError
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 250);

            // Form
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.lblMealTotal);
            this.Controls.Add(this.txtMealTotal);
            this.Controls.Add(this.lblTipPercent);
            this.Controls.Add(this.cmbTipPercent);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblError);
            this.Text = "Demo 1: Tip Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
