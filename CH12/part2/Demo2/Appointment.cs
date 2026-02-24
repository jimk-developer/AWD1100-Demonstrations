using System;

namespace Demo2_Appointments
{
    /// <summary>
    /// Represents an appointment in the scheduling system.
    /// Uses AUTO-IMPLEMENTED PROPERTIES as required.
    /// </summary>
    public class Appointment
    {
        // Auto-implemented properties
        public string ClientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Service { get; set; }
        public int DurationMinutes { get; set; }
        public string Stylist { get; set; }

        // Constructor
        public Appointment(string clientName, DateTime date, string service, int duration, string stylist)
        {
            ClientName = clientName;
            AppointmentDate = date;
            Service = service;
            DurationMinutes = duration;
            Stylist = stylist;
        }

        /// <summary>
        /// Returns a formatted string for display.
        /// Format: "{date} - {clientName} with {stylist} ({service}, {duration} min)"
        /// </summary>
        public string Display()
        {
            return $"{AppointmentDate:MM/dd/yyyy h:mm tt} - {ClientName} with {Stylist} ({Service}, {DurationMinutes} min)";
        }
    }
}
