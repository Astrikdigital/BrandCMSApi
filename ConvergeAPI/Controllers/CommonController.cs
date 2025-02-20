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
        [HttpGet("GetPageByType")]
        public async Task<IActionResult> GetPageByType(string Slug)
        {
            try
            {
                var resp = await _commonService.GetPageByType(Slug);
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
        [HttpGet("GetBenefit")]
        public async Task<IActionResult> GetBenefit(int? Id)
        {
            try
            {
                var resp = await _commonService.GetBenefit(Id);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        [HttpGet("GetStudentSuccess")]
        public async Task<IActionResult> GetStudentSuccess(int? Id)
        {
            try
            {
                var resp = await _commonService.GetStudentSuccess(Id);
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

    }
}
