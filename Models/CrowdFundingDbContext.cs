using CrowdFundingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrowdFundingApp.Models
{
    public class CrowdFundingDbContext : DbContext
    {
        public CrowdFundingDbContext(DbContextOptions<CrowdFundingDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Category> Categories { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Projects)
        //        .WithOne(p => p.User)
        //        .HasForeignKey(p => p.UserId);

        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Contributions)
        //        .WithOne(c => c.User)
        //        .HasForeignKey(c => c.UserId);

        //    modelBuilder.Entity<Project>()
        //        .HasMany(p => p.Contributions)
        //        .WithOne(c => c.Project)
        //        .HasForeignKey(c => c.ProjectId);

        //    modelBuilder.Entity<Project>()
        //        .HasMany(p => p.Rewards)
        //        .WithOne(r => r.Project)
        //        .HasForeignKey(r => r.ProjectId);

        //    modelBuilder.Entity<Category>()
        //        .HasMany(c => c.Projects)
        //        .WithOne(p => p.Category)
        //        .HasForeignKey(p => p.CategoryId);
        //}
    }
}