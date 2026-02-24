namespace Demo1
{
    partial class Form1
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblDrinkType = new System.Windows.Forms.Label();
            this.cmbDrinkType = new System.Windows.Forms.ComboBox();
            this.lblDrinkSize = new System.Windows.Forms.Label();
            this.cmbDrinkSize = new System.Windows.Forms.ComboBox();
            this.lblPastry = new System.Windows.Forms.Label();
            this.cmbPastry = new System.Windows.Forms.ComboBox();
            this.chkWarmed = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            this.grpReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblCustomerName);
            this.grpOrder.Controls.Add(this.txtCustomerName);
            this.grpOrder.Controls.Add(this.lblDrinkType);
            this.grpOrder.Controls.Add(this.cmbDrinkType);
            this.grpOrder.Controls.Add(this.lblDrinkSize);
            this.grpOrder.Controls.Add(this.cmbDrinkSize);
            this.grpOrder.Controls.Add(this.lblPastry);
            this.grpOrder.Controls.Add(this.cmbPastry);
            this.grpOrder.Controls.Add(this.chkWarmed);
            this.grpOrder.Controls.Add(this.btnPlaceOrder);
            this.grpOrder.Controls.Add(this.btnClear);
            this.grpOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOrder.Location = new System.Drawing.Point(20, 20);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(280, 340);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Place Your Order";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 35);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 19);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(15, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 25);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblDrinkType
            // 
            this.lblDrinkType.AutoSize = true;
            this.lblDrinkType.Location = new System.Drawing.Point(15, 95);
            this.lblDrinkType.Name = "lblDrinkType";
            this.lblDrinkType.Size = new System.Drawing.Size(76, 19);
            this.lblDrinkType.TabIndex = 2;
            this.lblDrinkType.Text = "Drink Type:";
            // 
            // cmbDrinkType
            // 
            this.cmbDrinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrinkType.FormattingEnabled = true;
            this.cmbDrinkType.Location = new System.Drawing.Point(15, 117);
            this.cmbDrinkType.Name = "cmbDrinkType";
            this.cmbDrinkType.Size = new System.Drawing.Size(250, 25);
            this.cmbDrinkType.TabIndex = 3;
            // 
            // lblDrinkSize
            // 
            this.lblDrinkSize.AutoSize = true;
            this.lblDrinkSize.Location = new System.Drawing.Point(15, 155);
            this.lblDrinkSize.Name = "lblDrinkSize";
            this.lblDrinkSize.Size = new System.Drawing.Size(36, 19);
            this.lblDrinkSize.TabIndex = 4;
            this.lblDrinkSize.Text = "Size:";
            // 
            // cmbDrinkSize
            // 
            this.cmbDrinkSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrinkSize.FormattingEnabled = true;
            this.cmbDrinkSize.Location = new System.Drawing.Point(15, 177);
            this.cmbDrinkSize.Name = "cmbDrinkSize";
            this.cmbDrinkSize.Size = new System.Drawing.Size(250, 25);
            this.cmbDrinkSize.TabIndex = 5;
            // 
            // lblPastry
            // 
            this.lblPastry.AutoSize = true;
            this.lblPastry.Location = new System.Drawing.Point(15, 215);
            this.lblPastry.Name = "lblPastry";
            this.lblPastry.Size = new System.Drawing.Size(78, 19);
            this.lblPastry.TabIndex = 6;
            this.lblPastry.Text = "Add Pastry:";
            // 
            // cmbPastry
            // 
            this.cmbPastry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPastry.FormattingEnabled = true;
            this.cmbPastry.Location = new System.Drawing.Point(15, 237);
            this.cmbPastry.Name = "cmbPastry";
            this.cmbPastry.Size = new System.Drawing.Size(250, 25);
            this.cmbPastry.TabIndex = 7;
            // 
            // chkWarmed
            // 
            this.chkWarmed.AutoSize = true;
            this.chkWarmed.Location = new System.Drawing.Point(15, 270);
            this.chkWarmed.Name = "chkWarmed";
            this.chkWarmed.Size = new System.Drawing.Size(77, 23);
            this.chkWarmed.TabIndex = 8;
            this.chkWarmed.Text = "Warmed";
            this.chkWarmed.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(15, 300);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(120, 32);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpReceipt
            // 
            this.grpReceipt.Controls.Add(this.lblResult);
            this.grpReceipt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpReceipt.Location = new System.Drawing.Point(320, 20);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(300, 340);
            this.grpReceipt.TabIndex = 1;
            this.grpReceipt.TabStop = false;
            this.grpReceipt.Text = "Order Receipt";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblResult.Location = new System.Drawing.Point(15, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(270, 295);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Select items and place your order.";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpReceipt);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo 1: Coffee Shop Order";
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpReceipt.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblDrinkType;
        private System.Windows.Forms.ComboBox cmbDrinkType;
        private System.Windows.Forms.Label lblDrinkSize;
        private System.Windows.Forms.ComboBox cmbDrinkSize;
        private System.Windows.Forms.Label lblPastry;
        private System.Windows.Forms.ComboBox cmbPastry;
        private System.Windows.Forms.CheckBox chkWarmed;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpReceipt;
        private System.Windows.Forms.Label lblResult;
    }
}