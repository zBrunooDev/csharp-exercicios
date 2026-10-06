using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentStudant.Entities
{
    internal class Course
    {
        public string CourseName { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        public Course(string courseName)
        {
            CourseName = courseName;
            Enrollments = new List<Enrollment>();
        }
    }
}
