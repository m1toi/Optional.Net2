using GameShop.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Database.Context
{
    public class GameShopDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameDeveloper> Developers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public GameShopDbContext(DbContextOptions<GameShopDbContext> options) : base(options) { }

    }
}
