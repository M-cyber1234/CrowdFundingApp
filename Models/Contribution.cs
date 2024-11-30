namespace CrowdFundingApp.Models
{
    public class Contribution
    {
        public int ContributionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        // Relations
        public int UserId { get; set; }
        public User Contributor { get; set; } 

        public int ProjectId { get; set; } 
        public Project Project { get; set; } 

        public Contribution(int contributionId, decimal amount, DateTime date, int userId, User contributor, int projectId, Project project)
        {
            ContributionId = contributionId;
            Amount = amount;
            Date = date;
            UserId = userId;
            Contributor = contributor;
            ProjectId = projectId;
            Project = project;
        }
    }

}
