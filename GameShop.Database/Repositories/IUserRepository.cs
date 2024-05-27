using GameShop.Database.Entities;

namespace GameShop.Database.Repositories
{
     public interface IUserRepository
     {
        void RegisterUser(User user);

        User GetEmail (string email);
        List<User> GetAll();

     }
}
