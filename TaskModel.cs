using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AIEmergencyNavigation.Areas.Identity.Data;

namespace AIEmergencyNavigation.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;

        public DateTime? DueDate { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public AIEmergencyNavigationUser User { get; set; }
    }
}
