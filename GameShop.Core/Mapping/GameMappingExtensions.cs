using GameShop.Core.Dtos.Response;
using GameShop.Database.Entities;

namespace GameShop.Core.Mapping
{
    public static class GameMappingExtensions
    {
        public static GameResponseDto ToGameResponseDto(this Game game)
        {
            var result = new GameResponseDto
            {
                Id = game.Id,
                Title = game.Title
            };
            return result;
        }
    }
}
