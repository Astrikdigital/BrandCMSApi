
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
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;
        private readonly HttpContextAccessor _httpContextAccessor;
        public UserRepository(HttpContextAccessor httpContextAccessor,DapperContext context)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<BusinessObjectsLayer.Entities.User> Authenticate(string userId,string password)
        {
            try
            {
                using var connection = _context.CreateConnection();
                var user = await connection.QueryFirstOrDefaultAsync<BusinessObjectsLayer.Entities.User>("Login @UserId, @Password", new { UserId = userId, Password = password });
                if (user != null)
                {
                    return user;
                }
            }
            catch (Exception ex)
            {
                string request = ErrorLogger.LogMethodParameters(nameof(Authenticate), ErrorLogger.ConvertToDictionary(nameof(userId), userId, nameof(password), password));
                ErrorLogger.LogError("UserRepository", "Authenticate", request, ex);
            }
            return null;
        }

        public async Task<dynamic> ChangePassword(ChangePassword changePassword)
        {
            var resp = new Object();
            try
            {
                var param = new
                {
                    UserId = changePassword.Id,
                    CurrentPassword = changePassword.CurrentPassword,
                    NewPassword = changePassword.NewPassword
                };
                using var connection = _context.CreateConnection();
                resp = await connection.QueryFirstOrDefaultAsync<dynamic>("ChangePassword", param: param);
                return resp;
                
            }
            catch (Exception ex)
            {
                string request = ErrorLogger.LogMethodParameters(nameof(ChangePassword), ErrorLogger.ConvertToDictionary(changePassword));
                ErrorLogger.LogError("UserRepository", "ChangePassword", request, ex);
            }
            return null;
        }
        public async Task<dynamic> GetSchool(string? Slug)
        {
            try
            {
                var param = new
                {
                    Slug = Slug
                };
                using var connection = _context.CreateConnection();
                var listschoolpage = (await connection.QueryAsync<SchoolModel>("GetSchool", param: param)).ToList();
                dynamic obj = new ExpandoObject(); 
                var objDict = (IDictionary<string, object>)obj;
                //foreach (var item in listschoolpage)
                //{
                //    if (item.Value != null)
                //    {
                //        var deserializedValue = JsonDocument.Parse(item.Value); 
                //        objDict[item?.Key?.Replace(" ",string.Empty)] = deserializedValue;
                //    }
                //}  
                foreach (var item in listschoolpage)
                    if (item.Value != null) { 
                var programContainer = JsonSerializer.Deserialize<Dictionary<string, object>>(item.Value);
                        if (programContainer.ContainsKey("JSON"))
                       {
                        var courses = JsonSerializer.Deserialize<dynamic>(programContainer["JSON"].ToString());
                            programContainer["JSON"] = courses; 
                       }
                objDict[item?.Key?.Replace(" ", string.Empty)] = programContainer;
                    }
                return objDict;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

     
    }
}
