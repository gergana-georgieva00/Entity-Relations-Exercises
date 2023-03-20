using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class StudentCourse
    {
        // Mapping between Students and Courses

        public Student Student { get; set; }
        public int StudentId { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
