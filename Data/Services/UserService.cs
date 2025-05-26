
using System.Security.Cryptography;
using System.Text;

using Inlämning1Tomasso.Data.Interface.Services;
using Inlämning1Tomasso.Data.Models;
using inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data;

using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Keys;


public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly TomassoDbContext _db;
    private readonly IConfiguration _configuration;

    public UserService(IUserRepository userRepository, TomassoDbContext dbContext, IConfiguration configuration)
    {
        _userRepository = userRepository;
        _db = dbContext;
        _configuration = configuration;
    }

    public bool CreateUser(CreateUserDto dto)
    {
        var existing = _db.Users.SingleOrDefault(u => u.Email == dto.CreateUserEmail);
        if (existing != null)
            return false;

        var hashedPassword = HashPassword(dto.CreatePassword);

        var user = new User
        {
            UserName = dto.CreateUserName,
            Email = dto.CreateUserEmail,
            Password = hashedPassword,
            Phone = dto.CreateUserPhone
        };

        _userRepository.AddUser(user);
        return true;
    }

    public string Authenticate(string userName, string password)
    {
        var user = _db.Users.SingleOrDefault(u => u.UserName.ToLower() == userName.ToLower());
        if (user == null)
            return null;

        var hashedInputPassword = HashPassword(password);
        if (user.Password != hashedInputPassword)
            return null;

        return JwtToken.GenerateToken(user, _configuration);
    }

    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    public GetUserDto GetById(int id)
    {
        var user = _userRepository.GetUserById(id);
        if (user == null)
            return null;

        return new GetUserDto
        {
            UserID = user.UserID,
            UserName = user.UserName,

        };
    }
    public void UpdateUser(int id, CreateUserDto dto)
    {
        var hashedPassword = HashPassword(dto.CreatePassword);

        var user = new User
        {
            UserID = id,
            UserName = dto.CreateUserName,
            Email = dto.CreateUserEmail,
            Password = hashedPassword,
            Phone = dto.CreateUserPhone
        };

        _userRepository.UpdateUser(user);
    }
    public void DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
    }

}