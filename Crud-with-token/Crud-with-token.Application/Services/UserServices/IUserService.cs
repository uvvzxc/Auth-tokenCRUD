using Crud_with_token.Domain.Models.AuthModels;

namespace Crud_with_token.Application.Services.UserServices
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<string> DeleteUser(int id);
        Task<string> UpdateUser(int id, User user);
        Task<string> CreateUser(User user);
    }
}
