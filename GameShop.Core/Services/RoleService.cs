using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Core.Mapping;
using GameShop.Core.Services;
using GameShop.Database.Repositories;


namespace LibraryManagement.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public List<RoleResponseDto> GetAll()
        {
            var roles = _roleRepository.GetAll();
            var rolesDtos = roles.MapToRoleResponseDto();
            return rolesDtos;
        }

       

        public void Create(RoleRequestDto roleDto)
        {
            try
            {
                var role = roleDto.MapToRole();
                _roleRepository.Create(role);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        
    }
}
