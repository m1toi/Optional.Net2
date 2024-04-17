using GameShop.Core.Dtos.Response;
using GameShop.Core.Mapping;
using GameShop.Database.Entities;
using GameShop.Database.Repositories;

namespace GameShop.Core.Services
{
    public class DeveloperService: IDeveloperService
    {
        private readonly IDeveloperRepository _gameDeveloperRepository;

        public DeveloperService(IDeveloperRepository gameDeveloperRepository)
        {
            this._gameDeveloperRepository = gameDeveloperRepository;
        }

       public List<DeveloperResponseDto> GetDevelopers()
        {
            List<GameDeveloper> gameDevelopers = _gameDeveloperRepository.GetDevelopers();
            List<DeveloperResponseDto> developerResponseDtos = new List<DeveloperResponseDto>();
            foreach (var gameDeveloper in gameDevelopers)
            {
                developerResponseDtos.Add(gameDeveloper.ToDeveloperResponseDto());
            }
            return developerResponseDtos;
        }

    }
}
