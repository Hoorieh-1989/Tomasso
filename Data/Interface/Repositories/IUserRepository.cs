using inlämning1Tomasso.Data.Models;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IUserRepository
    {

        void AddUser(User user);
        void UpdateUser(User userID);

        void DeleteUser(int userID);

       List<User> GetAllUsers(int userID);

    }
}
