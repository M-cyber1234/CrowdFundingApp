using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApp.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal GoalAmount { get; set; }

        public decimal CurrentAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Category")]

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Contribution> Contributions { get; set; }
        public ICollection<Reward> Rewards { get; set; }
    }

}
