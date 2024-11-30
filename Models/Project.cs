namespace CrowdFundingApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public decimal TargetAmount { get; set; } 
        public decimal CollectedAmount { get; set; } 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 

        // Relations
        public int UserId { get; set; }
        public User Creator { get; set; }
        public Project(int projectId, string title, string description, decimal targetAmount, decimal collectedAmount, DateTime startDate, DateTime endDate, int userId, User creator)
        {
            ProjectId = projectId;
            Title = title;
            Description = description;
            TargetAmount = targetAmount;
            CollectedAmount = collectedAmount;
            StartDate = startDate;
            EndDate = endDate;
            UserId = userId;
            Creator = creator;
        }
    }

}
