using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace inlämning1Tomasso.Data.Repos
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
            var user = _context.Users.SingleOrDefault(u => u.UserID == userID);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<User> GetAllUsers(int userID) // Om du vill hämta en specifik användare, byt namn
        {
            return _context.Users.ToList();
        }

        public void UpdateUser(User user)
        {
            var existing = _context.Users.SingleOrDefault(u => u.UserID == user.UserID);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(user);
                _context.SaveChanges();
            }
        }
    }
}
