
using BusinessObjectsLayer.Entities;
using Dapper;
using DataAccess.DbContext;
using DataAccessLayer.Interface;
using DocumentFormat.OpenXml.Wordprocessing;
using ErrorLog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Dynamic;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace DataAccessLayer.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        private readonly DapperContext _context;
        private readonly HttpContextAccessor _httpContextAccessor;
        public CommonRepository(HttpContextAccessor httpContextAccessor,DapperContext context)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<dynamic> GetSchools()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetSchools", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetSchoolsById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetSchoolById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajors()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajor", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajorPrograms()
        {
            try
            {
                
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajorProgram", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetCourses()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetCourses", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetPrograms()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetProgram", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateSchool(School model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    MenuHeading = model.MenuHeading,
                    MenuDescription = model.MenuDescription,
                    MenuImage = model.MenuImage,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdateSchool", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,
                    SchoolId = model.SchoolId
                };
                return (await con.QueryAsync("InsertUpdateMajor", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdateProgram", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdateCourse", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,
                    MajorId = model.MajorId,
                    ProgramId = model.ProgramId,
                    Image = model.MenuImage,
                    Description = model.Description,
                    LinkUrl = model.LinkUrl,
                    ButtonText = model.ButtonText,

                };
                return (await con.QueryAsync("InsertUpdateMajorProgram", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> DeleteTableRow(string TableName, int? Id)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    tableName = TableName,
                    Id = Id
                };
                return (await con.QueryAsync("DeleteTableRow", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetMajorById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajorById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetProgramById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetProgramById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajorProgramById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajorProgramById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
               public async Task<dynamic> GetPageByType(string Slug)
        {
            try
            {
                var param = new
                {
                    Slug = Slug
                };
                using var connection = _context.CreateConnection();
                var listschoolpage = (await connection.QueryAsync<SchoolModel>("GetPageByType", param: param)).ToList();
                dynamic obj = new ExpandoObject();
                var objDict = (IDictionary<string, object>)obj;
                var SectionIds = "";
                foreach (var item in listschoolpage)
                    if (item.Value != null)
                    {
                        var programContainer = JsonSerializer.Deserialize<Dictionary<string, object>>(item.Value);
                        if (programContainer.ContainsKey("JSON"))
                        {
                            var json = JsonSerializer.Deserialize<dynamic>(programContainer["JSON"].ToString());

                            programContainer["JSON"] = json;
                        }
                        objDict[item?.Key?.Replace(" ", string.Empty)] = programContainer;
                        if(SectionIds == "") SectionIds= item.Id.ToString();
                        else  SectionIds += ","+item.Id.ToString();
                    }
                objDict["SectionIds"] = SectionIds;
                return objDict;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse)
        {
            var resp = new Object();
            try
            { 
                using var connection = _context.CreateConnection();
                resp = await connection.QueryFirstOrDefaultAsync<dynamic>("InsertupdateAboutTheCourse", AboutTheCourse);
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            } 
        }
        public async Task<dynamic> GetMajor(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetMajor", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetMajorProgram(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetMajorProgram", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetPotentialJobfield(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetPotentialJobfield", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetBenefit(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetBenefit", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetStudentSuccess(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetStudentSuccess", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetTestimonial(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetTestimonial", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetAdmissionProcess(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetAdmissionProcess", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
