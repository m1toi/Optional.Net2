using System.Xml.Serialization;
using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;


namespace GameShop.Core.Services
{
    public interface IUserService
    {
        void RegisterUser(UserRequestDto userRequestDto);
        string LoginUser(LoginRequestDto logInDto);
        List<UserResponseDto> GetAll();
    }
}
