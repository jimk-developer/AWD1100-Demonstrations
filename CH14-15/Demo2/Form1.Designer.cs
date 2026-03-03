namespace Demo2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.grpVehicleType = new System.Windows.Forms.GroupBox();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radElectric = new System.Windows.Forms.RadioButton();
            this.radLuxury = new System.Windows.Forms.RadioButton();
            this.grpFuelType = new System.Windows.Forms.GroupBox();
            this.radGasoline = new System.Windows.Forms.RadioButton();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.radElectricFuel = new System.Windows.Forms.RadioButton();
            this.radHybrid = new System.Windows.Forms.RadioButton();
            this.grpTrimLevel = new System.Windows.Forms.GroupBox();
            this.radBase = new System.Windows.Forms.RadioButton();
            this.radSport = new System.Windows.Forms.RadioButton();
            this.radPremium = new System.Windows.Forms.RadioButton();
            this.radLuxuryTrim = new System.Windows.Forms.RadioButton();
            this.grpDriveType = new System.Windows.Forms.GroupBox();
            this.radFWD = new System.Windows.Forms.RadioButton();
            this.radRWD = new System.Windows.Forms.RadioButton();
            this.radAWD = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.grpVehicleType.SuspendLayout();
            this.grpFuelType.SuspendLayout();
            this.grpTrimLevel.SuspendLayout();
            this.grpDriveType.SuspendLayout();
            this.SuspendLayout();

            // lblMake
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(20, 20);
            this.lblMake.Text = "Make";

            // txtMake
            this.txtMake.Location = new System.Drawing.Point(80, 17);
            this.txtMake.Size = new System.Drawing.Size(200, 23);

            // lblModel
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(20, 55);
            this.lblModel.Text = "Model";

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(80, 52);
            this.txtModel.Size = new System.Drawing.Size(200, 23);

            // lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(20, 90);
            this.lblYear.Text = "Year";

            // txtYear
            this.txtYear.Location = new System.Drawing.Point(80, 87);
            this.txtYear.Size = new System.Drawing.Size(200, 23);

            // grpVehicleType
            this.grpVehicleType.Controls.Add(this.radStandard);
            this.grpVehicleType.Controls.Add(this.radElectric);
            this.grpVehicleType.Controls.Add(this.radLuxury);
            this.grpVehicleType.Location = new System.Drawing.Point(20, 125);
            this.grpVehicleType.Size = new System.Drawing.Size(260, 55);
            this.grpVehicleType.Text = "Vehicle Type";

            // radStandard
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(10, 25);
            this.radStandard.Text = "Standard";
            this.radStandard.CheckedChanged += new System.EventHandler(this.VehicleType_CheckedChanged);

            // radElectric
            this.radElectric.AutoSize = true;
            this.radElectric.Location = new System.Drawing.Point(95, 25);
            this.radElectric.Text = "Electric/Eco";
            this.radElectric.CheckedChanged += new System.EventHandler(this.VehicleType_CheckedChanged);

            // radLuxury
            this.radLuxury.AutoSize = true;
            this.radLuxury.Location = new System.Drawing.Point(195, 25);
            this.radLuxury.Text = "Luxury";
            this.radLuxury.CheckedChanged += new System.EventHandler(this.VehicleType_CheckedChanged);

            // grpFuelType
            this.grpFuelType.Controls.Add(this.radGasoline);
            this.grpFuelType.Controls.Add(this.radDiesel);
            this.grpFuelType.Controls.Add(this.radElectricFuel);
            this.grpFuelType.Controls.Add(this.radHybrid);
            this.grpFuelType.Location = new System.Drawing.Point(20, 190);
            this.grpFuelType.Size = new System.Drawing.Size(260, 80);
            this.grpFuelType.Text = "Fuel Type";
            this.grpFuelType.Enabled = false;

            // radGasoline
            this.radGasoline.AutoSize = true;
            this.radGasoline.Checked = true;
            this.radGasoline.Location = new System.Drawing.Point(10, 25);
            this.radGasoline.Text = "Gasoline";

            // radDiesel
            this.radDiesel.AutoSize = true;
            this.radDiesel.Location = new System.Drawing.Point(130, 25);
            this.radDiesel.Text = "Diesel";

            // radElectricFuel
            this.radElectricFuel.AutoSize = true;
            this.radElectricFuel.Location = new System.Drawing.Point(10, 50);
            this.radElectricFuel.Text = "Electric";

            // radHybrid
            this.radHybrid.AutoSize = true;
            this.radHybrid.Location = new System.Drawing.Point(130, 50);
            this.radHybrid.Text = "Hybrid";

            // grpTrimLevel
            this.grpTrimLevel.Controls.Add(this.radBase);
            this.grpTrimLevel.Controls.Add(this.radSport);
            this.grpTrimLevel.Controls.Add(this.radPremium);
            this.grpTrimLevel.Controls.Add(this.radLuxuryTrim);
            this.grpTrimLevel.Location = new System.Drawing.Point(20, 280);
            this.grpTrimLevel.Size = new System.Drawing.Size(125, 130);
            this.grpTrimLevel.Text = "Trim Level";
            this.grpTrimLevel.Enabled = false;

            // radBase
            this.radBase.AutoSize = true;
            this.radBase.Checked = true;
            this.radBase.Location = new System.Drawing.Point(10, 25);
            this.radBase.Text = "Base";

            // radSport
            this.radSport.AutoSize = true;
            this.radSport.Location = new System.Drawing.Point(10, 50);
            this.radSport.Text = "Sport";

            // radPremium
            this.radPremium.AutoSize = true;
            this.radPremium.Location = new System.Drawing.Point(10, 75);
            this.radPremium.Text = "Premium";

            // radLuxuryTrim
            this.radLuxuryTrim.AutoSize = true;
            this.radLuxuryTrim.Location = new System.Drawing.Point(10, 100);
            this.radLuxuryTrim.Text = "Luxury";

            // grpDriveType
            this.grpDriveType.Controls.Add(this.radFWD);
            this.grpDriveType.Controls.Add(this.radRWD);
            this.grpDriveType.Controls.Add(this.radAWD);
            this.grpDriveType.Location = new System.Drawing.Point(155, 280);
            this.grpDriveType.Size = new System.Drawing.Size(125, 105);
            this.grpDriveType.Text = "Drive Type";
            this.grpDriveType.Enabled = false;

            // radFWD
            this.radFWD.AutoSize = true;
            this.radFWD.Checked = true;
            this.radFWD.Location = new System.Drawing.Point(10, 25);
            this.radFWD.Text = "FWD";

            // radRWD
            this.radRWD.AutoSize = true;
            this.radRWD.Location = new System.Drawing.Point(10, 50);
            this.radRWD.Text = "RWD";

            // radAWD
            this.radAWD.AutoSize = true;
            this.radAWD.Location = new System.Drawing.Point(10, 75);
            this.radAWD.Text = "AWD";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(20, 420);
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblCost
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCost.Location = new System.Drawing.Point(135, 418);
            this.lblCost.Text = "";

            // lblDetails
            this.lblDetails.Location = new System.Drawing.Point(20, 460);
            this.lblDetails.Size = new System.Drawing.Size(260, 25);
            this.lblDetails.Text = "";
            this.lblDetails.ForeColor = System.Drawing.Color.Gray;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.grpVehicleType);
            this.Controls.Add(this.grpFuelType);
            this.Controls.Add(this.grpTrimLevel);
            this.Controls.Add(this.grpDriveType);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDetails);
            this.Name = "Form1";
            this.Text = "Vehicle Rental";
            this.grpVehicleType.ResumeLayout(false);
            this.grpVehicleType.PerformLayout();
            this.grpFuelType.ResumeLayout(false);
            this.grpFuelType.PerformLayout();
            this.grpTrimLevel.ResumeLayout(false);
            this.grpTrimLevel.PerformLayout();
            this.grpDriveType.ResumeLayout(false);
            this.grpDriveType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox grpVehicleType;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radElectric;
        private System.Windows.Forms.RadioButton radLuxury;
        private System.Windows.Forms.GroupBox grpFuelType;
        private System.Windows.Forms.RadioButton radGasoline;
        private System.Windows.Forms.RadioButton radDiesel;
        private System.Windows.Forms.RadioButton radElectricFuel;
        private System.Windows.Forms.RadioButton radHybrid;
        private System.Windows.Forms.GroupBox grpTrimLevel;
        private System.Windows.Forms.RadioButton radBase;
        private System.Windows.Forms.RadioButton radSport;
        private System.Windows.Forms.RadioButton radPremium;
        private System.Windows.Forms.RadioButton radLuxuryTrim;
        private System.Windows.Forms.GroupBox grpDriveType;
        private System.Windows.Forms.RadioButton radFWD;
        private System.Windows.Forms.RadioButton radRWD;
        private System.Windows.Forms.RadioButton radAWD;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDetails;
    }
}
