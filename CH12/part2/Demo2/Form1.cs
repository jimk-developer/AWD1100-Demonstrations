using Demo2_Appointments;

namespace Demo2
{
    public partial class Form1 : Form
    {
        // Array of appointments and counter
        private Appointment[] appointments = new Appointment[20];
        private int appointmentCount = 0;

        // Available services and stylists
        private string[] services = { "Haircut", "Color", "Highlights", "Perm", "Blowout", "Trim" };
        private string[] stylists = { "Maria", "James", "Sophie", "Alex" };

        public Form1()
        {
            InitializeComponent();
            LoadOptions();
            UpdateDisplay();
        }

        // Load dropdown options
        private void LoadOptions()
        {
            cmbService.Items.AddRange(services);
            cmbService.SelectedIndex = 0;

            cmbStylist.Items.AddRange(stylists);
            cmbStylist.SelectedIndex = 0;

            // Set date pickers to today
            dtpAppointment.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now.AddDays(-7);
            dtpEndDate.Value = DateTime.Now.AddDays(7);
        }

        // Add Appointment button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate client name
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                lblStatus.Text = "Please enter client name";
                return;
            }

            // Validate duration
            int duration;
            if (!int.TryParse(txtDuration.Text, out duration) || duration <= 0)
            {
                lblStatus.Text = "Please enter valid duration";
                return;
            }

            // Check if array is full
            if (appointmentCount >= appointments.Length)
            {
                lblStatus.Text = "Maximum appointments reached!";
                return;
            }

            // Create new Appointment object using auto-implemented properties
            Appointment newAppointment = new Appointment(
                txtClientName.Text.Trim(),
                dtpAppointment.Value,
                cmbService.SelectedItem.ToString(),
                duration,
                cmbStylist.SelectedItem.ToString()
            );

            // Add to array
            appointments[appointmentCount] = newAppointment;
            appointmentCount++;

            // Update display
            lblStatus.Text = "Appointment added successfully!";
            UpdateDisplay();

            // Clear fields and set focus
            txtClientName.Clear();
            txtDuration.Clear();
            txtClientName.Focus();
        }

        // Search by date range button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1); // End of day

            if (startDate > endDate)
            {
                lblSearchResult.Text = "Start date must be before end date";
                return;
            }

            string results = $"Appointments from {startDate:MM/dd/yyyy} to {dtpEndDate.Value:MM/dd/yyyy}:\n";
            results += "════════════════════════════════════\n\n";

            int found = 0;

            for (int i = 0; i < appointmentCount; i++)
            {
                // Check if appointment date is within range
                if (appointments[i].AppointmentDate >= startDate &&
                    appointments[i].AppointmentDate <= endDate)
                {
                    results += appointments[i].Display() + "\n";
                    found++;
                }
            }

            if (found == 0)
            {
                results += "No appointments found in this date range.";
            }
            else
            {
                results += $"\n({found} appointment(s) found)";
            }

            lblSearchResult.Text = results;
        }

        // Update the main display with all appointments
        private void UpdateDisplay()
        {
            if (appointmentCount == 0)
            {
                lblAllAppointments.Text = "No appointments scheduled.";
                return;
            }

            string output = "All Appointments:\n";
            output += "════════════════════════════════════\n\n";

            for (int i = 0; i < appointmentCount; i++)
            {
                output += $"{i + 1}. {appointments[i].Display()}\n";
            }

            lblAllAppointments.Text = output;
        }

        // Show All button click
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
            lblSearchResult.Text = "";
        }
    }
}
