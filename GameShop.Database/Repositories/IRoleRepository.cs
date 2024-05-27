using GameShop.Database.Entities;

namespace GameShop.Database.Repositories
{
    public interface IRoleRepository
    {
        List<Role> GetAll();
        void Create(Role role);
    }
}
