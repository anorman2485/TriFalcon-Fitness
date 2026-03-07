using System.ComponentModel.DataAnnotations;

namespace TriFalcon_Fitness.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } // Links to the logged-in user

        [Required]
        [Display(Name = "Activity Type")]
        public string ActivityType { get; set; } // e.g., Strength, Cardio, Flexibility

        [Required]
        [Display(Name = "Exercise Name")]
        public string ExerciseName { get; set; } // e.g., Bench Press, 5K Run

        // Strength Metrics (Nullable in case it's a cardio workout)
        public double? Weight { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }

        // Cardio Metrics (Nullable in case it's a strength workout)
        public double? Distance { get; set; } // in Miles
        public int? DurationMinutes { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLogged { get; set; } = DateTime.Now;
    }
}