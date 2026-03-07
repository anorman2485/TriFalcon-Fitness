using Microsoft.AspNetCore.Identity;

namespace TriFalcon_Fitness.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Custom fields for the Settings Page
        public string FullName { get; set; }
        public double? CurrentHeight { get; set; } // In inches
        public double? CurrentWeight { get; set; } // In lbs
        public double? BodyFatPercentage { get; set; }
    }
}