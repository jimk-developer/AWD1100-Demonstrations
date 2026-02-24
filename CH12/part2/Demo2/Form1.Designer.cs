namespace Demo2
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
            this.grpAddAppointment = new System.Windows.Forms.GroupBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblStylist = new System.Windows.Forms.Label();
            this.cmbStylist = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.grpAllAppointments = new System.Windows.Forms.GroupBox();
            this.lblAllAppointments = new System.Windows.Forms.Label();
            this.grpAddAppointment.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpAllAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddAppointment
            // 
            this.grpAddAppointment.Controls.Add(this.lblClientName);
            this.grpAddAppointment.Controls.Add(this.txtClientName);
            this.grpAddAppointment.Controls.Add(this.lblDate);
            this.grpAddAppointment.Controls.Add(this.dtpAppointment);
            this.grpAddAppointment.Controls.Add(this.lblService);
            this.grpAddAppointment.Controls.Add(this.cmbService);
            this.grpAddAppointment.Controls.Add(this.lblDuration);
            this.grpAddAppointment.Controls.Add(this.txtDuration);
            this.grpAddAppointment.Controls.Add(this.lblMinutes);
            this.grpAddAppointment.Controls.Add(this.lblStylist);
            this.grpAddAppointment.Controls.Add(this.cmbStylist);
            this.grpAddAppointment.Controls.Add(this.btnAdd);
            this.grpAddAppointment.Controls.Add(this.lblStatus);
            this.grpAddAppointment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAddAppointment.Location = new System.Drawing.Point(20, 20);
            this.grpAddAppointment.Name = "grpAddAppointment";
            this.grpAddAppointment.Size = new System.Drawing.Size(320, 310);
            this.grpAddAppointment.TabIndex = 0;
            this.grpAddAppointment.TabStop = false;
            this.grpAddAppointment.Text = "Add Appointment";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(15, 30);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(86, 19);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Client Name:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(15, 52);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(290, 25);
            this.txtClientName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 85);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date/Time:";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "MM/dd/yyyy h:mm tt";
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointment.Location = new System.Drawing.Point(15, 107);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(290, 25);
            this.dtpAppointment.TabIndex = 3;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(15, 140);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(53, 19);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service:";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(15, 162);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(140, 25);
            this.cmbService.TabIndex = 5;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(165, 140);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(62, 19);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(165, 162);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(80, 25);
            this.txtDuration.TabIndex = 7;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(250, 165);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(33, 19);
            this.lblMinutes.TabIndex = 8;
            this.lblMinutes.Text = "min";
            // 
            // lblStylist
            // 
            this.lblStylist.AutoSize = true;
            this.lblStylist.Location = new System.Drawing.Point(15, 195);
            this.lblStylist.Name = "lblStylist";
            this.lblStylist.Size = new System.Drawing.Size(49, 19);
            this.lblStylist.TabIndex = 9;
            this.lblStylist.Text = "Stylist:";
            // 
            // cmbStylist
            // 
            this.cmbStylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStylist.FormattingEnabled = true;
            this.cmbStylist.Location = new System.Drawing.Point(15, 217);
            this.cmbStylist.Name = "cmbStylist";
            this.cmbStylist.Size = new System.Drawing.Size(140, 25);
            this.cmbStylist.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Appointment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(165, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 40);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblStartDate);
            this.grpSearch.Controls.Add(this.dtpStartDate);
            this.grpSearch.Controls.Add(this.lblEndDate);
            this.grpSearch.Controls.Add(this.dtpEndDate);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnShowAll);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpSearch.Location = new System.Drawing.Point(20, 340);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(320, 140);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search by Date Range";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(15, 30);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 19);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(15, 52);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(130, 25);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(160, 30);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 19);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(160, 52);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(130, 25);
            this.dtpEndDate.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(125, 90);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 35);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblSearchResult);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpResults.Location = new System.Drawing.Point(360, 20);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(400, 220);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Search Results";
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblSearchResult.Location = new System.Drawing.Point(10, 25);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(380, 185);
            this.lblSearchResult.TabIndex = 0;
            this.lblSearchResult.Text = "";
            // 
            // grpAllAppointments
            // 
            this.grpAllAppointments.Controls.Add(this.lblAllAppointments);
            this.grpAllAppointments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAllAppointments.Location = new System.Drawing.Point(360, 250);
            this.grpAllAppointments.Name = "grpAllAppointments";
            this.grpAllAppointments.Size = new System.Drawing.Size(400, 230);
            this.grpAllAppointments.TabIndex = 3;
            this.grpAllAppointments.TabStop = false;
            this.grpAllAppointments.Text = "All Appointments";
            // 
            // lblAllAppointments
            // 
            this.lblAllAppointments.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblAllAppointments.Location = new System.Drawing.Point(10, 25);
            this.lblAllAppointments.Name = "lblAllAppointments";
            this.lblAllAppointments.Size = new System.Drawing.Size(380, 195);
            this.lblAllAppointments.TabIndex = 0;
            this.lblAllAppointments.Text = "No appointments scheduled.";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.grpAddAppointment);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpAllAppointments);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo 2: Appointment Scheduler";
            this.grpAddAppointment.ResumeLayout(false);
            this.grpAddAppointment.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpAllAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddAppointment;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblStylist;
        private System.Windows.Forms.ComboBox cmbStylist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.GroupBox grpAllAppointments;
        private System.Windows.Forms.Label lblAllAppointments;
    }
}