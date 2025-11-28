using ApiEmpresa.Models;

namespace ApiEmpresa.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string userName);
        Task<User> RegisterAsync(User user);
    }
}
