using CrowdFundingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrowdFundingApp.Models
{
    public class CrowdFundingDbContext : DbContext
    {
        public CrowdFundingDbContext(DbContextOptions<CrowdFundingDbContext> options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }
        //DbSet<Project> Projects { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        //DbSet<Contribution> Contributions { get; set; }

    }
}