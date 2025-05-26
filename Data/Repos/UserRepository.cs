
using Inlämning1Tomasso.Data.Models;

using inlämning1Tomasso.Data.Interface.Repositories;


namespace Inlämning1Tomasso.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TomassoDbContext _context;

        public UserRepository(TomassoDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userID)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserID == userID);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.UserID == user.UserID);
            if (existingUser != null)
            {
                _context.Entry(existingUser).CurrentValues.SetValues(user);
                _context.SaveChanges();
            }
        }

        public User GetUserById(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.UserID == userId);
        }
    }
}
