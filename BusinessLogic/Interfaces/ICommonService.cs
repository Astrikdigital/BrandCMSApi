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
        Task<dynamic> DeleteTableRow(string? tableName, int? Id);

        Task<dynamic> GetSchools();
        Task<dynamic> GetSchoolsById(int? Id);
        Task<dynamic> GetMajorById(int? Id);
        Task<dynamic> GetProgramById(int? Id);
        Task<dynamic> GetMajors();
        Task<dynamic> GetPrograms();
        Task<dynamic> GetMajorPrograms();
        Task<dynamic> GetCourses();
        Task<dynamic> InsertUpdateSchool(School model);
        Task<dynamic> InsertUpdateMajor(Major model);
        Task<dynamic> InsertUpdateProgram(Programs model);
        Task<dynamic> InsertUpdateCourse(Course model);
        Task<dynamic> InsertUpdateMajorProgram(MajorProgram model);
        Task<dynamic> GetMajorProgramById(int? Id);

    }
}
