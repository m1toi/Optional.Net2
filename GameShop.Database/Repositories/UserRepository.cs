using GameShop.Database.Context;

namespace GameShop.Database.Repositories
{
    public class UserRepository : BaseRepository , IUserRepository
    {
        public UserRepository(GameShopDbContext libraryDbContext) : base(libraryDbContext)
        {
        }
    }
    
   
}
