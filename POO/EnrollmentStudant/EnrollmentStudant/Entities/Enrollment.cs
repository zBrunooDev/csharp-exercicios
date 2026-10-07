using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentStudant.Entities.Enums;

namespace EnrollmentStudant.Entities
{
    internal class Enrollment
    {
        public DateTime EnrollmentDate { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }

        public Enrollment(DateTime enrollmentDate, Student studant, Course course, EnrollmentStatus status)
        {
            EnrollmentDate = enrollmentDate;
            Student = studant;
            Course = course;
            EnrollmentStatus = status;

        }

        public void Register()
        {
            Course.Enrollments.Add(this);
            Student.Enrollments.Add(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Enrollment Date: {EnrollmentDate}");
            sb.AppendLine($"Student: {Student.Name}");
            sb.AppendLine($"Course: {Course.CourseName}");
            sb.AppendLine($"Status: {EnrollmentStatus}");

            return sb.ToString();
        }
    }
}
