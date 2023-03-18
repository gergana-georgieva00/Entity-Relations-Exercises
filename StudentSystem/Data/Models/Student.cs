using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        // One student can have many Courses 
        // One student can have many Homeworks 

        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
            Homeworks = new HashSet<Homework>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? BirthDay { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
