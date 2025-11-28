using System.Security.Cryptography;
using System.Text;

namespace ApiEmpresa.Services
{
    public class PasswordService
    {
        public string Hash(string password)
        {
            var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
