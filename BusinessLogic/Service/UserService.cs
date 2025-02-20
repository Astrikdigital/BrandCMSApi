using BusinessLogicLayer.Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DataAccessLayer.Interface;
using BusinessObjectsLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using DocumentFormat.OpenXml.Spreadsheet;
using DataAccessLayer.Repositories;
using DocumentFormat.OpenXml.Math;
using ErrorLog;
using static Converge.Shared.Helper.EnumHelper;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Text.Json.Nodes;

namespace BusinessLogicLayer.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly string? _secretKey;
        private readonly string? _issuer;
        private readonly string? _audience;
        private readonly int _durationInMinutes;

        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _secretKey = configuration["Jwt:SecretKey"];
            _issuer = configuration["Jwt:Issuer"];
            _audience = configuration["Jwt:Audience"];
            _durationInMinutes = int.Parse(configuration["Jwt:DurationInMinutes"]);
        }

        public async Task<BusinessObjectsLayer.Entities.User> Authenticate(string UserId, string password)
        {
            BusinessObjectsLayer.Entities.User user = await _userRepository.Authenticate(UserId.ToLower(),password);
            if (user == null || user.Password != password) // Password Hashed
            {
                return null;
            }
            if(user.StudentEnrollment != null) user.StudentEnrollment = JsonObject.Parse(user.StudentEnrollment);
            var token = GenerateJwtToken(user);
            return new BusinessObjectsLayer.Entities.User { Token = token, Expiry = DateTime.UtcNow.AddMinutes(_durationInMinutes),Role=user.Role,RoleId=user.RoleId,FullName=user.FullName,Email=user.Email,Id = user.Id,UserTypeId=user.UserTypeId,PictureUrl=user.PictureUrl,EntityId=user.EntityId, UnReadCount =user.UnReadCount,EnrollmentId=user.EnrollmentId,StudentEnrollment=user.StudentEnrollment};
        }

        public async Task<dynamic> ChangePassword(ChangePassword changePassword)
        {
            var user = await _userRepository.ChangePassword(changePassword);
            return user;
        }
        public async Task<dynamic> GetSchool(string? Slug)
        {
            var user = await _userRepository.GetSchool(Slug);
            return user;
        }

        private string GenerateJwtToken(BusinessObjectsLayer.Entities.User user)
        {
            
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.FullName.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(ClaimTypes.Email, user.Email.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_durationInMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        public async Task<dynamic> DeleteTableRow(string? tableName, int? Id)
        {
            var user = await _userRepository.DeleteTableRow(tableName, Id);
            return user;
        }
    }
}
