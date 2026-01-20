namespace Lab2
{
    partial class MovieRatingForm
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
            txtAudienceScore = new TextBox();
            btnRate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 76);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Audience Score (%):";
            // 
            // txtAudienceScore
            // 
            txtAudienceScore.Location = new Point(223, 76);
            txtAudienceScore.Name = "txtAudienceScore";
            txtAudienceScore.Size = new Size(100, 27);
            txtAudienceScore.TabIndex = 1;
            // 
            // btnRate
            // 
            btnRate.BackColor = SystemColors.Control;
            btnRate.ForeColor = Color.Blue;
            btnRate.Location = new Point(365, 76);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(138, 27);
            btnRate.TabIndex = 2;
            btnRate.Text = "Get Rating";
            btnRate.UseVisualStyleBackColor = false;
            btnRate.Click += btnRate_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(51, 134);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(403, 23);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieRatingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnRate);
            Controls.Add(txtAudienceScore);
            Controls.Add(label1);
            Name = "MovieRatingForm";
            Text = "Movie Rating";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAudienceScore;
        private Button btnRate;
        private Label lblResult;
    }
}
