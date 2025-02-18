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

       
    }
}
