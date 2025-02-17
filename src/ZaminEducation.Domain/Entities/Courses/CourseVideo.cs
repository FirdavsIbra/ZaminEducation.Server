using System.ComponentModel.DataAnnotations;
using ZaminEducation.Domain.Commons;

namespace ZaminEducation.Domain.Entities.Courses
{
    public class CourseVideo : Auditable
    {
        [Required, DataType(DataType.Url)]
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public long Length { get; set; }

        public long CourseModuleId { get; set; }
        public CourseModule CourseModule { get; set; }

        public long? CourseId { get; set; }
        public Course Course { get; set; }
    }
}