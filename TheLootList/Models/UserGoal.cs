using System.ComponentModel.DataAnnotations;

namespace TriFalcon_Fitness.Models
{
    public class UserGoal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Goal Description")]
        public string GoalName { get; set; } // e.g., "Hit 225lb Bench" or "Sub-20min 5K"

        [Required]
        public double TargetValue { get; set; } // The numeric target

        [Required]
        [DataType(DataType.Date)]
        public DateTime TargetDate { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}