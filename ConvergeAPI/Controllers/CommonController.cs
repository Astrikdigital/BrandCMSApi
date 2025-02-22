using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Response;
using BusinessLogicLayer.Service;
using BusinessObjectsLayer.Entities;
using Converge.Shared.Helper;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using ErrorLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConvergeAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController] 
    public class CommonController : ControllerBase
    {
        private readonly ICommonService _commonService;

        public CommonController(ICommonService commonService)
        {
            _commonService = commonService;
        }
        [HttpPost("InsertupdatePage")]
        public async Task<IActionResult> InsertupdatePage(PageModel model)
        {
            try
            {
                var resp = await _commonService.InsertupdatePage(model);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetPageByType")]
        public async Task<IActionResult> GetPageByType(int? Id,int? TypeId)
        {
            try
            {
                var resp = await _commonService.GetPageByType(Id, TypeId);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpPost("InsertupdateAboutTheCourse")]
        public async Task<IActionResult> InsertupdateAboutTheCourse(AboutTheCourseModel AboutTheCourse)
        {
            try
            {
                var resp = await _commonService.InsertupdateAboutTheCourse(AboutTheCourse);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetMajor")]
        public async Task<IActionResult> GetMajor(int? Id)
        {
            try
            {
                var resp = await _commonService.GetMajor(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetMajorProgram")]
        public async Task<IActionResult> GetMajorProgram(int? Id)
        {
            try
            {
                var resp = await _commonService.GetMajorProgram(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetPotentialJobfield")]
        public async Task<IActionResult> GetPotentialJobfield(int? Id)
        {
            try
            {
                var resp = await _commonService.GetPotentialJobfield(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetMajorProgramCourse")]
        public async Task<IActionResult> GetMajorProgramCourse()
        {
            try
            {
                var resp = await _commonService.GetMajorProgramCourse();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetSchools")]
        public async Task<IActionResult> GetSchools()
        {
            try
            {
                var resp = await _commonService.GetSchools();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetSchoolById")]
        public async Task<IActionResult> GetSchoolById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetSchoolsById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetMajors")]
        public async Task<IActionResult> GetMajors()
        {
            try
            {
                var resp = await _commonService.GetMajors();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetPrograms")]
        public async Task<IActionResult> GetPrograms()
        {
            try
            {
                var resp = await _commonService.GetPrograms();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetMajorPrograms")]
        public async Task<IActionResult> GetMajorPrograms()
        {
            try
            {
                var resp = await _commonService.GetMajorPrograms();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetCourses")]
        public async Task<IActionResult> GetCourses()
        {
            try
            {
                var resp = await _commonService.GetCourses();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateSchool")]
        public async Task<IActionResult> InsertUpdateSchool([FromForm] School model)
        {
            try
            {
                var result = await _commonService.InsertUpdateSchool(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpPost("InsertUpdateMajor")]
        public async Task<IActionResult> InsertUpdateMajor(Major model)
        {
            try
            {
                var result = await _commonService.InsertUpdateMajor(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpPost("InsertUpdateProgram")]
        public async Task<IActionResult> InsertUpdateProgram(Programs model)
        {
            try
            {
                var result = await _commonService.InsertUpdateProgram(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpPost("InsertUpdateCourse")]
        public async Task<IActionResult> InsertUpdateCourse(Course model)
        {
            try
            {
                var result = await _commonService.InsertUpdateCourse(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpPost("InsertUpdateMajorProgram")]
        public async Task<IActionResult> InsertUpdateMajorProgram([FromForm] MajorProgram model)
        {
            try
            {
                var result = await _commonService.InsertUpdateMajorProgram(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpGet("DeleteTableRow")]
        public async Task<IActionResult> DeleteTableRow(string? tableName, int? Id)
        {
            try
            {
                var result = await _commonService.DeleteTableRow(tableName, Id);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpGet("GetMajorById")]
        public async Task<IActionResult> GetMajorById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetMajorById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetProgramById")]
        public async Task<IActionResult> GetProgramById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetProgramById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }


        [HttpGet("GetMajorProgramById")]
        public async Task<IActionResult> GetMajorProgramById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetMajorProgramById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdatePotentialJobField")]
        public async Task<IActionResult> InsertUpdatePotentialJobField(PotentialJobField model)
        {
            try
            {
                var result = await _commonService.InsertUpdatePotentialJobField(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpPost("InsertUpdateBenefit")]
        public async Task<IActionResult> InsertUpdateBenefit([FromForm] Benefit model)
        {
            try
            {
                var result = await _commonService.InsertUpdateBenefit(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpPost("InsertUpdateTestimonial")]
        public async Task<IActionResult> InsertUpdateTestimonial([FromForm] Testimonial model)
        {
            try
            {
                var result = await _commonService.InsertUpdateTestimonial(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }
        [HttpGet("GetBenefit")]
        public async Task<IActionResult> GetBenefit()
        {
            try
            {
                var resp = await _commonService.GetBenefit();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetBenefitById")]
        public async Task<IActionResult> GetBenefitById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetBenefitById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetTestimonials")]
        public async Task<IActionResult> GetTestimonials()
        {
            try
            {
                var resp = await _commonService.GetTestimonials();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetTestimonialsById")]
        public async Task<IActionResult> GetTestimonialsById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetTestimonialsById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetTestimonial")]
        public async Task<IActionResult> GetTestimonial(int? Id)
        {
            try
            {
                var resp = await _commonService.GetTestimonial(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetAdmissionProcess")]
        public async Task<IActionResult> GetAdmissionProcess(int? Id)
        {
            try
            {
                var resp = await _commonService.GetAdmissionProcess(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }


        [HttpGet("GetAdmissionProcessById")]
        public async Task<IActionResult> GetAdmissionProcessById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetAdmissionProcessById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateAdmissionProcess")]
        public async Task<IActionResult> InsertUpdateAdmissionProcess(AdmissionProcessModel model)
        {
            try
            {
                var result = await _commonService.InsertUpdateAdmissionProcess(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }

        }

        [HttpGet("GetKeySkill")]
        public async Task<IActionResult> GetKeySkill()
        {
            try
            {
                var resp = await _commonService.GetKeySkill();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetKeySkillById")]
        public async Task<IActionResult> GetKeySkillById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetKeySkillById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateKeySkill")]
        public async Task<IActionResult> InsertUpdateKeySkill(KeySkill model)
        {
            try
            {
                var result = await _commonService.InsertUpdateKeySkill(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }

        [HttpGet("GetDynamicNavigation")]
        public async Task<IActionResult> GetDynamicNavigation()
        {
            try
            {
                var resp = await _commonService.GetDynamicNavigation();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        #region FAQ
        [HttpGet("GetFAQ")]
        public async Task<IActionResult> GetFAQ()
        {
            try
            {
                var resp = await _commonService.GetFAQ();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetFAQById")]
        public async Task<IActionResult> GetFAQById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetFAQById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateFAQ")]
        public async Task<IActionResult> InsertUpdateFAQ(FAQ model)
        {
            try
            {
                var result = await _commonService.InsertUpdateFAQ(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }
        #endregion

        #region KeyHighLight
        [HttpGet("GetKeyHighLight")]
        public async Task<IActionResult> GetKeyHighLight()
        {
            try
            {
                var resp = await _commonService.GetKeyHighLight();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetKeyHighLightById")]
        public async Task<IActionResult> GetKeyHighLightById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetKeyHighLightById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateKeyHighLight")]
        public async Task<IActionResult> InsertUpdateKeyHighLight(KeyHighLightModel model)
        {
            try
            {
                var result = await _commonService.InsertUpdateKeyHighLight(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }
        #endregion

        #region ModuleCourse
        [HttpGet("GetModuleCourse")]
        public async Task<IActionResult> GetModuleCourse()
        {
            try
            {
                var resp = await _commonService.GetModuleCourse();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetModuleCourseById")]
        public async Task<IActionResult> GetModuleCourseById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetModuleCourseById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateModuleCourse")]
        public async Task<IActionResult> InsertUpdateModuleCourse(ModuleCourse model)
        {
            try
            {
                var result = await _commonService.InsertUpdateModuleCourse(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }
        #endregion

        #region ApplicationTips
        [HttpGet("GetApplicationTips")]
        public async Task<IActionResult> GetApplicationTips()
        {
            try
            {
                var resp = await _commonService.GetApplicationTips();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetApplicationTipsById")]
        public async Task<IActionResult> GetApplicationTipsById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetApplicationTipsById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateApplicationTips")]
        public async Task<IActionResult> InsertUpdateApplicationTips(ApplicationTipsModel model)
        {
            try
            {
                var result = await _commonService.InsertUpdateApplicationTips(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }
        #endregion

        #region DocumentRequired
        [HttpGet("GetDocumentRequired")]
        public async Task<IActionResult> GetDocumentRequired()
        {
            try
            {
                var resp = await _commonService.GetDocumentRequired();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetDocumentRequiredById")]
        public async Task<IActionResult> GetDocumentRequiredById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetDocumentRequiredById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateDocumentRequired")]
        public async Task<IActionResult> InsertUpdateDocumentRequired(DocumentRequiredModel model)
        {
            try
            {
                var result = await _commonService.InsertUpdateDocumentRequired(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }
        #endregion

        #region StudentSuccess
        [HttpGet("GetStudentSuccess")]
        public async Task<IActionResult> GetStudentSuccess()
        {
            try
            {
                var resp = await _commonService.GetStudentSuccess();
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpGet("GetStudentSuccessById")]
        public async Task<IActionResult> GetStudentSuccessById(int? Id)
        {
            try
            {
                var resp = await _commonService.GetStudentSuccessById(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }

        [HttpPost("InsertUpdateStudentSuccess")]
        public async Task<IActionResult> InsertUpdateStudentSuccess(StudentSucess model)
        {
            try
            {
                var result = await _commonService.InsertUpdateStudentSuccess(model);
                return Ok(ResponseHelper.GetSuccessResponse(result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());

            }
        }
        #endregion



    }
}
