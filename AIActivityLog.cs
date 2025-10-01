using System;

namespace AIEmergencyNavigation.Models
{
    public class AIActivityLog
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public required string ActionType { get; set; } // "Status Updated", "Responder Assigned"
        public required string PerformedBy { get; set; } // User.Identity.Name or AI Engine
        public DateTime PerformedAt { get; set; }
        public required string OldValue { get; set; }
        public required string NewValue { get; set; }
    }
}
