using BusinessObjectsLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string UserId,string UserPassword); 
        Task<dynamic> ChangePassword(ChangePassword changePassword);  
        Task<dynamic> GetSchool(string? slug);

    }
}
