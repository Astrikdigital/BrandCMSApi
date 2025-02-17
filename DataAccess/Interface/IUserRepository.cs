using BusinessObjectsLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IUserRepository
    {
        Task<User> Authenticate(string userId, string password); 
        Task<dynamic> ChangePassword(ChangePassword change);
        Task<dynamic> GetSchool(string? slug);
         

    }
}



