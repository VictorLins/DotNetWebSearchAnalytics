using DotNetWebSearchAnalyticsAPI.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DotNetWebSearchAnalyticsAPI.Api.Services
{
    public interface IUserService
    {
        Task<UserManagerResponse> RegisterUserAsync(RegisterViewModel prRegisterViewModel);
        Task<UserManagerResponse> LoginUserAsync(LoginViewModel prLoginViewModel);
    }

    public class UserService : IUserService
    {
        private UserManager<IdentityUser> _userManager;
        private IConfiguration _configuration;

        public UserService(UserManager<IdentityUser> prUserManager, IConfiguration prConfiguration)
        {
            _userManager = prUserManager;
            _configuration = prConfiguration;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginViewModel prLoginViewModel)
        {
            var lUser = await _userManager.FindByEmailAsync(prLoginViewModel.Email);

            if (lUser == null)
            {
                return new UserManagerResponse
                {
                    Message = "Email not found",
                    isSuccess = false,
                };
            }

            var lResult = await _userManager.CheckPasswordAsync(lUser, prLoginViewModel.Password);

            if (!lResult)
                return new UserManagerResponse
                {
                    Message = "Invalid Password",
                    isSuccess = false,
                };

            var lClaims = new[]
            {
                new Claim("Email", prLoginViewModel.Email),
                new Claim(ClaimTypes.NameIdentifier, lUser.Id)
            };

            var lKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Key"]));

            var lToken = new JwtSecurityToken(
                issuer: _configuration["AuthSettings:Issuer"],
                audience: _configuration["AuthSettings:Audience"],
                claims: lClaims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(lKey, SecurityAlgorithms.HmacSha256));

            string lTokenAsString = new JwtSecurityTokenHandler().WriteToken(lToken);

            return new UserManagerResponse
            {
                Message = lTokenAsString,
                isSuccess = true,
                ExpiryDate = lToken.ValidTo
            };
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterViewModel prModel)
        {
            if (prModel == null)
                throw new NullReferenceException("Register Model is Null");

            if (prModel.Password != prModel.ConfirmPassword)
                return new UserManagerResponse
                {
                    Message = "Confirm password doesn't match the password",
                    isSuccess = false
                };

            var lIdentityUser = new IdentityUser
            {
                Email = prModel.Email,
                UserName = prModel.Email
            };

            var lResult = await _userManager.CreateAsync(lIdentityUser, prModel.Password);

            if (lResult.Succeeded)
            {
                return new UserManagerResponse
                {
                    Message = "User Created Successfully",
                    isSuccess = true
                };
            }

            return new UserManagerResponse
            {
                Message = "User Not Created",
                isSuccess = false,
                Errors = lResult.Errors.Select(x => x.Description)
            };
        }
    }
}