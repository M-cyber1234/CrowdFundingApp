using Microsoft.EntityFrameworkCore;

namespace CrowdFundingApp.Models
{
    public class CrowdFundingDbContext : DbContext
    {
        public CrowdFundingDbContext(DbContextOptions<CrowdFundingDbContext> options) : base(options) { }
        DbSet<User> Users { get; set; }
        //DbSet<Project> Projects { get; set; }
        DbSet<Category> Categories { get; set; }
        //DbSet<Contribution> Contributions { get; set; }
    }
}
