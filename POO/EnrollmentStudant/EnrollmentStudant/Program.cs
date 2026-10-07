using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentStudant.Entities;
using EnrollmentStudant.Entities.Enums;

namespace EnrollmentStudant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Enter data Studant

            Console.WriteLine("Enter the studant data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Birth: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Student student = new Student(name, birthDate);

            Console.Write("Course: ");
            string courseName = Console.ReadLine();

            Course course = new Course(courseName);

            DateTime dateEnrollment = DateTime.Now;

            Enrollment enrollment = new Enrollment (dateEnrollment, student, course, EnrollmentStatus.Pending);

            enrollment.Register();

            Console.WriteLine(enrollment);

        }
    }
}
