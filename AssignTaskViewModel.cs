using System.ComponentModel.DataAnnotations;
using AIEmergencyNavigation.Areas.Identity.Data;

namespace AIEmergencyNavigation.Models.ViewModels
{
    public class AssignTaskViewModel
    {
        [Required(ErrorMessage = "Please choose a user")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Task title is required")]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        public List<AIEmergencyNavigationUser>? Users { get; set; }
    }
}