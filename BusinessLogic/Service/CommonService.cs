using BusinessLogicLayer.Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DataAccessLayer.Interface;
using BusinessObjectsLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using DocumentFormat.OpenXml.Spreadsheet;
using DataAccessLayer.Repositories;
using DocumentFormat.OpenXml.Math;
using ErrorLog;
using static Converge.Shared.Helper.EnumHelper;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Text.Json.Nodes;
using Converge.Shared.Helper;
using Microsoft.AspNetCore.Hosting;

namespace BusinessLogicLayer.Service
{
    public class CommonService : ICommonService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ICommonRepository _commonRepository;
        private readonly string? _secretKey;
        private readonly string? _issuer;
        private readonly string? _audience;
        private readonly int _durationInMinutes;

        public CommonService(ICommonRepository commonRepository, IConfiguration configuration, IWebHostEnvironment environment)
        {
            _environment = environment;
            _commonRepository = commonRepository;
            _secretKey = configuration["Jwt:SecretKey"];
            _issuer = configuration["Jwt:Issuer"];
            _audience = configuration["Jwt:Audience"];
            _durationInMinutes = int.Parse(configuration["Jwt:DurationInMinutes"]);
        }

        public async Task<dynamic> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse)
        {
            var user = await _commonRepository.InsertupdateAboutTheCourse(AboutTheCourse);
            return user;
        }

        public async Task<dynamic> GetPageByType(string Slug)
        {
            var user = await _commonRepository.GetPageByType(Slug);
            return user;
        }

        public async Task<dynamic> GetTestimonialsById(int? Id)
        {
            var user = await _commonRepository.GetTestimonialsById(Id);
            return user;
        }
        public async Task<dynamic> GetMajorProgram(int? Id)
        {
            var user = await _commonRepository.GetMajorProgram(Id);
            return user;
        }
        public async Task<dynamic> GetPotentialJobfield(int? Id)
        {
            var user = await _commonRepository.GetPotentialJobfield(Id);
            return user;
        }
        public async Task<dynamic> GetMajor(int? Id)
        {
            var user = await _commonRepository.GetMajor(Id);
            return user;
        }
        public async Task<dynamic> GetBenefit(int? Id)
        {
            var user = await _commonRepository.GetBenefit(Id);
            return user;
        }
        public async Task<dynamic> GetStudentSuccess(int? Id)
        {
            var user = await _commonRepository.GetStudentSuccess(Id);
            return user;
        }
        public async Task<dynamic> GetMajorProgramCourse()
        {
            var user = await _commonRepository.GetMajorProgramCourse();
            return user;
        }
        public async Task<dynamic> GetSchools()
        {
            var user = await _commonRepository.GetSchools();
            return user;
        }
        public async Task<dynamic> GetSchoolsById(int? Id)
        {
            var user = await _commonRepository.GetSchoolsById(Id);
            return user;
        }
        public async Task<dynamic> GetMajorById(int? Id)
        {
            var user = await _commonRepository.GetMajorById(Id);
            return user;
        }
        public async Task<dynamic> GetProgramById(int? Id)
        {
            var user = await _commonRepository.GetProgramById(Id);
            return user;
        }

        public async Task<dynamic> GetMajorProgramById(int? Id)
        {
            var user = await _commonRepository.GetMajorProgramById(Id);
            return user;
        }
        public async Task<dynamic> GetBenefitById(int? Id)
        {
            var user = await _commonRepository.GetBenefitById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateSchool(School model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateSchool(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateMajor(Major model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateMajor(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateProgram(Programs model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateProgram(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> InsertUpdateCourse(Course model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateCourse(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateMajorProgram(MajorProgram model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateMajorProgram(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajors()
        {
            var user = await _commonRepository.GetMajors();
            return user;
        }

        public async Task<dynamic> GetTestimonials()
        {
            var user = await _commonRepository.GetTestimonials();
            return user;
        }
        public async Task<dynamic> GetBenefit()
        {
            var user = await _commonRepository.GetBenefit();
            return user;
        }
        public async Task<dynamic> GetCourses()
        {
            var user = await _commonRepository.GetCourses();
            return user;
        }
        public async Task<dynamic> GetPrograms()
        {
            var user = await _commonRepository.GetPrograms();
            return user;
        }
        public async Task<dynamic> GetMajorPrograms()
        {
            var user = await _commonRepository.GetMajorPrograms();
            return user;
        }
     
        
        public async Task<dynamic> DeleteTableRow(string TableName, int? Id)
        {
            try
            {

                var res = await _commonRepository.DeleteTableRow(TableName, Id);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetTestimonial(int? Id)
        {
            var user = await _commonRepository.GetTestimonial(Id);
            return user;
        }
        public async Task<dynamic> GetAdmissionProcess(int? Id)
        {
            var user = await _commonRepository.GetAdmissionProcess(Id);
            return user;
        }
        

        public async Task<dynamic> InsertUpdatePotentialJobField(PotentialJobField model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdatePotentialJobField(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateBenefit(Benefit model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateBenefit(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> InsertUpdateTestimonial(Testimonial model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateTestimonial(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetAdmissionProcess()
        {
            var user = await _commonRepository.GetAdmissionProcess();
            return user;
        }
        public async Task<dynamic> GetAdmissionProcessById(int? Id)
        {
            var user = await _commonRepository.GetAdmissionProcessById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateAdmissionProcess(AdmissionProcessModel model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateAdmissionProcess(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetKeySkill()
        {
            var user = await _commonRepository.GetKeySkill();
            return user;
        }
        public async Task<dynamic> GetKeySkillById(int? Id)
        {
            var user = await _commonRepository.GetKeySkillById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateKeySkill(KeySkill model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateKeySkill(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        #region FAQ
        public async Task<dynamic> GetFAQ()
        {
            var user = await _commonRepository.GetFAQ();
            return user;
        }
        public async Task<dynamic> GetFAQById(int? Id)
        {
            var user = await _commonRepository.GetFAQById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateFAQ(FAQ model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateFAQ(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

        #region KeyHighLight
        public async Task<dynamic> GetKeyHighLight()
        {
            var user = await _commonRepository.GetKeyHighLight();
            return user;
        }
        public async Task<dynamic> GetKeyHighLightById(int? Id)
        {
            var user = await _commonRepository.GetKeyHighLightById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateKeyHighLight(KeyHighLightModel model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateKeyHighLight(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

        #region ModuleCourse
        public async Task<dynamic> GetModuleCourse()
        {
            var user = await _commonRepository.GetModuleCourse();
            return user;
        }
        public async Task<dynamic> GetModuleCourseById(int? Id)
        {
            var user = await _commonRepository.GetModuleCourseById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateModuleCourse(ModuleCourse model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateModuleCourse(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

        #region ApplicationTips
        public async Task<dynamic> GetApplicationTips()
        {
            var user = await _commonRepository.GetApplicationTips();
            return user;
        }
        public async Task<dynamic> GetApplicationTipsById(int? Id)
        {
            var user = await _commonRepository.GetApplicationTipsById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateApplicationTips(ApplicationTipsModel model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateApplicationTips(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

        #region DocumentRequired
        public async Task<dynamic> GetDocumentRequired()
        {
            var user = await _commonRepository.GetDocumentRequired();
            return user;
        }
        public async Task<dynamic> GetDocumentRequiredById(int? Id)
        {
            var user = await _commonRepository.GetDocumentRequiredById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateDocumentRequired(DocumentRequiredModel model)
        {
            try
            {
                var res = await _commonRepository.InsertUpdateDocumentRequired(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion


        #region StudentSuccess
        public async Task<dynamic> GetStudentSuccess()
        {
            var user = await _commonRepository.GetStudentSuccess();
            return user;
        }
        public async Task<dynamic> GetStudentSuccessById(int? Id)
        {
            var user = await _commonRepository.GetStudentSuccessById(Id);
            return user;
        }
        public async Task<dynamic> InsertUpdateStudentSuccess(StudentSucess model)
        {
            try
            {
                string attachmentName = null;
                string attachmentUrl = null;

                if (model.Attachment != null && model.Attachment.Length > 0)
                {
                    (attachmentName, attachmentUrl) = await Helper.AttachFileAsync(model.Attachment, _environment, 1);
                    model.MenuImage = attachmentUrl;
                }
                var res = await _commonRepository.InsertUpdateStudentSuccess(model);
                return res;
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

    }
}
