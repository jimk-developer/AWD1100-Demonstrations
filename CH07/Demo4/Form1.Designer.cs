namespace Demo4_TemperatureConverter
{
    partial class TemperatureConverterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.RadioButton rdoFtoC;
        private System.Windows.Forms.RadioButton rdoCtoF;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.rdoFtoC = new System.Windows.Forms.RadioButton();
            this.rdoCtoF = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTemperature
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(30, 30);
            this.lblTemperature.Text = "Temperature:";

            // txtTemperature
            this.txtTemperature.Location = new System.Drawing.Point(150, 27);
            this.txtTemperature.Size = new System.Drawing.Size(150, 23);

            // rdoFtoC
            this.rdoFtoC.AutoSize = true;
            this.rdoFtoC.Location = new System.Drawing.Point(30, 70);
            this.rdoFtoC.Text = "F \u2192 C";

            // rdoCtoF
            this.rdoCtoF.AutoSize = true;
            this.rdoCtoF.Location = new System.Drawing.Point(150, 70);
            this.rdoCtoF.Text = "C \u2192 F";

            // btnConvert
            this.btnConvert.Location = new System.Drawing.Point(30, 110);
            this.btnConvert.Size = new System.Drawing.Size(120, 35);
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(180, 110);
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 170);

            // Form
            this.ClientSize = new System.Drawing.Size(380, 240);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.rdoFtoC);
            this.Controls.Add(this.rdoCtoF);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Text = "Demo 4: Temperature Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
