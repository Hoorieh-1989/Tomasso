using Inlämning1Tomasso.Data.DTOs;


namespace Inlämning1Tomasso.Data.Interface.Services
{
    public interface IUserService
    {
        bool CreateUser(CreateUserDto dto);
        string Authenticate(string userName, string password);
        GetUserDto GetById(int id);
        void UpdateUser(int id, CreateUserDto dto);
        void DeleteUser(int id);
    }
}
