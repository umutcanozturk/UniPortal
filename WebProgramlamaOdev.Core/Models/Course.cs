using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Core.Models
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseDetails { get; set; }
        public DateTime StartDate { get; set; }
        public int CourseDuration { get; set; }
        public int CoursePrice { get; set; }
        public virtual Teacher Teacher {get;set;}
    }
}
