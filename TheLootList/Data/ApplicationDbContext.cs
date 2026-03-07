using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TriFalcon_Fitness.Models; 

namespace TriFalcon_Fitness.Data
{
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }

      
        public DbSet<Member> Members { get; set; }
    }
}