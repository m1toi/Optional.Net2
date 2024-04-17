using GameShop.Core.Dtos.Response;

namespace GameShop.Core.Services
{
    public interface IDeveloperService
    {
        public List<DeveloperResponseDto> GetDevelopers();
    }
}
