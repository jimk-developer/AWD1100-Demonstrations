namespace Demo3
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
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            btnSpotAgain = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            SuspendLayout();
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Location = new Point(17, 20);
            pic1.Margin = new Padding(3, 4, 3, 4);
            pic1.Name = "pic1";
            pic1.Size = new Size(205, 131);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Location = new Point(240, 20);
            pic2.Margin = new Padding(3, 4, 3, 4);
            pic2.Name = "pic2";
            pic2.Size = new Size(205, 131);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 1;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.BorderStyle = BorderStyle.FixedSingle;
            pic3.Location = new Point(463, 20);
            pic3.Margin = new Padding(3, 4, 3, 4);
            pic3.Name = "pic3";
            pic3.Size = new Size(205, 131);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 2;
            pic3.TabStop = false;
            // 
            // pic4
            // 
            pic4.BorderStyle = BorderStyle.FixedSingle;
            pic4.Location = new Point(686, 20);
            pic4.Margin = new Padding(3, 4, 3, 4);
            pic4.Name = "pic4";
            pic4.Size = new Size(205, 131);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic4.TabIndex = 3;
            pic4.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.Location = new Point(17, 164);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(208, 40);
            lbl1.TabIndex = 4;
            lbl1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            lbl2.Location = new Point(240, 164);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(206, 40);
            lbl2.TabIndex = 5;
            lbl2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl3
            // 
            lbl3.Location = new Point(463, 164);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(206, 40);
            lbl3.TabIndex = 6;
            lbl3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl4
            // 
            lbl4.Location = new Point(686, 164);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(206, 40);
            lbl4.TabIndex = 7;
            lbl4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSpotAgain
            // 
            btnSpotAgain.Location = new Point(353, 237);
            btnSpotAgain.Margin = new Padding(3, 4, 3, 4);
            btnSpotAgain.Name = "btnSpotAgain";
            btnSpotAgain.Size = new Size(194, 47);
            btnSpotAgain.TabIndex = 8;
            btnSpotAgain.Text = "Spot More Animals";
            btnSpotAgain.UseVisualStyleBackColor = true;
            btnSpotAgain.Click += btnSpotAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 301);
            Controls.Add(pic1);
            Controls.Add(pic2);
            Controls.Add(pic3);
            Controls.Add(pic4);
            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(lbl4);
            Controls.Add(btnSpotAgain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Animal Spotter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnSpotAgain;
    }
}
