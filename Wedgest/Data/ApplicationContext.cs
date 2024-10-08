using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Wedgest.Entities;

namespace Wedgest.Data
{
    public class ApplicationContext : DbContext
    {
        #region Constractur
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        #endregion
        #region HandleUser
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
           new User { id = 1, userName = "Mohamed", job="admin" },
           new User { id = 2, userName = "Mostafa", job="student" }
       );

            builder.Entity<User>()
                .HasIndex(e => e.userName)
                .IsUnique();
        }

        #endregion


        public DbSet<User> user { get; set; }
        public DbSet<Ticket>Ticket { get; set; }
    }
}
