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
        Task<dynamic> GetDynamicNavigation();
        Task<dynamic> GetFooterSection();
        Task<dynamic> InsertupdatePage(PageModel model);
        Task<dynamic> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse);
        Task<dynamic> GetPageByType(int? Id, int? TypeId);
        Task<dynamic> GetMajor(int? Id);
        Task<dynamic> GetMajorProgram(int? Id);
        Task<dynamic> GetPotentialJobfield(int? Id);
        Task<dynamic> GetBenefit(int? Id);
        Task<dynamic> GetStudentSuccess(int? Id);
        Task<dynamic> GetMajorProgramCourse();
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
        Task<dynamic> InsertUpdatePotentialJobField(PotentialJobField model);

        Task<dynamic> InsertUpdateBenefit(Benefit model);
        Task<dynamic> InsertUpdateTestimonial(Testimonial model);
        Task<dynamic> GetBenefit();
        Task<dynamic> GetBenefitById(int? Id);

        Task<dynamic> GetTestimonials();
        Task<dynamic> GetTestimonialsById(int? Id);

        Task<dynamic> InsertUpdateAdmissionProcess(AdmissionProcessModel model);
        Task<dynamic> GetAdmissionProcess();
        Task<dynamic> GetAdmissionProcessById(int? Id);

        Task<dynamic> InsertUpdateKeySkill(KeySkill model);
        Task<dynamic> GetKeySkill();
        Task<dynamic> GetKeySkillById(int? Id);


        Task<dynamic> InsertUpdateFAQ(FAQ model);
        Task<dynamic> GetFAQ();
        Task<dynamic> GetFAQById(int? Id);
      
        Task<dynamic> InsertUpdateKeyHighLight(KeyHighLightModel model);
        Task<dynamic> GetKeyHighLight();
        Task<dynamic> GetKeyHighLightById(int? Id);

        Task<dynamic> InsertUpdateModuleCourse(ModuleCourse model);
        Task<dynamic> GetModuleCourse();
        Task<dynamic> GetModuleCourseById(int? Id);

        Task<dynamic> InsertUpdateApplicationTips(ApplicationTipsModel model);
        Task<dynamic> GetApplicationTips();
        Task<dynamic> GetApplicationTipsById(int? Id);

        Task<dynamic> InsertUpdateDocumentRequired(DocumentRequiredModel model);
        Task<dynamic> GetDocumentRequired();
        Task<dynamic> GetDocumentRequiredById(int? Id);

        Task<dynamic> InsertUpdateStudentSuccess(StudentSucess model);
        Task<dynamic> GetStudentSuccess();
        Task<dynamic> GetStudentSuccessById(int? Id);


        Task<dynamic> InsertUpdateFooterPages(FooterSection model);
        //Task<dynamic> GetStudentSuccess();
        //Task<dynamic> GetStudentSuccessById(int? Id);
    }
}



