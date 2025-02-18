
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
       
    }
}
