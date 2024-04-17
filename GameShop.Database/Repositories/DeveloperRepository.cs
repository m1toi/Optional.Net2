using GameShop.Database.Context;

namespace GameShop.Database.Repositories
{
    public class GameDeveloperRepository:BaseRepository,IGameDeveloperRepository
    {
        public GameDeveloperRepository(GameShopDbContext gameShopDbContext):base(gameShopDbContext)
        {

        }
    }
}
