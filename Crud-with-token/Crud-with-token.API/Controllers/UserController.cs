using Crud_with_token.API.Attributes;
using Crud_with_token.Application.Services.UserServices;
using Crud_with_token.Domain.Models.AuthModels;
using Crud_with_token.Domain.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crud_with_token.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _usersService;

        public UsersController(IUserService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [IdentityFilter(Permission.GetAllUsers)]
        public Task<List<User>> GetAllUsers()
        {
            var res = _usersService.GetAllUsers();
            return res;
        }
        [HttpGet]
        [IdentityFilter(Permission.GetUsersById)]
        public Task<User> GetUsersById(int id)
        {
            Task<User>? res = _usersService.GetUserById(id);
            return res;
        }
        [HttpPost]
        [IdentityFilter(Permission.CreateUser)]
        public Task<string> CreateUser(User user)
        {
            Task<string> res = _usersService.CreateUser(user);
            return res;
        }
        [HttpPut]
        [IdentityFilter(Permission.UpdateUser)]
        public Task<string> UpdateUser(int id, User user)
        {
            var res = _usersService.UpdateUser(id, user);
            return res;
        }
        [HttpDelete]
        [IdentityFilter(Permission.DeleteUser)]
        public Task<string> DeleteUser(int id)
        {
            Task<string> res = _usersService.DeleteUser(id);
            return res;
        }
    }
}