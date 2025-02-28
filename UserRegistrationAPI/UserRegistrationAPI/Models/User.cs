namespace UserRegistrationAPI.Models
{
    public class User
    {
        public int Id { get; set; }            // Unique identifier for the user
        public string FullName { get; set; }     // Full name of the user
        public string Email { get; set; }        // Email address (used as username)
        public string Password { get; set; }     // Password (for demonstration only – do not store plain text)
    }
}
