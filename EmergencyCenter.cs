using System.ComponentModel.DataAnnotations;

namespace AIEmergencyNavigation.Models
{
    public class EmergencyCenter
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; } // Hospital, Police, Fire

        public string Address { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
    }
}
