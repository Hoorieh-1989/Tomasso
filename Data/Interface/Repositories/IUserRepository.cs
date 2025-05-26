

using Inlämning1Tomasso.Data.Models;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IUserRepository
    {

        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        User GetUserById(int userId);
    }
}
