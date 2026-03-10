namespace Demo2_GradeCalculator
{
    partial class GradeCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHomework;
        private System.Windows.Forms.TextBox txtHomework;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHomework = new System.Windows.Forms.Label();
            this.txtHomework = new System.Windows.Forms.TextBox();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblHomework
            this.lblHomework.AutoSize = true;
            this.lblHomework.Location = new System.Drawing.Point(30, 30);
            this.lblHomework.Text = "Homework (0\u2013100):";

            // txtHomework
            this.txtHomework.Location = new System.Drawing.Point(190, 27);
            this.txtHomework.Size = new System.Drawing.Size(150, 23);

            // lblMidterm
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.Location = new System.Drawing.Point(30, 70);
            this.lblMidterm.Text = "Midterm (0\u2013100):";

            // txtMidterm
            this.txtMidterm.Location = new System.Drawing.Point(190, 67);
            this.txtMidterm.Size = new System.Drawing.Size(150, 23);

            // lblFinal
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(30, 110);
            this.lblFinal.Text = "Final (0\u2013100):";

            // txtFinal
            this.txtFinal.Location = new System.Drawing.Point(190, 107);
            this.txtFinal.Size = new System.Drawing.Size(150, 23);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(30, 160);
            this.btnCalculate.Size = new System.Drawing.Size(140, 35);
            this.btnCalculate.Text = "Calculate Grade";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(200, 160);
            this.btnClear.Size = new System.Drawing.Size(140, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 220);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblHomework);
            this.Controls.Add(this.txtHomework);
            this.Controls.Add(this.lblMidterm);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Text = "Demo 2: Grade Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
