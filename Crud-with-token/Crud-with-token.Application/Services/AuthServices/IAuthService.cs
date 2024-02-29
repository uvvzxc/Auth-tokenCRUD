namespace Crud_with_token.Application.Services.AuthServices
{
    public interface IAuthService
    {
        public Task<string> GenerateToken(string login, string password);
    }
}
