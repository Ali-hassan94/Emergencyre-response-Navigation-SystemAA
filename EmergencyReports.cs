using System;

namespace AIEmergencyNavigation.Models
{
    public class EmergencyReports
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // ✅ Accurate Address from Nominatim
        public string? Location { get; set; }

        public string? EmergencyType { get; set; }
        public string? ResponderType { get; set; }
        public string? Status { get; set; }
        public string? UserId { get; set; }

        public DateTime ReportedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
