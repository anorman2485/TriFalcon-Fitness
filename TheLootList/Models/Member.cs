using System.ComponentModel.DataAnnotations;

namespace TriFalcon_Fitness.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Membership Type")]
        public string MembershipType { get; set; } // e.g., Basic, Pro, Elite
    }
}