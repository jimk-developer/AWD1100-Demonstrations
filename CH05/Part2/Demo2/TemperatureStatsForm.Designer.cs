namespace Demo2
{
    partial class TemperatureStatsForm
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
            txtTemperature = new TextBox();
            lblCount = new Label();
            btnEnter = new Button();
            lblSum = new Label();
            lblAverage = new Label();
            lblMin = new Label();
            lblMax = new Label();
            lblError = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Please enter a temperature";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(225, 36);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(100, 27);
            txtTemperature.TabIndex = 1;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(32, 141);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 20);
            lblCount.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(225, 79);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(100, 32);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(32, 180);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(0, 20);
            lblSum.TabIndex = 4;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(32, 217);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(0, 20);
            lblAverage.TabIndex = 5;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(32, 262);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(0, 20);
            lblMin.TabIndex = 6;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(32, 298);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(0, 20);
            lblMax.TabIndex = 7;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(32, 336);
            lblError.Name = "lblError";
            lblError.Size = new Size(171, 20);
            lblError.TabIndex = 8;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(347, 79);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 32);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // TemperatureStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(lblError);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(btnEnter);
            Controls.Add(lblCount);
            Controls.Add(txtTemperature);
            Controls.Add(label1);
            Name = "TemperatureStatsForm";
            Text = "Temperature Statistics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTemperature;
        private Label lblCount;
        private Button btnEnter;
        private Label lblSum;
        private Label lblAverage;
        private Label lblMin;
        private Label lblMax;
        private Label lblError;
        private Button btnReset;
    }
}
