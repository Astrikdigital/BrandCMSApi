
using BusinessObjectsLayer.Entities;
using Dapper;
using DataAccess.DbContext;
using DataAccessLayer.Interface;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using ErrorLog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Dynamic;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task<dynamic> GetSchools()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetSchools", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetSchoolsById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetSchoolById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetTestimonials()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetTestimonial", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetTestimonialsById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetTestimonialById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajors()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajor", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajorPrograms()
        {
            try
            {
                
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajorProgram", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetCourses()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetCourses", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetPrograms()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetProgram", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetBenefit()
        {
            try
            {

                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetBenefit", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateSchool(School model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    MenuHeading = model.MenuHeading,
                    MenuDescription = model.MenuDescription,
                    MenuImage = model.MenuImage,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdateSchool", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,
                    SchoolId = model.SchoolId
                };
                return (await con.QueryAsync("InsertUpdateMajor", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdateProgram", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdateCourse", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,
                    MajorId = model.MajorId,
                    ProgramId = model.ProgramId,
                    Image = model.MenuImage,
                    Description = model.Description,
                    LinkUrl = model.LinkUrl,
                    ButtonText = model.ButtonText,

                };
                return (await con.QueryAsync("InsertUpdateMajorProgram", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> DeleteTableRow(string TableName, int? Id)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    tableName = TableName,
                    Id = Id
                };
                return (await con.QueryAsync("DeleteTableRow", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetMajorById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajorById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetProgramById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetProgramById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetMajorProgramById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetMajorProgramById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        public async Task<dynamic> GetPageByType(string Slug)
        {
            try
            {
                var param = new
                {
                    Slug = Slug
                };
                using var connection = _context.CreateConnection();
                var listschoolpage = (await connection.QueryAsync<SchoolModel>("GetPageByType", param: param)).ToList();
                dynamic obj = new ExpandoObject();
                var objDict = (IDictionary<string, object>)obj;
                var SectionIds = "";
                foreach (var item in listschoolpage)
                    if (item.Value != null)
                    {
                        var programContainer = JsonSerializer.Deserialize<Dictionary<string, object>>(item.Value);
                        if (programContainer.ContainsKey("JSON"))
                        {
                            var json = JsonSerializer.Deserialize<dynamic>(programContainer["JSON"].ToString());

                            programContainer["JSON"] = json;
                        }
                        objDict[item?.Key?.Replace(" ", string.Empty)] = programContainer;
                        if(SectionIds == "") SectionIds= item.Id.ToString();
                        else  SectionIds += ","+item.Id.ToString();
                    }
                objDict["SectionIds"] = SectionIds;
                return objDict;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse)
        {
            var resp = new Object();
            try
            { 
                using var connection = _context.CreateConnection();
                resp = await connection.QueryFirstOrDefaultAsync<dynamic>("InsertupdateAboutTheCourse", AboutTheCourse);
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            } 
        }
        public async Task<dynamic> GetMajor(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetMajor", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetMajorProgram(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetMajorProgram", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetPotentialJobfield(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetPotentialJobfield", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetBenefit(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetBenefit", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetStudentSuccess(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetStudentSuccess", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetTestimonial(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetTestimonial", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<dynamic> GetAdmissionProcess(int? Id)
        {
            var resp = new Object();
            try
            {
                using var connection = _context.CreateConnection();
                resp = (await connection.QueryAsync<dynamic>("GetAdmissionProcess", new { Id = Id })).ToList();
                return resp;

            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public async Task<dynamic> InsertUpdatePotentialJobField(PotentialJobField model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId,

                };
                return (await con.QueryAsync("InsertUpdatePotentialJobField", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Heading = model.Heading,
                    Image = model.MenuImage,
                    Description = model.Description,
                    UserId = model.UserId

                };
                return (await con.QueryAsync("InsertUpdateBenefit", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Name = model.Name,
                    Designation = model.Designation,
                    Image = model.MenuImage,
                    Heading = model.Heading,
                    Description = model.Description,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateTestimonial", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetBenefitById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetBenefitById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }


        public async Task<dynamic> GetAdmissionProcess()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetAdmissionProcess", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetAdmissionProcessById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetAdmissionProcessById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateAdmissionProcess(AdmissionProcessModel model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    LeftText = model.LeftText,
                    RightText = model.RightText,
                    UserId = model.UserId

                };
                return (await con.QueryAsync("InsertUpdateAdmissionProcess", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetKeySkill()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetKeySkill", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetKeySkillById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetKeySkillById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateKeySkill(KeySkill model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Title = model.Title,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateKeySkill", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }


        #region FAQ_Repo
        public async Task<dynamic> GetFAQ()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetFAQ", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetFAQById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetFAQById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateFAQ(FAQ model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Question = model.Question,
                    Answer = model.Answer,
                    Type = model.Type,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateFAQ", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion


        #region KeyHighLight_REPO
        public async Task<dynamic> GetKeyHighLight()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetKeyHighLight", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetKeyHighLightById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetKeyHighLightById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateKeyHighLight(KeyHighLightModel model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    LeftText = model.LeftText,
                    RightText = model.RightText,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateKeyHighLight", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion


        #region ModuleCourse_REPO
        public async Task<dynamic> GetModuleCourse()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetModuleCourse", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetModuleCourseById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetModuleCourseById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateModuleCourse(ModuleCourse model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Heading = model.Heading,
                    MajorProgramCourseId = model.MajorProgramCourseId,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateModuleCourse", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

        #region ApplicationTips_REPO
        public async Task<dynamic> GetApplicationTips()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetApplicationTips", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetApplicationTipsById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetApplicationTipsById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateApplicationTips(ApplicationTipsModel model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    LeftText = model.LeftText,
                    RightText = model.RightText,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateApplicationTips", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion


        #region DocumentRequired_REPO
        public async Task<dynamic> GetDocumentRequired()
        {
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetDocumentRequired", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetDocumentRequiredById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetDocumentRequiredById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateDocumentRequired(DocumentRequiredModel model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    LeftText = model.LeftText,
                    RightText = model.RightText,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateDocumentRequired", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
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
            try
            {
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetStudentSuccess", commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> GetStudentSuccessById(int? Id)
        {
            try
            {
                var param = new
                {
                    Id = Id

                };
                using var con = _context.CreateConnection();
                return (await con.QueryAsync("GetStudentSuccessById", param: param, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }

        public async Task<dynamic> InsertUpdateStudentSuccess(StudentSucess model)
        {
            try
            {
                using var con = _context.CreateConnection();
                var parameters = new
                {
                    Id = model.Id,
                    Heading = model.Heading,
                    Description = model.Description,
                    Image = model.MenuImage,
                    UserId = model.UserId
                };
                return (await con.QueryAsync("InsertUpdateStudentSuccess", param: parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            catch (Exception ex)
            {
                return (null);
            }

        }
        #endregion

    }
}
