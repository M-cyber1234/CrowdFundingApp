using Microsoft.EntityFrameworkCore;

namespace CrowdFundingApp.Models
{
    public class CrowdFundingDbContext : DbContext
    {
        public CrowdFundingDbContext(DbContextOptions<CrowdFundingDbContext> options) : base(options) { }
    }
}
