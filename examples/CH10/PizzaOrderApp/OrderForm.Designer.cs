namespace PizzaOrderApp
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            lblHeader = new Label();
            lblSizeCaption = new Label();
            cboSize = new ComboBox();
            lblQtyCaption = new Label();
            cboQuantity = new ComboBox();
            grpCrust = new GroupBox();
            rdoThin = new RadioButton();
            rdoHand = new RadioButton();
            rdoPan = new RadioButton();
            grpAddons = new GroupBox();
            chkExtraCheese = new CheckBox();
            chkStuffedCrust = new CheckBox();
            chkGlutenFree = new CheckBox();
            btnCustomerInfo = new Button();
            lblCustomerStatus = new Label();
            btnPlaceOrder = new Button();
            btnReset = new Button();
            lblSpecialCaption = new Label();
            lstSpecials = new ListBox();
            lblSpecialStatus = new Label();
            grpNotes = new GroupBox();
            txtNotes = new TextBox();
            lblSummaryCaption = new Label();
            txtSummary = new TextBox();
            lblTotal = new Label();
            grpCrust.SuspendLayout();
            grpAddons.SuspendLayout();
            grpNotes.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(180, 30, 30);
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(11, 13);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(949, 48);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Pizza Order Entry  —  Guide #10 Example";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSizeCaption
            // 
            lblSizeCaption.Location = new Point(11, 77);
            lblSizeCaption.Name = "lblSizeCaption";
            lblSizeCaption.Size = new Size(246, 24);
            lblSizeCaption.TabIndex = 1;
            lblSizeCaption.Text = "Pizza Size  (ComboBox):";
            // 
            // cboSize
            // 
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(11, 104);
            cboSize.Margin = new Padding(3, 4, 3, 4);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(245, 28);
            cboSize.TabIndex = 2;
            cboSize.SelectedIndexChanged += cboSize_SelectedIndexChanged;
            // 
            // lblQtyCaption
            // 
            lblQtyCaption.Location = new Point(11, 149);
            lblQtyCaption.Name = "lblQtyCaption";
            lblQtyCaption.Size = new Size(246, 24);
            lblQtyCaption.TabIndex = 3;
            lblQtyCaption.Text = "Quantity  (ComboBox — filled by loop):";
            // 
            // cboQuantity
            // 
            cboQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuantity.FormattingEnabled = true;
            cboQuantity.Location = new Point(11, 176);
            cboQuantity.Margin = new Padding(3, 4, 3, 4);
            cboQuantity.Name = "cboQuantity";
            cboQuantity.Size = new Size(245, 28);
            cboQuantity.TabIndex = 4;
            cboQuantity.SelectedIndexChanged += cboQuantity_SelectedIndexChanged;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoThin);
            grpCrust.Controls.Add(rdoHand);
            grpCrust.Controls.Add(rdoPan);
            grpCrust.Location = new Point(11, 224);
            grpCrust.Margin = new Padding(3, 4, 3, 4);
            grpCrust.Name = "grpCrust";
            grpCrust.Padding = new Padding(3, 4, 3, 4);
            grpCrust.Size = new Size(246, 147);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust Type  (RadioButtons in GroupBox)";
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Checked = true;
            rdoThin.Location = new Point(6, 51);
            rdoThin.Margin = new Padding(3, 4, 3, 4);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(92, 24);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin Crust";
            rdoThin.CheckedChanged += rdoCrust_CheckedChanged;
            // 
            // rdoHand
            // 
            rdoHand.AutoSize = true;
            rdoHand.Location = new Point(6, 83);
            rdoHand.Margin = new Padding(3, 4, 3, 4);
            rdoHand.Name = "rdoHand";
            rdoHand.Size = new Size(114, 24);
            rdoHand.TabIndex = 1;
            rdoHand.Text = "Hand-Tossed";
            rdoHand.CheckedChanged += rdoCrust_CheckedChanged;
            // 
            // rdoPan
            // 
            rdoPan.AutoSize = true;
            rdoPan.Location = new Point(6, 115);
            rdoPan.Margin = new Padding(3, 4, 3, 4);
            rdoPan.Name = "rdoPan";
            rdoPan.Size = new Size(146, 24);
            rdoPan.TabIndex = 2;
            rdoPan.Text = "Pan Crust (+$0.50)";
            rdoPan.CheckedChanged += rdoCrust_CheckedChanged;
            // 
            // grpAddons
            // 
            grpAddons.Controls.Add(chkExtraCheese);
            grpAddons.Controls.Add(chkStuffedCrust);
            grpAddons.Controls.Add(chkGlutenFree);
            grpAddons.Location = new Point(11, 387);
            grpAddons.Margin = new Padding(3, 4, 3, 4);
            grpAddons.Name = "grpAddons";
            grpAddons.Padding = new Padding(3, 4, 3, 4);
            grpAddons.Size = new Size(246, 144);
            grpAddons.TabIndex = 6;
            grpAddons.TabStop = false;
            grpAddons.Text = "Add-ons  (CheckBoxes — independent)";
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Location = new Point(8, 48);
            chkExtraCheese.Margin = new Padding(3, 4, 3, 4);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(175, 24);
            chkExtraCheese.TabIndex = 0;
            chkExtraCheese.Text = "Extra Cheese  (+$1.00)";
            chkExtraCheese.CheckedChanged += chk_CheckedChanged;
            // 
            // chkStuffedCrust
            // 
            chkStuffedCrust.AutoSize = true;
            chkStuffedCrust.Location = new Point(8, 80);
            chkStuffedCrust.Margin = new Padding(3, 4, 3, 4);
            chkStuffedCrust.Name = "chkStuffedCrust";
            chkStuffedCrust.Size = new Size(172, 24);
            chkStuffedCrust.TabIndex = 1;
            chkStuffedCrust.Text = "Stuffed Crust (+$1.50)";
            chkStuffedCrust.CheckedChanged += chk_CheckedChanged;
            // 
            // chkGlutenFree
            // 
            chkGlutenFree.AutoSize = true;
            chkGlutenFree.Location = new Point(11, 112);
            chkGlutenFree.Margin = new Padding(3, 4, 3, 4);
            chkGlutenFree.Name = "chkGlutenFree";
            chkGlutenFree.Size = new Size(172, 24);
            chkGlutenFree.TabIndex = 2;
            chkGlutenFree.Text = "Gluten-Free   (+$2.00)";
            chkGlutenFree.CheckedChanged += chk_CheckedChanged;
            // 
            // btnCustomerInfo
            // 
            btnCustomerInfo.BackColor = Color.FromArgb(0, 120, 215);
            btnCustomerInfo.FlatStyle = FlatStyle.Flat;
            btnCustomerInfo.ForeColor = Color.White;
            btnCustomerInfo.Location = new Point(11, 547);
            btnCustomerInfo.Margin = new Padding(3, 4, 3, 4);
            btnCustomerInfo.Name = "btnCustomerInfo";
            btnCustomerInfo.Size = new Size(246, 43);
            btnCustomerInfo.TabIndex = 7;
            btnCustomerInfo.Text = "Enter Customer Info  (ShowDialog)";
            btnCustomerInfo.UseVisualStyleBackColor = false;
            btnCustomerInfo.Click += btnCustomerInfo_Click;
            // 
            // lblCustomerStatus
            // 
            lblCustomerStatus.ForeColor = Color.DimGray;
            lblCustomerStatus.Location = new Point(11, 597);
            lblCustomerStatus.Name = "lblCustomerStatus";
            lblCustomerStatus.Size = new Size(246, 24);
            lblCustomerStatus.TabIndex = 8;
            lblCustomerStatus.Text = "(no customer info)";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(16, 124, 16);
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(11, 629);
            btnPlaceOrder.Margin = new Padding(3, 4, 3, 4);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(246, 48);
            btnPlaceOrder.TabIndex = 9;
            btnPlaceOrder.Text = "Place Order  (MessageBox.YesNo)";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(220, 80, 40);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(11, 688);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(246, 40);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset Order  (MessageBox.OKCancel)";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblSpecialCaption
            // 
            lblSpecialCaption.Location = new Point(280, 77);
            lblSpecialCaption.Name = "lblSpecialCaption";
            lblSpecialCaption.Size = new Size(251, 24);
            lblSpecialCaption.TabIndex = 11;
            lblSpecialCaption.Text = "Specialty  (ListBox — always visible):";
            // 
            // lstSpecials
            // 
            lstSpecials.FormattingEnabled = true;
            lstSpecials.Location = new Point(280, 104);
            lstSpecials.Margin = new Padding(3, 4, 3, 4);
            lstSpecials.Name = "lstSpecials";
            lstSpecials.Size = new Size(251, 124);
            lstSpecials.TabIndex = 12;
            lstSpecials.SelectedIndexChanged += lstSpecials_SelectedIndexChanged;
            // 
            // lblSpecialStatus
            // 
            lblSpecialStatus.ForeColor = Color.DimGray;
            lblSpecialStatus.Location = new Point(280, 237);
            lblSpecialStatus.Name = "lblSpecialStatus";
            lblSpecialStatus.Size = new Size(251, 24);
            lblSpecialStatus.TabIndex = 13;
            // 
            // grpNotes
            // 
            grpNotes.Controls.Add(txtNotes);
            grpNotes.Location = new Point(280, 269);
            grpNotes.Margin = new Padding(3, 4, 3, 4);
            grpNotes.Name = "grpNotes";
            grpNotes.Padding = new Padding(3, 4, 3, 4);
            grpNotes.Size = new Size(446, 461);
            grpNotes.TabIndex = 14;
            grpNotes.TabStop = false;
            grpNotes.Text = "Guide #10 Concepts in this App";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(250, 250, 240);
            txtNotes.Font = new Font("Consolas", 8F);
            txtNotes.Location = new Point(9, 27);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(427, 423);
            txtNotes.TabIndex = 0;
            txtNotes.TabStop = false;
            txtNotes.Text = resources.GetString("txtNotes.Text");
            // 
            // lblSummaryCaption
            // 
            lblSummaryCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSummaryCaption.Location = new Point(741, 77);
            lblSummaryCaption.Name = "lblSummaryCaption";
            lblSummaryCaption.Size = new Size(219, 24);
            lblSummaryCaption.TabIndex = 15;
            lblSummaryCaption.Text = "Live Order Summary:";
            // 
            // txtSummary
            // 
            txtSummary.BackColor = Color.White;
            txtSummary.Font = new Font("Consolas", 8.5F);
            txtSummary.Location = new Point(741, 104);
            txtSummary.Margin = new Padding(3, 4, 3, 4);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(219, 543);
            txtSummary.TabIndex = 16;
            txtSummary.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(180, 30, 30);
            lblTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(741, 656);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(219, 43);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Order Total: $0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(978, 749);
            Controls.Add(lblHeader);
            Controls.Add(lblSizeCaption);
            Controls.Add(cboSize);
            Controls.Add(lblQtyCaption);
            Controls.Add(cboQuantity);
            Controls.Add(grpCrust);
            Controls.Add(grpAddons);
            Controls.Add(btnCustomerInfo);
            Controls.Add(lblCustomerStatus);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnReset);
            Controls.Add(lblSpecialCaption);
            Controls.Add(lstSpecials);
            Controls.Add(lblSpecialStatus);
            Controls.Add(grpNotes);
            Controls.Add(lblSummaryCaption);
            Controls.Add(txtSummary);
            Controls.Add(lblTotal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizza Order — Guide #10 Demo";
            FormClosing += OrderForm_FormClosing;
            Load += OrderForm_Load;
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpAddons.ResumeLayout(false);
            grpAddons.PerformLayout();
            grpNotes.ResumeLayout(false);
            grpNotes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // ── control field declarations ───────────────────────────────────────
        private System.Windows.Forms.Label       lblHeader;
        private System.Windows.Forms.Label       lblSizeCaption;
        private System.Windows.Forms.ComboBox    cboSize;
        private System.Windows.Forms.Label       lblQtyCaption;
        private System.Windows.Forms.ComboBox    cboQuantity;
        private System.Windows.Forms.GroupBox    grpCrust;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoHand;
        private System.Windows.Forms.RadioButton rdoPan;
        private System.Windows.Forms.GroupBox    grpAddons;
        private System.Windows.Forms.CheckBox    chkExtraCheese;
        private System.Windows.Forms.CheckBox    chkStuffedCrust;
        private System.Windows.Forms.CheckBox    chkGlutenFree;
        private System.Windows.Forms.Button      btnCustomerInfo;
        private System.Windows.Forms.Label       lblCustomerStatus;
        private System.Windows.Forms.Button      btnPlaceOrder;
        private System.Windows.Forms.Button      btnReset;
        private System.Windows.Forms.Label       lblSpecialCaption;
        private System.Windows.Forms.ListBox     lstSpecials;
        private System.Windows.Forms.Label       lblSpecialStatus;
        private System.Windows.Forms.GroupBox    grpNotes;
        private System.Windows.Forms.TextBox     txtNotes;
        private System.Windows.Forms.Label       lblSummaryCaption;
        private System.Windows.Forms.TextBox     txtSummary;
        private System.Windows.Forms.Label       lblTotal;
    }
}
