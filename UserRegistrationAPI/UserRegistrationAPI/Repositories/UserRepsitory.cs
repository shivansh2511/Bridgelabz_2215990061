using System.Collections.Generic;
using System.Linq;
using UserRegistrationAPI.Models;

namespace UserRegistrationAPI.Repositories
{
    public static class UserRepository
    {
        // In-memory list to store users.
        private static List<User> _users = new List<User>();
        private static int _nextId = 1;

        // Returns all users.
        public static IEnumerable<User> GetAll() => _users;

        // Adds a new user to the list.
        public static User Add(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
            return user;
        }

        // (Optional) Find a user by email.
        public static User GetByEmail(string email) =>
            _users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
    }
}
