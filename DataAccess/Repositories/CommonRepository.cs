
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
    }
}
