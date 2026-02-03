namespace CH06_Part1_Demo3
{
    partial class DigitCounterForm
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
            txtPhrase = new TextBox();
            btnCount = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(28, 52);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(149, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Please enter a phrase";
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(198, 55);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(100, 27);
            txtPhrase.TabIndex = 1;
            txtPhrase.Click += TextBox_Enter;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(204, 110);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(79, 33);
            btnCount.TabIndex = 2;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.DarkBlue;
            lblResult.Location = new Point(100, 155);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // DigitCounterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 215);
            Controls.Add(lblResult);
            Controls.Add(btnCount);
            Controls.Add(txtPhrase);
            Controls.Add(lblPrompt);
            Name = "DigitCounterForm";
            Text = "Digit Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtPhrase;
        private Button btnCount;
        private Label lblResult;
    }
}
