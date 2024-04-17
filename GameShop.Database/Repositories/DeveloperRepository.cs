using GameShop.Database.Context;
using GameShop.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Database.Repositories
{
    public class DeveloperRepository : BaseRepository, IDeveloperRepository
    {
        public DeveloperRepository(GameShopDbContext gameShopDbContext):base(gameShopDbContext)
        {

        }

        public List<GameDeveloper> GetDevelopers()
        {
            var developers = _gameShopDbContext.Developers
                .Include(d => d.Games)
                .AsNoTracking()
                .ToList();

            return developers;
        }
    }
}
