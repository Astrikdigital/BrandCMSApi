using BusinessObjectsLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICommonService
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
