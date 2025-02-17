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
    public class AdminController : ControllerBase
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetSchool")]
        public async Task<IActionResult> GetSchool(string? Slug)
        {
            try
            {
                var resp = await _userService.GetSchool(Slug);
                return Ok(ResponseHelper.GetSuccessResponse(resp));
            }
            catch (Exception ex)
            { 
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
    }
}
