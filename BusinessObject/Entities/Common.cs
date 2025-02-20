using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;

namespace BusinessObjectsLayer.Entities
{
    public class Major
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? UserId { get; set; }
        public int? SchoolId { get; set; }

    }

    public class MajorProgram
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? MajorId { get; set; }
        public int ProgramId { get; set; }
        public string? MenuImage { get; set; }
        public string? Description { get; set; }
        public string? LinkUrl { get; set; }
        public string? ButtonText { get; set; }
        public int? UserId { get; set; }
        public IFormFile? Attachment { get; set; }

    }

    public class MajorProgramCourse
    {
        public int? Id { get; set; }
        public string? CourseTitle { get; set; }
        public int? CourseId { get; set; }
        public int? MajorProgramId { get; set; }
        public int? UserId { get; set; }

    }


    public class ModuleCourse
    {
        public int? Id { get; set; }
        public string? Heading { get; set; }
        public string? MajorProgramCourseId { get; set; }
        public int? UserId { get; set; }

    }


    public class PageSection
    {
        public int? Id { get; set; }
        public string? Slug { get; set; }
        public int? ReferenceId { get; set; }
        public int? Type { get; set; }
        public int? SectionId { get; set; }
        public int? UserId { get; set; }

    }

    public class PotentialJobField
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? UserId { get; set; }

    }

    public class Programs
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? UserId { get; set; }

    }

    public class School
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? MenuHeading { get; set; }
        public string? MenuDescription { get; set; }
        public string? MenuImage { get; set; }
        public int? UserId { get; set; }
        public IFormFile? Attachment { get; set; }

    }

    public class Section
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? Type { get; set; }
        public int? UserId { get; set; }

    }

    public class SectionVariable
    {
        public int? Id { get; set; }
        public int? SectionId { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public int? UserId { get; set; }

    }


    public class StudentSucess
    {
        public int? Id { get; set; }
        public string? Heading { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int? UserId { get; set; }

    }

    public class Testimonial
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? Image { get; set; }
        public string? Heading { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }

    }

    public class Course
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? UserId { get; set; }

    }



}
