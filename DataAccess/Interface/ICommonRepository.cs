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
        
        Task<dynamic> DeleteTableRow(string? tableName, int? Id);
        Task<dynamic> GetSchools();
        Task<dynamic> GetSchoolsById(int? Id);
        Task<dynamic> GetMajorById(int? Id);
        Task<dynamic> GetProgramById(int? Id);
        Task<dynamic> GetMajorProgramById(int? Id);
        Task<dynamic> GetMajors();
        Task<dynamic> GetPrograms();
        Task<dynamic> GetMajorPrograms();
        Task<dynamic> GetCourses();
        Task<dynamic> InsertUpdateSchool(School model);
        Task<dynamic> InsertUpdateMajor(Major model);
        Task<dynamic> InsertUpdateProgram(Programs model);
        Task<dynamic> InsertUpdateCourse(Course model);
        Task<dynamic> InsertUpdateMajorProgram(MajorProgram model);
        Task<dynamic> GetTestimonial(int? Id);
        Task<dynamic> GetAdmissionProcess(int? Id);
    }
}



