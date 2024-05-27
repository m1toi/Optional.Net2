using System.Security.Cryptography;
using GameShop.Database.Context;
using GameShop.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Database.Repositories
{
    public class UserRepository : BaseRepository , IUserRepository
    {
        public UserRepository(GameShopDbContext gameShopDbContext) : base(gameShopDbContext)
        {
        }

        public List<User> GetAll()
        {
            return _gameShopDbContext.Users.ToList();
        }

        public User GetUserByEmail(string email)
        {
            var user = _gameShopDbContext.Users
                                        .Where(u => u.Email == email)
                                        .Include(u => u.Role)
                                        .FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found");
            }

            return user;
        }

        public void RegisterUser(User user)
        {
            if(_gameShopDbContext.Users.Any(u => u.Email == user.Email))
            {
                throw new Exception("User already exists");
            }
            _gameShopDbContext.Add(user);
            SaveChanges();
        }
    }
    
   
}
