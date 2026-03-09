using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TriFalcon_Fitness.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }

        [Range(1, 120, ErrorMessage = "Height must be between 1 and 120 inches")]
        public double Height { get; set; }

        [Range(1, 1000, ErrorMessage = "Weight must be between 1 and 1000 lbs")]
        public double Weight { get; set; }

        public int Age { get; set; }

        // --- GOAL PROPERTIES ---
        public double GoalWeight { get; set; }

        public string? TargetExercise { get; set; }
        public double TargetStrengthWeight { get; set; }

        public string? TargetCardioType { get; set; }
        public double TargetDistance { get; set; }
        public int TargetDuration { get; set; }
    }
}