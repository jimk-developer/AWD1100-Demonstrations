namespace CH06_Part1_Demo5
{
    partial class PhoneNumberMaskerForm
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
            txtPhone = new TextBox();
            btnMask = new Button();
            lblMasked = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 60);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(198, 60);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 27);
            txtPhone.TabIndex = 1;
            // 
            // btnMask
            // 
            btnMask.Location = new Point(203, 110);
            btnMask.Name = "btnMask";
            btnMask.Size = new Size(75, 29);
            btnMask.TabIndex = 2;
            btnMask.Text = "Mask";
            btnMask.UseVisualStyleBackColor = true;
            btnMask.Click += btnMask_Click;
            // 
            // lblMasked
            // 
            lblMasked.AutoSize = true;
            lblMasked.Location = new Point(198, 162);
            lblMasked.Name = "lblMasked";
            lblMasked.Size = new Size(50, 20);
            lblMasked.TabIndex = 3;
            lblMasked.Text = "label2";
            // 
            // PhoneNumberMaskerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMasked);
            Controls.Add(btnMask);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Name = "PhoneNumberMaskerForm";
            Text = "Phone Number Masker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPhone;
        private Button btnMask;
        private Label lblMasked;
    }
}
