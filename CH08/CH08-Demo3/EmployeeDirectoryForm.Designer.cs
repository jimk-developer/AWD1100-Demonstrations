namespace CH08_Demo3
{
    partial class EmployeeDirectoryForm
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
            txtSearch = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lblNameLabel = new Label();
            lblName = new Label();
            lblDeptLabel = new Label();
            lblDepartment = new Label();
            label3 = new Label();
            lblExtension = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(182, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter a search term:";
            // 
            // button1
            // 
            button1.Location = new Point(187, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNameLabel
            // 
            lblNameLabel.AutoSize = true;
            lblNameLabel.Location = new Point(38, 142);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(52, 20);
            lblNameLabel.TabIndex = 3;
            lblNameLabel.Text = "Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(146, 142);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 4;
            lblName.Text = "label2";
            // 
            // lblDeptLabel
            // 
            lblDeptLabel.AutoSize = true;
            lblDeptLabel.Location = new Point(38, 178);
            lblDeptLabel.Name = "lblDeptLabel";
            lblDeptLabel.Size = new Size(92, 20);
            lblDeptLabel.TabIndex = 5;
            lblDeptLabel.Text = "Department:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(146, 178);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(50, 20);
            lblDepartment.TabIndex = 6;
            lblDepartment.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 217);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Extension:";
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.Location = new Point(146, 217);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(50, 20);
            lblExtension.TabIndex = 8;
            lblExtension.Text = "label3";
            // 
            // EmployeeDirectoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblExtension);
            Controls.Add(label3);
            Controls.Add(lblDepartment);
            Controls.Add(lblDeptLabel);
            Controls.Add(lblName);
            Controls.Add(lblNameLabel);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Name = "EmployeeDirectoryForm";
            Text = "Employee Directory Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private Button button1;
        private Label lblNameLabel;
        private Label lblName;
        private Label lblDeptLabel;
        private Label lblDepartment;
        private Label label3;
        private Label lblExtension;
    }
}
