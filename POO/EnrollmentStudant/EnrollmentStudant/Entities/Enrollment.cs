using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentStudant.Entities
{
    internal class Enrollment
    {
        public DateTime EnrollmentDate { get; set; }
        public Student Studant { get; set; }
        public Course Course { get; set; }

        public Enrollment(DateTime enrollmentDate, Student studant, Course course)
        {
            EnrollmentDate = enrollmentDate;
            Studant = studant;
            Course = course;
        }

    }
}
