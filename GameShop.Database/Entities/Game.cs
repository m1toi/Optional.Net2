namespace GameShop.Database.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual GameDeveloper Developer { get; set; }
    }
}
