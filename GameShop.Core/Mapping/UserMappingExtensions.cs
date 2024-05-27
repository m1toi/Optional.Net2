using GameShop.Core.Dtos.Request;
using GameShop.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace GameShop.Core.Mapping
{
    public static class UserMappingExtensions
    {
        public static User MapToUser(this UserRequestDto userRequestDto)
        {
            var result = new User
            {
                Id = userRequestDto.Id,
                Username = userRequestDto.Username,
                Password = userRequestDto.Password,
                RoleId = userRequestDto.RoleId
            };
            return result;
        }
    }
}
