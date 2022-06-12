using Microsoft.EntityFrameworkCore;
using DataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DataLayer.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormElement> FormElements { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = Role.Admin.ToString(), NormalizedName = Role.Admin.ToString().ToUpper() },
                new IdentityRole { Name = Role.Servicer.ToString(), NormalizedName = Role.Servicer.ToString().ToUpper() },
                new IdentityRole { Name = Role.Client.ToString(), NormalizedName = Role.Client.ToString().ToUpper() });
        }
    }
}
