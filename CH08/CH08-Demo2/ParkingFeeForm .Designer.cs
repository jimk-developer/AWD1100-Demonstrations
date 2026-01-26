namespace CH08_Demo2
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
            label1 = new Label();
            txtHours = new TextBox();
            btnCalculate = new Button();
            lblRateLabel = new Label();
            lblHourlyRate = new Label();
            lblTotalLabel = new Label();
            lblTotalFee = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Hours Parked:";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(120, 43);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 27);
            txtHours.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(120, 87);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(97, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblRateLabel
            // 
            lblRateLabel.AutoSize = true;
            lblRateLabel.Location = new Point(24, 151);
            lblRateLabel.Name = "lblRateLabel";
            lblRateLabel.Size = new Size(90, 20);
            lblRateLabel.TabIndex = 3;
            lblRateLabel.Text = "Hourly Rate:";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(120, 151);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(50, 20);
            lblHourlyRate.TabIndex = 4;
            lblHourlyRate.Text = "label2";
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Location = new Point(29, 189);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(72, 20);
            lblTotalLabel.TabIndex = 5;
            lblTotalLabel.Text = "Total Fee:";
            // 
            // lblTotalFee
            // 
            lblTotalFee.AutoSize = true;
            lblTotalFee.Location = new Point(120, 189);
            lblTotalFee.Name = "lblTotalFee";
            lblTotalFee.Size = new Size(50, 20);
            lblTotalFee.TabIndex = 6;
            lblTotalFee.Text = "label2";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(244, 50);
            lblError.Name = "lblError";
            lblError.Size = new Size(50, 20);
            lblError.TabIndex = 7;
            lblError.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lblTotalFee);
            Controls.Add(lblTotalLabel);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblRateLabel);
            Controls.Add(btnCalculate);
            Controls.Add(txtHours);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Parking Fee Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHours;
        private Button btnCalculate;
        private Label lblRateLabel;
        private Label lblHourlyRate;
        private Label lblTotalLabel;
        private Label lblTotalFee;
        private Label lblError;
    }
}
