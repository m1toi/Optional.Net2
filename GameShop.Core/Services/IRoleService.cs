using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Database.Entities;

namespace GameShop.Core.Services
{
    public interface IRoleService
    {
        List<RoleResponseDto> GetAll();
        void Create(RoleRequestDto roleRequestDto);

    }
}
