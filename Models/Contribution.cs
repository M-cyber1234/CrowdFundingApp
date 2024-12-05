using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApp.Models
{
    public class Contribution
    {
        [Key]
        public int ContributionId { get; set; }

        [Required]
        public double Amount { get; set; }

        public DateTime ContributionDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }

}
