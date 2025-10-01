namespace AIEmergencyNavigation.Models
{
    public class RouteHistory
    {
        public int Id { get; set; }

        public required string UserId { get; set; }  // ✅ Only this one

        public required string CurrentLocation { get; set; }

        public required string ToLocation { get; set; }

        public required string EmergencyType { get; set; }

        public required string SuggestedRoute { get; set; }

        public DateTime SuggestedAt { get; set; }
    }
}
