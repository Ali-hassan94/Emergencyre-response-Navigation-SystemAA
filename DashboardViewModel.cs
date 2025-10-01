namespace AIEmergencyNavigation.Models
{
    public class DashboardViewModel
    {
        public string? UserId { get; set; }

        public int TotalReports { get; set; }

        public int TotalRoutes { get; set; }

        public required List<EmergencyReports> LatestReports { get; set; }

        public required List<RouteSuggestion> LatestRoutes { get; set; }

        public List<RouteSuggestion> SuggestedRoutesHistory { get; set; }
        // ✅ Step 55 Added


        public List<EmergencyReports> LatestAlerts { get; set; }

    }
}
