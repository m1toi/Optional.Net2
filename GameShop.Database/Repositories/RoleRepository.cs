using GameShop.Database.Context;
using GameShop.Database.Entities;

namespace GameShop.Database.Repositories
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(GameShopDbContext gameShopDbContext) : base(gameShopDbContext)
        {
        }

        public List<Role> GetAll()
        {
            return _gameShopDbContext.Roles.ToList();
        }

        public void Create(Role role)
        {
            if (_gameShopDbContext.Roles.Any(r => r.Name == role.Name))
            {
                throw new Exception("Role already exists");
            }
            _gameShopDbContext.Roles.Add(role);
            SaveChanges();
        }

    }
}
    