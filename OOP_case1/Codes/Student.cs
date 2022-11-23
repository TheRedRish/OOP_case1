using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal sealed class Student : Person , ITecPerson
    {
        public int? StudentID { get; set; }

        public Student(int studentID, string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
        {
            StudentID = studentID;
        }
        public List<string>? GetAllCourses(Enrollment enrollment)
        {
            List<Enrollment> enrollmentsWithStudent = enrollment.EnrollmentsList.FindAll(e => e.StudentsInfo.StudentID == StudentID);
            List<string> studentCourses = new();
            foreach (Enrollment enrollmentWithStudent in enrollmentsWithStudent)
            {
                if (enrollmentWithStudent.CourseInfo.CourseName != null)
                {
                studentCourses.Add(enrollmentWithStudent.CourseInfo.CourseName);
                }
            }
            return studentCourses;
        }
    }
}
