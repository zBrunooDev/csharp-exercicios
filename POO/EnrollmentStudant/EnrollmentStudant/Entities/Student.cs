using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentStudant.Entities.Enums;

namespace EnrollmentStudant.Entities
{
    internal class Student
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public Student(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            Enrollments = new List<Enrollment>();
        }

        // I needed to add the Add methods

    }
}
