namespace Demo1
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.txtShipDate = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblPolicyNumber = new System.Windows.Forms.Label();
            this.txtPolicyNumber = new System.Windows.Forms.TextBox();
            this.lblInsuranceNote = new System.Windows.Forms.Label();
            this.btnShip = new System.Windows.Forms.Button();
            this.lblTransactionLog = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();

            // grpInput
            this.grpInput.Controls.Add(this.lblRecipient);
            this.grpInput.Controls.Add(this.txtRecipient);
            this.grpInput.Controls.Add(this.lblShipDate);
            this.grpInput.Controls.Add(this.txtShipDate);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.lblPolicyNumber);
            this.grpInput.Controls.Add(this.txtPolicyNumber);
            this.grpInput.Controls.Add(this.lblInsuranceNote);
            this.grpInput.Controls.Add(this.btnShip);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(280, 310);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;

            // lblRecipient
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(15, 30);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(60, 15);
            this.lblRecipient.Text = "Recipient";

            // txtRecipient
            this.txtRecipient.Location = new System.Drawing.Point(15, 50);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(245, 23);

            // lblShipDate
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(15, 85);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(60, 15);
            this.lblShipDate.Text = "Ship Date";

            // txtShipDate
            this.txtShipDate.Location = new System.Drawing.Point(15, 105);
            this.txtShipDate.Name = "txtShipDate";
            this.txtShipDate.Size = new System.Drawing.Size(245, 23);

            // lblWeight
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(15, 140);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 15);
            this.lblWeight.Text = "Weight (lbs)";

            // txtWeight
            this.txtWeight.Location = new System.Drawing.Point(15, 160);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(245, 23);

            // lblPolicyNumber
            this.lblPolicyNumber.AutoSize = true;
            this.lblPolicyNumber.Location = new System.Drawing.Point(15, 195);
            this.lblPolicyNumber.Name = "lblPolicyNumber";
            this.lblPolicyNumber.Size = new System.Drawing.Size(90, 15);
            this.lblPolicyNumber.Text = "Policy Number";

            // txtPolicyNumber
            this.txtPolicyNumber.Location = new System.Drawing.Point(15, 215);
            this.txtPolicyNumber.Name = "txtPolicyNumber";
            this.txtPolicyNumber.Size = new System.Drawing.Size(245, 23);

            // lblInsuranceNote
            this.lblInsuranceNote.AutoSize = true;
            this.lblInsuranceNote.Location = new System.Drawing.Point(15, 245);
            this.lblInsuranceNote.Name = "lblInsuranceNote";
            this.lblInsuranceNote.Size = new System.Drawing.Size(240, 15);
            this.lblInsuranceNote.Text = "(Additional $5.00 fee for insured packages)";
            this.lblInsuranceNote.ForeColor = System.Drawing.Color.Gray;

            // btnShip
            this.btnShip.Location = new System.Drawing.Point(85, 270);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(100, 30);
            this.btnShip.Text = "Ship";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);

            // lblTransactionLog
            this.lblTransactionLog.Location = new System.Drawing.Point(310, 12);
            this.lblTransactionLog.Name = "lblTransactionLog";
            this.lblTransactionLog.Size = new System.Drawing.Size(440, 310);
            this.lblTransactionLog.Text = "";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 341);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblTransactionLog);
            this.Name = "Form1";
            this.Text = "Package Shipping";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblShipDate;
        private System.Windows.Forms.TextBox txtShipDate;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblPolicyNumber;
        private System.Windows.Forms.TextBox txtPolicyNumber;
        private System.Windows.Forms.Label lblInsuranceNote;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Label lblTransactionLog;
    }
}
