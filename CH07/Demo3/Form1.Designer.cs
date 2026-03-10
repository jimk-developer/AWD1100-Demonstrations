namespace Demo3_EmployeeLookup
{
    partial class EmployeeLookupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblEmployeeId
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(30, 30);
            this.lblEmployeeId.Text = "Employee ID:";

            // txtEmployeeId
            this.txtEmployeeId.Location = new System.Drawing.Point(150, 27);
            this.txtEmployeeId.Size = new System.Drawing.Size(150, 23);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(30, 70);
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(180, 70);
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(30, 130);
            this.lblResult.Size = new System.Drawing.Size(340, 180);
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 11F);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Text = "Demo 3: Employee Lookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
