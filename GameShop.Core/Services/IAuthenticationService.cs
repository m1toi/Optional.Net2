using GameShop.Database.Entities;

namespace GameShop.Core.Services
{
    public interface IAuthenticationService
    {
        string GenerateToken(User user);
    }
}
