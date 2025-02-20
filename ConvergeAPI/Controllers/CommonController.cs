using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Response;
using BusinessLogicLayer.Service;
using BusinessObjectsLayer.Entities;
using Converge.Shared.Helper;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
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
        


    }
}
