namespace CrowdFundingApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public User() { }
        public User(int userId, string name, string email, string password, DateTime createdAt)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
        }
    }
}
