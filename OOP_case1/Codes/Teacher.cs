using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal sealed class Teacher : Person , ITecPerson
    {
        public string? Department { get; set; }

        public Teacher(string derpartment, string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth) 
        {
            Department = derpartment;
        }
        public string? GetDepartment()
        {
            return Department;
        }
        public List<string>? GetAllCourses(Enrollment enrollment)
        {
            List<Enrollment> enrollmentsWithTeacher = enrollment.EnrollmentsList.FindAll(e => e.CourseInfo.TeacherInfo.FirstName == FirstName && e.CourseInfo.TeacherInfo.LastName == LastName);
            List<string> studentCourses = new();
            foreach (Enrollment enrollmentWithTeacher in enrollmentsWithTeacher)
            {
                if (enrollmentWithTeacher.CourseInfo.CourseName != null)
                {
                    studentCourses.Add(enrollmentWithTeacher.CourseInfo.CourseName);
                }
            }
            return studentCourses.Distinct().ToList();
        }
        public override string KickAssAndTakeNames(bool kickAss)
        {
            if (kickAss)
            {
                return base.KickAssAndTakeNames(kickAss);
            }
            return "Mr. / Ms. " + LastName;
        }
    }
}
