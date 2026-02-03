namespace CH06_Part1_Demo7
{
    partial class LibraryCardSystemForm
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
            lblCardPrompt = new Label();
            lblPinPrompt = new Label();
            txtCardNumber = new TextBox();
            txtPin = new TextBox();
            btnLogin = new Button();
            btnLogout = new Button();
            lblBooksPrompt = new Label();
            txtBooks = new TextBox();
            lblMessage = new Label();
            btnCheckout = new Button();
            btnReturn = new Button();
            lblBooksOut = new Label();
            SuspendLayout();
            // 
            // lblCardPrompt
            // 
            lblCardPrompt.AutoSize = true;
            lblCardPrompt.Location = new Point(31, 59);
            lblCardPrompt.Name = "lblCardPrompt";
            lblCardPrompt.Size = new Size(101, 20);
            lblCardPrompt.TabIndex = 0;
            lblCardPrompt.Text = "Card Number:";
            // 
            // lblPinPrompt
            // 
            lblPinPrompt.AutoSize = true;
            lblPinPrompt.Location = new Point(31, 105);
            lblPinPrompt.Name = "lblPinPrompt";
            lblPinPrompt.Size = new Size(35, 20);
            lblPinPrompt.TabIndex = 2;
            lblPinPrompt.Text = "PIN:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(169, 59);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(100, 27);
            txtCardNumber.TabIndex = 1;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(169, 105);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(100, 27);
            txtPin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.ForeColor = Color.DarkGreen;
            btnLogin.Location = new Point(52, 161);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = Color.DarkRed;
            btnLogout.Location = new Point(169, 161);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 32);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log&out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblBooksPrompt
            // 
            lblBooksPrompt.AutoSize = true;
            lblBooksPrompt.Location = new Point(31, 228);
            lblBooksPrompt.Name = "lblBooksPrompt";
            lblBooksPrompt.Size = new Size(128, 20);
            lblBooksPrompt.TabIndex = 6;
            lblBooksPrompt.Text = "Number of Books:";
            // 
            // txtBooks
            // 
            txtBooks.Location = new Point(169, 228);
            txtBooks.Name = "txtBooks";
            txtBooks.Size = new Size(100, 27);
            txtBooks.TabIndex = 7;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(31, 363);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(57, 21);
            lblMessage.TabIndex = 10;
            lblMessage.Text = "label1";
            // 
            // btnCheckout
            // 
            btnCheckout.ForeColor = Color.DarkBlue;
            btnCheckout.Location = new Point(44, 286);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(85, 29);
            btnCheckout.TabIndex = 8;
            btnCheckout.Text = "&Check Out";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnReturn
            // 
            btnReturn.ForeColor = Color.Purple;
            btnReturn.Location = new Point(169, 286);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(85, 29);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "&Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblBooksOut
            // 
            lblBooksOut.AutoSize = true;
            lblBooksOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksOut.Location = new Point(31, 399);
            lblBooksOut.Name = "lblBooksOut";
            lblBooksOut.Size = new Size(57, 21);
            lblBooksOut.TabIndex = 11;
            lblBooksOut.Text = "label2";
            // 
            // LibraryCardSystemForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLogout;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBooksOut);
            Controls.Add(btnReturn);
            Controls.Add(btnCheckout);
            Controls.Add(lblMessage);
            Controls.Add(txtBooks);
            Controls.Add(lblBooksPrompt);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(txtPin);
            Controls.Add(txtCardNumber);
            Controls.Add(lblPinPrompt);
            Controls.Add(lblCardPrompt);
            Name = "LibraryCardSystemForm";
            Text = "Library Card System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCardPrompt;
        private Label lblPinPrompt;
        private TextBox txtCardNumber;
        private TextBox txtPin;
        private Button btnLogin;
        private Button btnLogout;
        private Label lblBooksPrompt;
        private TextBox txtBooks;
        private Label lblMessage;
        private Button btnCheckout;
        private Button btnReturn;
        private Label lblBooksOut;
    }
}
