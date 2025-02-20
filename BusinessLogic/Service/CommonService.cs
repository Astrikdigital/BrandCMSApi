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
using Converge.Shared.Helper;
using Microsoft.AspNetCore.Hosting;

namespace BusinessLogicLayer.Service
{
    public class CommonService : ICommonService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ICommonRepository _commonRepository;
        private readonly string? _secretKey;
        private readonly string? _issuer;
        private readonly string? _audience;
        private readonly int _durationInMinutes;

        public CommonService(ICommonRepository commonRepository, IConfiguration configuration, IWebHostEnvironment environment)
        {
            _environment = environment;
            _commonRepository = commonRepository;
            _secretKey = configuration["Jwt:SecretKey"];
            _issuer = configuration["Jwt:Issuer"];
            _audience = configuration["Jwt:Audience"];
            _durationInMinutes = int.Parse(configuration["Jwt:DurationInMinutes"]);
        }

        public async Task<dynamic> GetSchools()
        {
            var user = await _commonRepository.GetSchools();
            return user;
        }
        public async Task<dynamic> GetSchoolsById(int? Id)
        {
            var user = await _commonRepository.GetSchoolsById(Id);
            return user;
        }
        public async Task<dynamic> GetMajorById(int? Id)
        {
            var user = await _commonRepository.GetMajorById(Id);
            return user;
        }
        public async Task<dynamic> GetProgramById(int? Id)
        {
            var user = await _commonRepository.GetProgramById(Id);
            return user;
        }

        public async Task<dynamic> GetMajorProgramById(int? Id)
        {
            var user = await _commonRepository.GetMajorProgramById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateSchool(School model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateSchool(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateMajor(Major model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateMajor(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateProgram(Programs model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateProgram(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> InsertUpdateCourse(Course model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateCourse(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateMajorProgram(MajorProgram model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateMajorProgram(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajors()
        {
            var user = await _commonRepository.GetMajors();
            return user;
        }
        public async Task<dynamic> GetCourses()
        {
            var user = await _commonRepository.GetCourses();
            return user;
        }
        public async Task<dynamic> GetPrograms()
        {
            var user = await _commonRepository.GetPrograms();
            return user;
        }
        public async Task<dynamic> GetMajorPrograms()
        {
            var user = await _commonRepository.GetMajorPrograms();
            return user;
        }

        public async Task<dynamic> DeleteTableRow(string TableName, int? Id)
        {
            try
            {

                var res = await _commonRepository.DeleteTableRow(TableName, Id);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }



    }
}
