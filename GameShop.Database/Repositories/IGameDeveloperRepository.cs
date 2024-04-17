using GameShop.Database.Entities;

namespace GameShop.Database.Repositories
{
    public interface IGameDeveloperRepository
    {
        List<GameDeveloper> GetDevelopers();
    }
}
