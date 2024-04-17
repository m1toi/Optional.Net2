using GameShop.Database.Context;

namespace GameShop.Database.Repositories
{
    public class BaseRepository
    {
        protected GameShopDbContext _gameShopDbContext { get; set; }

        public BaseRepository(GameShopDbContext libraryDbContext)
        {
            this._gameShopDbContext = libraryDbContext;
        }

        public void SaveChanges()
        {
            _gameShopDbContext.SaveChanges();
        }

    }
}
