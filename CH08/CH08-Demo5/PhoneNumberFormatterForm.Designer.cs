namespace CH08_Demo5
{
    partial class PhoneNumberFormatterForm
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
            btnFormat = new Button();
            lblFormatted = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(208, 43);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(140, 27);
            txtPhone.TabIndex = 1;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(224, 89);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(100, 28);
            btnFormat.TabIndex = 2;
            btnFormat.Text = "Format";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // lblFormatted
            // 
            lblFormatted.Location = new Point(34, 146);
            lblFormatted.Name = "lblFormatted";
            lblFormatted.Size = new Size(203, 23);
            lblFormatted.TabIndex = 3;
            lblFormatted.Text = "label2";
            // 
            // PhoneNumberFormatterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFormatted);
            Controls.Add(btnFormat);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Name = "PhoneNumberFormatterForm";
            Text = "Phone Number Formatter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPhone;
        private Button btnFormat;
        private Label lblFormatted;
    }
}
