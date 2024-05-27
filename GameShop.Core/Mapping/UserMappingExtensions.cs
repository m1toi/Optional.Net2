using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Protocols;

namespace GameShop.Core.Mapping
{
    public static class UserMappingExtensions
    {
        public static User MapToUser(this UserRequestDto userRequestDto)
        {
            var result = new User
            {
                Username = userRequestDto.Username,
                Email = userRequestDto.Email,
                Password = userRequestDto.Password,
                RoleId = userRequestDto.RoleId
            };
            return result;
        }

        public static UserResponseDto MapToUserResponseDto(this User user)
        {
            var result = new UserResponseDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Role = user.Role.Name
            };
            return result;
        }

        public static List<UserResponseDto> MapToUserResponseDto(this List<User> users)
        {
            return users.Select(user => user.MapToUserResponseDto()).ToList();   
        }   
    }
}
