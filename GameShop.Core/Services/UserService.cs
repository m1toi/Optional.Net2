using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Core.Mapping;
using GameShop.Core.Services;
using GameShop.Database.Entities;
using GameShop.Database.Repositories;


namespace GameShop.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthenticationService _authenticationService;

        public UserService(IUserRepository userRepository, IAuthenticationService authenticationService)
        {
            _userRepository = userRepository;
            _authenticationService = authenticationService;
        }

        public void RegisterUser(UserRequestDto userRequestDto)
        {
            try
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(userRequestDto.Password);
                userRequestDto.Password = passwordHash;
                var user = userRequestDto.MapToUser();
                _userRepository.RegisterUser(user);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string LoginUser(LoginRequestDto loginDto)
        {
            try
            {
                var user = _userRepository.GetUserByEmail(loginDto.Email);

                if (!BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password))
                {
                    throw new Exception("Invalid password");
                }

                string token = _authenticationService.GenerateToken(user);
                return token;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<UserResponseDto> GetAll()
        {
            var users = _userRepository.GetAll();
            var userResponseDtos = users.MapToUserResponseDto();
            return userResponseDtos;
        }

      
    }
}
