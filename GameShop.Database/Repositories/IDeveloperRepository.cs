using GameShop.Database.Entities;

namespace GameShop.Database.Repositories
{
    public interface IDeveloperRepository
    {
        List<GameDeveloper> GetDevelopers();
    }
}
