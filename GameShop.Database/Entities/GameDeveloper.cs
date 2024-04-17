namespace GameShop.Database.Entities
{
    public class GameDeveloper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Game> Games { get;}
    }
}
