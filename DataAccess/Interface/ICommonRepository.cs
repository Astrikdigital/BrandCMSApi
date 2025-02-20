using BusinessObjectsLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ICommonRepository
    {
        Task<dynamic> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse);
        Task<dynamic> GetPageByType(string Slug);
        Task<dynamic> GetMajor(int? Id);
        Task<dynamic> GetMajorProgram(int? Id);
        Task<dynamic> GetPotentialJobfield(int? Id);
        Task<dynamic> GetBenefit(int? Id);
        Task<dynamic> GetStudentSuccess(int? Id);
        
    }
}



