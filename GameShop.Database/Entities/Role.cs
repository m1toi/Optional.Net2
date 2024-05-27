namespace GameShop.Database.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Role> Roles { get; set; }

    }
}
