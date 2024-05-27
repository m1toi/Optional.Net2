using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Database.Entities;

namespace GameShop.Core.Mapping
{
    public static class RoleMappingExtensions
    {
        public static RoleResponseDto ToRoleResponseDto(this Role role)
        {
            var result = new RoleResponseDto
            {
                Id = role.Id,
                Name = role.Name
            };
            return result;
        }   

        public static List<RoleResponseDto> MapToRoleResponseDto(this List<Role> roles)
        {
            return roles.Select(role => role.ToRoleResponseDto()).ToList(); 
        }   
        public static Role MapToRole(this RoleRequestDto roleRequestDto)
        {
            var result = new Role   
            {
                Name = roleRequestDto.Name
            };
            return result;
        }
    }
}
