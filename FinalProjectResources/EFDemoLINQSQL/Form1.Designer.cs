namespace EFDemoLINQSQL
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
            lblResult = new Label();
            lblEnterMin = new Label();
            txtMinBudget = new TextBox();
            btnSearchMin = new Button();
            lblSearchResult = new Label();
            btnSearchId = new Button();
            txtCustomerId = new TextBox();
            lblEnterId = new Label();
            txtAddBudget = new TextBox();
            txtAddName = new TextBox();
            lblCustomerName = new Label();
            lblBudget = new Label();
            btnAddCustomer = new Button();
            cboCustomerIds = new ComboBox();
            lblSelectDelete = new Label();
            btnDeleteCustomer = new Button();
            lblDelete = new Label();
            lblUpdateCustomer = new Label();
            cboCustomerToUpdate = new ComboBox();
            lblCustomerUpdated = new Label();
            btnUpdateCustomer = new Button();
            txtBudgetToUpdate = new TextBox();
            txtNameToUpdate = new TextBox();
            lblUpdateBudget = new Label();
            lblUpdateName = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(411, 366);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 0;
            // 
            // lblEnterMin
            // 
            lblEnterMin.AutoSize = true;
            lblEnterMin.Location = new Point(30, 24);
            lblEnterMin.Name = "lblEnterMin";
            lblEnterMin.Size = new Size(177, 20);
            lblEnterMin.TabIndex = 1;
            lblEnterMin.Text = "Enter a Minimum Budget:";
            // 
            // txtMinBudget
            // 
            txtMinBudget.Location = new Point(213, 21);
            txtMinBudget.Name = "txtMinBudget";
            txtMinBudget.Size = new Size(198, 27);
            txtMinBudget.TabIndex = 2;
            // 
            // btnSearchMin
            // 
            btnSearchMin.Location = new Point(417, 20);
            btnSearchMin.Name = "btnSearchMin";
            btnSearchMin.Size = new Size(136, 29);
            btnSearchMin.TabIndex = 3;
            btnSearchMin.Text = "Search";
            btnSearchMin.UseVisualStyleBackColor = true;
            btnSearchMin.Click += btnSearchMin_Click;
            // 
            // lblSearchResult
            // 
            lblSearchResult.AutoSize = true;
            lblSearchResult.Location = new Point(30, 87);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new Size(0, 20);
            lblSearchResult.TabIndex = 4;
            // 
            // btnSearchId
            // 
            btnSearchId.Location = new Point(417, 53);
            btnSearchId.Name = "btnSearchId";
            btnSearchId.Size = new Size(136, 29);
            btnSearchId.TabIndex = 7;
            btnSearchId.Text = "Search";
            btnSearchId.UseVisualStyleBackColor = true;
            btnSearchId.Click += btnSearchId_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(213, 54);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(198, 27);
            txtCustomerId.TabIndex = 6;
            // 
            // lblEnterId
            // 
            lblEnterId.AutoSize = true;
            lblEnterId.Location = new Point(30, 57);
            lblEnterId.Name = "lblEnterId";
            lblEnterId.Size = new Size(144, 20);
            lblEnterId.TabIndex = 5;
            lblEnterId.Text = "Enter a Customer ID:";
            // 
            // txtAddBudget
            // 
            txtAddBudget.Location = new Point(213, 197);
            txtAddBudget.Name = "txtAddBudget";
            txtAddBudget.Size = new Size(198, 27);
            txtAddBudget.TabIndex = 9;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(213, 164);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(198, 27);
            txtAddName.TabIndex = 8;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(30, 167);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(119, 20);
            lblCustomerName.TabIndex = 10;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(30, 200);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(60, 20);
            lblBudget.TabIndex = 11;
            lblBudget.Text = "Budget:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(417, 180);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(136, 29);
            btnAddCustomer.TabIndex = 12;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // cboCustomerIds
            // 
            cboCustomerIds.FormattingEnabled = true;
            cboCustomerIds.Location = new Point(783, 21);
            cboCustomerIds.Name = "cboCustomerIds";
            cboCustomerIds.Size = new Size(198, 28);
            cboCustomerIds.TabIndex = 13;
            // 
            // lblSelectDelete
            // 
            lblSelectDelete.AutoSize = true;
            lblSelectDelete.Location = new Point(595, 24);
            lblSelectDelete.Name = "lblSelectDelete";
            lblSelectDelete.Size = new Size(162, 20);
            lblSelectDelete.TabIndex = 14;
            lblSelectDelete.Text = "Delete Customer By ID:";
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(987, 20);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(159, 29);
            btnDeleteCustomer.TabIndex = 15;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(610, 57);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(0, 20);
            lblDelete.TabIndex = 16;
            // 
            // lblUpdateCustomer
            // 
            lblUpdateCustomer.AutoSize = true;
            lblUpdateCustomer.Location = new Point(595, 167);
            lblUpdateCustomer.Name = "lblUpdateCustomer";
            lblUpdateCustomer.Size = new Size(167, 20);
            lblUpdateCustomer.TabIndex = 18;
            lblUpdateCustomer.Text = "Update Customer By ID:";
            // 
            // cboCustomerToUpdate
            // 
            cboCustomerToUpdate.FormattingEnabled = true;
            cboCustomerToUpdate.Location = new Point(783, 164);
            cboCustomerToUpdate.Name = "cboCustomerToUpdate";
            cboCustomerToUpdate.Size = new Size(198, 28);
            cboCustomerToUpdate.TabIndex = 17;
            cboCustomerToUpdate.SelectedIndexChanged += cboCustomerToUpdate_SelectedIndexChanged;
            // 
            // lblCustomerUpdated
            // 
            lblCustomerUpdated.AutoSize = true;
            lblCustomerUpdated.Location = new Point(595, 266);
            lblCustomerUpdated.Name = "lblCustomerUpdated";
            lblCustomerUpdated.Size = new Size(0, 20);
            lblCustomerUpdated.TabIndex = 19;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(987, 163);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(159, 29);
            btnUpdateCustomer.TabIndex = 20;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // txtBudgetToUpdate
            // 
            txtBudgetToUpdate.Location = new Point(783, 233);
            txtBudgetToUpdate.Name = "txtBudgetToUpdate";
            txtBudgetToUpdate.Size = new Size(198, 27);
            txtBudgetToUpdate.TabIndex = 22;
            // 
            // txtNameToUpdate
            // 
            txtNameToUpdate.Location = new Point(783, 200);
            txtNameToUpdate.Name = "txtNameToUpdate";
            txtNameToUpdate.Size = new Size(198, 27);
            txtNameToUpdate.TabIndex = 21;
            // 
            // lblUpdateBudget
            // 
            lblUpdateBudget.AutoSize = true;
            lblUpdateBudget.Location = new Point(595, 236);
            lblUpdateBudget.Name = "lblUpdateBudget";
            lblUpdateBudget.Size = new Size(127, 20);
            lblUpdateBudget.TabIndex = 24;
            lblUpdateBudget.Text = "Customer Budget:";
            // 
            // lblUpdateName
            // 
            lblUpdateName.AutoSize = true;
            lblUpdateName.Location = new Point(595, 203);
            lblUpdateName.Name = "lblUpdateName";
            lblUpdateName.Size = new Size(112, 20);
            lblUpdateName.TabIndex = 23;
            lblUpdateName.Text = "CustomerName";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 577);
            Controls.Add(lblUpdateBudget);
            Controls.Add(lblUpdateName);
            Controls.Add(txtBudgetToUpdate);
            Controls.Add(txtNameToUpdate);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(lblCustomerUpdated);
            Controls.Add(lblUpdateCustomer);
            Controls.Add(cboCustomerToUpdate);
            Controls.Add(lblDelete);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(lblSelectDelete);
            Controls.Add(cboCustomerIds);
            Controls.Add(btnAddCustomer);
            Controls.Add(lblBudget);
            Controls.Add(lblCustomerName);
            Controls.Add(txtAddBudget);
            Controls.Add(txtAddName);
            Controls.Add(btnSearchId);
            Controls.Add(txtCustomerId);
            Controls.Add(lblEnterId);
            Controls.Add(lblSearchResult);
            Controls.Add(btnSearchMin);
            Controls.Add(txtMinBudget);
            Controls.Add(lblEnterMin);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Customer Name:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Label lblEnterMin;
        private TextBox txtMinBudget;
        private Button btnSearchMin;
        private Label lblSearchResult;
        private Button btnSearchId;
        private TextBox txtCustomerId;
        private Label lblEnterId;
        private TextBox txtAddBudget;
        private TextBox txtAddName;
        private Label lblCustomerName;
        private Label lblBudget;
        private Button btnAddCustomer;
        private ComboBox cboCustomerIds;
        private Label lblSelectDelete;
        private Button btnDeleteCustomer;
        private Label lblDelete;
        private Label lblUpdateCustomer;
        private ComboBox cboCustomerToUpdate;
        private Label lblCustomerUpdated;
        private Button btnUpdateCustomer;
        private TextBox txtBudgetToUpdate;
        private TextBox txtNameToUpdate;
        private Label lblUpdateBudget;
        private Label lblUpdateName;
    }
}
