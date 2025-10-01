using System;

namespace AIEmergencyNavigation.Models
{
    public class RouteSuggestion
    {
        public int Id { get; set; }
        public required string EmergencyType { get; set; }
        public required string CurrentLocation { get; set; }
        public string? ToLocation { get; set; } // ✅ Optional
        public string? SuggestedRoute { get; set; } // ✅ Make it nullable
        public DateTime SuggestedAt { get; set; } = DateTime.Now;

        public double CurrentLat { get; set; }
        public double CurrentLng { get; set; }

    }
}
