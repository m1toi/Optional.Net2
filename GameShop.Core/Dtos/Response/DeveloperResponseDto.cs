namespace GameShop.Core.Dtos.Response
{
    public class DeveloperResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GameResponseDto> Games { get; set; }
    }
}
