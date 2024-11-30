namespace CrowdFundingApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Creator" or "Contributor"
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public User() { }
        public User(int userId, string name, string email, string password, string role, DateTime createdAt)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            CreatedAt = createdAt;
        }
    }
}
