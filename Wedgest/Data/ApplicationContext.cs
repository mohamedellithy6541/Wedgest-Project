using Microsoft.EntityFrameworkCore;
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
            builder.Entity<User>()
                .HasIndex(e => e.userName)
                .IsUnique();
        }

        #endregion


        public DbSet<User> user { get; set; }
        public DbSet<Ticket>Ticket { get; set; }
    }
}
