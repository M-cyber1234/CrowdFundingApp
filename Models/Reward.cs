using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApp.Models
{
    public class Reward
    {
        [Key]
        public int RewardId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal MinimumContribution { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
