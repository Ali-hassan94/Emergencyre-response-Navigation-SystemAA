namespace AIEmergencyNavigation.Models.ViewModels
{
    public class UserDashboardViewModel
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? ProfileImagePath { get; set; }

        public int TotalTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int PendingTasks { get; set; }
    }
}
