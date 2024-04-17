using GameShop.Core.Dtos.Response;
using GameShop.Database.Entities;

namespace GameShop.Core.Mapping
{
    public static class DeveloperMappingExtensions
    {
        public static DeveloperResponseDto ToDeveloperResponseDto(this GameDeveloper developer)
        {
            var result = new DeveloperResponseDto();
            result.Id = developer.Id;
            result.Name = developer.Name;

            List<GameResponseDto> gamesDto = new List<GameResponseDto>();
            foreach (var game in developer.Games)
            {
                gamesDto.Add(game.ToGameResponseDto());
            }

            result.Games = gamesDto;
            return result;
        }
    }
}
