using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectsLayer.Entities
{
    public class AboutTheCourseModel
    {
        public int? Id { get; set; }
        public string TabName { get; set; }
        public string Heading { get; set; }
        public string SubHeading { get; set; }
        public string Description { get; set; }
        public string ApplicationTipsId { get; set; }
        public string DocumentRequiredId { get; set; }
        public string ModuleCourseId { get; set; }
        public string KeyhighlightId { get; set; }
        public string Class { get; set; }
        public string SubDescription { get; set; }
        public int? AboutTypeId { get; set; }
        public int? UserId { get; set; }

    }
    public class AdmissionProcessModel
    {
        public int? Id { get; set; }
        public string LeftText { get; set; }
        public string RightText { get; set; }
        public int? UserId { get; set; }

    }
    public class ApplicationTipsModel
    {
        public int? Id { get; set; }
        public string LeftText { get; set; }
        public string RightText { get; set; }
        public int? UserId { get; set; }

    }
    public class BenefitModel
    {
        public int? Id { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? UserId { get; set; }

    }
    public class CourseModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? UserId { get; set; }

    }
    public class DocumentRequiredModel
    {
        public int? Id { get; set; }
        public string LeftText { get; set; }
        public string RightText { get; set; }
        public int? UserId { get; set; }

    }
    public class ExploreOurDiverseModel
    {
        public int? Id { get; set; }
        public int? SchoolId { get; set; }
        public int? MajorId { get; set; }
        public string Image { get; set; }
        public string SubHeading { get; set; }
        public string BtnText { get; set; }
        public string BtnLink { get; set; }
        public int? UserId { get; set; }

    }

    public class FaqModel
    {
        public int? Id { get; set; }
        public int? Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? UserId { get; set; }

    }
    public class KeyHighLightModel
    {
        public int? Id { get; set; }
        public string LeftText { get; set; }
        public string RightText { get; set; }
        public int? UserId { get; set; }

    }
    public class KeySkillModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? UserId { get; set; }

    }
}
