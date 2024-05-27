using GameShop.Database.Context;

namespace GameShop.Database.Repositories
{
    public class BaseRepository
    {
        protected readonly GameShopDbContext _gameShopDbContext;

        public BaseRepository(GameShopDbContext gameShopDbContext)
        {
            this._gameShopDbContext = gameShopDbContext;
        }

        public void SaveChanges()
        {
            _gameShopDbContext.SaveChanges();
        }

    }
}
