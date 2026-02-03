namespace CH06_Part1_Demo6
{
    partial class CustomPizzaOrderForm
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
            lblSizePrompt = new Label();
            txtSize = new TextBox();
            lblToppingPrompt = new Label();
            txtToppings = new TextBox();
            btnCalculate = new Button();
            lblSize = new Label();
            lblToppings = new Label();
            lblTotal = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblSizePrompt
            // 
            lblSizePrompt.AutoSize = true;
            lblSizePrompt.Location = new Point(34, 55);
            lblSizePrompt.Name = "lblSizePrompt";
            lblSizePrompt.Size = new Size(126, 20);
            lblSizePrompt.TabIndex = 0;
            lblSizePrompt.Text = "Pizza Size (s/m/l):";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(194, 55);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 27);
            txtSize.TabIndex = 1;
            // 
            // lblToppingPrompt
            // 
            lblToppingPrompt.AutoSize = true;
            lblToppingPrompt.Location = new Point(34, 104);
            lblToppingPrompt.Name = "lblToppingPrompt";
            lblToppingPrompt.Size = new Size(149, 20);
            lblToppingPrompt.TabIndex = 2;
            lblToppingPrompt.Text = "Number of Toppings:";
            // 
            // txtToppings
            // 
            txtToppings.Location = new Point(196, 104);
            txtToppings.Name = "txtToppings";
            txtToppings.Size = new Size(100, 27);
            txtToppings.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(194, 157);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 33);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(159, 244);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(50, 20);
            lblSize.TabIndex = 5;
            lblSize.Text = "label1";
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Location = new Point(224, 244);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(50, 20);
            lblToppings.TabIndex = 6;
            lblToppings.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(280, 244);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 244);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Your Order:";
            // 
            // CustomPizzaOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(lblToppings);
            Controls.Add(lblSize);
            Controls.Add(btnCalculate);
            Controls.Add(txtToppings);
            Controls.Add(lblToppingPrompt);
            Controls.Add(txtSize);
            Controls.Add(lblSizePrompt);
            Name = "CustomPizzaOrderForm";
            Text = "Custom Pizza Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSizePrompt;
        private TextBox txtSize;
        private Label lblToppingPrompt;
        private TextBox txtToppings;
        private Button btnCalculate;
        private Label lblSize;
        private Label lblToppings;
        private Label lblTotal;
        private Label label4;
    }
}
