
using BusinessObjectsLayer.Entities;
using Dapper;
using DataAccess.DbContext;
using DataAccessLayer.Interface;
using ErrorLog;
using Microsoft.AspNetCore.Http;
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
                    }
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
        
    }
}
