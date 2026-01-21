namespace Demo5
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
            label1 = new Label();
            txtInput = new TextBox();
            btnCount = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Please enter some text";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(225, 42);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(195, 27);
            txtInput.TabIndex = 1;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(156, 89);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(107, 31);
            btnCount.TabIndex = 2;
            btnCount.Text = "Count Digits";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(43, 161);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "label2";
            // 
            // DigitCounterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCount);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "DigitCounterForm";
            Text = "Digit Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Button btnCount;
        private Label lblResult;
    }
}
