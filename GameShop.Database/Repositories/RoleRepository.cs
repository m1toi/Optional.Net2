using GameShop.Database.Context;

namespace GameShop.Database.Repositories
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(GameShopDbContext libraryDbContext) : base(libraryDbContext)
        {
        }

    }
}
