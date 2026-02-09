namespace CH06_Part2_Demo1
{
    partial class ColorReverseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare controls based on the table
        private System.Windows.Forms.Label lblColor1Prompt;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label lblColor2Prompt;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Label lblColor3Prompt;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult3;

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
            lblColor1Prompt = new Label();
            txtColor1 = new TextBox();
            lblColor2Prompt = new Label();
            txtColor2 = new TextBox();
            lblColor3Prompt = new Label();
            txtColor3 = new TextBox();
            btnRotate = new Button();
            lblResult1 = new Label();
            lblResult2 = new Label();
            lblResult3 = new Label();
            SuspendLayout();
            // 
            // lblColor1Prompt
            // 
            lblColor1Prompt.AutoSize = true;
            lblColor1Prompt.Location = new Point(34, 44);
            lblColor1Prompt.Name = "lblColor1Prompt";
            lblColor1Prompt.Size = new Size(57, 20);
            lblColor1Prompt.TabIndex = 0;
            lblColor1Prompt.Text = "Color 1";
            // 
            // txtColor1
            // 
            txtColor1.Location = new Point(114, 40);
            txtColor1.Margin = new Padding(3, 4, 3, 4);
            txtColor1.Name = "txtColor1";
            txtColor1.Size = new Size(171, 27);
            txtColor1.TabIndex = 1;
            // 
            // lblColor2Prompt
            // 
            lblColor2Prompt.AutoSize = true;
            lblColor2Prompt.Location = new Point(34, 97);
            lblColor2Prompt.Name = "lblColor2Prompt";
            lblColor2Prompt.Size = new Size(57, 20);
            lblColor2Prompt.TabIndex = 2;
            lblColor2Prompt.Text = "Color 2";
            // 
            // txtColor2
            // 
            txtColor2.Location = new Point(114, 93);
            txtColor2.Margin = new Padding(3, 4, 3, 4);
            txtColor2.Name = "txtColor2";
            txtColor2.Size = new Size(171, 27);
            txtColor2.TabIndex = 3;
            // 
            // lblColor3Prompt
            // 
            lblColor3Prompt.AutoSize = true;
            lblColor3Prompt.Location = new Point(34, 151);
            lblColor3Prompt.Name = "lblColor3Prompt";
            lblColor3Prompt.Size = new Size(57, 20);
            lblColor3Prompt.TabIndex = 4;
            lblColor3Prompt.Text = "Color 3";
            // 
            // txtColor3
            // 
            txtColor3.Location = new Point(114, 147);
            txtColor3.Margin = new Padding(3, 4, 3, 4);
            txtColor3.Name = "txtColor3";
            txtColor3.Size = new Size(171, 27);
            txtColor3.TabIndex = 5;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(114, 200);
            btnRotate.Margin = new Padding(3, 4, 3, 4);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(86, 31);
            btnRotate.TabIndex = 6;
            btnRotate.Text = "Reverse";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // lblResult1
            // 
            lblResult1.BorderStyle = BorderStyle.FixedSingle;
            lblResult1.Location = new Point(114, 253);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(171, 30);
            lblResult1.TabIndex = 7;
            lblResult1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResult2
            // 
            lblResult2.BorderStyle = BorderStyle.FixedSingle;
            lblResult2.Location = new Point(114, 300);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(171, 30);
            lblResult2.TabIndex = 8;
            lblResult2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResult3
            // 
            lblResult3.BorderStyle = BorderStyle.FixedSingle;
            lblResult3.Location = new Point(114, 347);
            lblResult3.Name = "lblResult3";
            lblResult3.Size = new Size(171, 30);
            lblResult3.TabIndex = 9;
            lblResult3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ColorReverseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 427);
            Controls.Add(lblResult3);
            Controls.Add(lblResult2);
            Controls.Add(lblResult1);
            Controls.Add(btnRotate);
            Controls.Add(txtColor3);
            Controls.Add(lblColor3Prompt);
            Controls.Add(txtColor2);
            Controls.Add(lblColor2Prompt);
            Controls.Add(txtColor1);
            Controls.Add(lblColor1Prompt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ColorReverseForm";
            Text = "Color Reverse";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}