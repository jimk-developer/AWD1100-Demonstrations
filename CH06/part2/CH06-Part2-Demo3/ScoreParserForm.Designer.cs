namespace CH06_Part2_Demo3
{
    partial class ScoreParserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare controls based on the image_2.png table
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;

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
            txtScore = new TextBox();
            btnSubmit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(34, 47);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(114, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter Test Score";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(160, 43);
            txtScore.Margin = new Padding(3, 4, 3, 4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(114, 27);
            txtScore.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(160, 93);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(114, 40);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(34, 160);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(240, 38);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ScoreParserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 241);
            Controls.Add(lblResult);
            Controls.Add(btnSubmit);
            Controls.Add(txtScore);
            Controls.Add(lblPrompt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ScoreParserForm";
            Text = "Test Score Evaluator";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}