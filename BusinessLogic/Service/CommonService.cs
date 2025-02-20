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
    public class CommonService : ICommonService
    {

        private readonly ICommonRepository _commonRepository;
        private readonly string? _secretKey;
        private readonly string? _issuer;
        private readonly string? _audience;
        private readonly int _durationInMinutes;

        public CommonService(ICommonRepository commonRepository, IConfiguration configuration)
        {
            _commonRepository = commonRepository;
            _secretKey = configuration["Jwt:SecretKey"];
            _issuer = configuration["Jwt:Issuer"];
            _audience = configuration["Jwt:Audience"];
            _durationInMinutes = int.Parse(configuration["Jwt:DurationInMinutes"]);
        }

        public async Task<dynamic> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse)
        {
            var user = await _commonRepository.InsertupdateAboutTheCourse(AboutTheCourse);
            return user;
        }
        public async Task<dynamic> GetPageByType(string Slug)
        {
            var user = await _commonRepository.GetPageByType(Slug);
            return user;
        }
        public async Task<dynamic> GetMajorProgram(int? Id)
        {
            var user = await _commonRepository.GetMajorProgram(Id);
            return user;
        }
        public async Task<dynamic> GetPotentialJobfield(int? Id)
        {
            var user = await _commonRepository.GetPotentialJobfield(Id);
            return user;
        }
        public async Task<dynamic> GetMajor(int? Id)
        {
            var user = await _commonRepository.GetMajor(Id);
            return user;
        }
        public async Task<dynamic> GetBenefit(int? Id)
        {
            var user = await _commonRepository.GetBenefit(Id);
            return user;
        }
        public async Task<dynamic> GetStudentSuccess(int? Id)
        {
            var user = await _commonRepository.GetStudentSuccess(Id);
            return user;
        }
        

    }
}
