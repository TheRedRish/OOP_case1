using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal class Enrollment : IComparable<Enrollment>
    {
        public Student? StudentsInfo { get; set; }
        public Course? CourseInfo { get; set; }
        public string? EnrollementMessage { get; set; }
        public List<Enrollment> EnrollmentsList { get; set; }
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentsInfo = studentInfo;
            CourseInfo = courseInfo;
        }
        public Enrollment() { }

        public void Enroll(Enrollment enrollment)
        {
            if (EnrollmentsList == null)
            {
                EnrollmentsList = new();
            }         
            EnrollmentsList.Add(enrollment);
            EnrollmentsList.Sort();
            string? enrollmentMessage = CheckStudentCount(enrollment.CourseInfo);
            if (enrollmentMessage != null)
            {
                EnrollementMessage = enrollmentMessage;
            };
        }
        public void Enroll(List<Enrollment> enrollments)
        {
            if (EnrollmentsList == null)
            {
                EnrollmentsList = new();
            }
            foreach (Enrollment enrollment in enrollments)
            {
                EnrollmentsList.Add(enrollment);
                EnrollmentsList.Sort();
            }
        }
        public int CompareTo(Enrollment? other)
        {
            if (other != null)
            {
                return this.StudentsInfo.LastName.CompareTo(other.StudentsInfo.LastName);
            }
            else return 1;
        }
        private string? CheckStudentCount(Course courseInfo)
        {
            List<Enrollment> enrollements = EnrollmentsList.FindAll(e => e.CourseInfo == courseInfo);
            if (enrollements.Count() < 8)
            {
                return "Too few students in " + courseInfo.CourseName;
            }
            else if (enrollements.Count() > 16)
            {
                return "Too many students in " + courseInfo.CourseName;
            }
            return null;
        }

        //Work in progress of errorchecking when adding list.
        private List<string> CheckStudentCountTest()
        {
            List<string> errorMessageCoursesWithTooFewOrTooManyStudents = new();
            List<Course?> courses = new();
            foreach (var enrollment in EnrollmentsList)
            {
                courses.Add(enrollment.CourseInfo);
            }
            courses = courses.Distinct().ToList();
            foreach (Course course in courses)
            {
                List<Enrollment> enrollements = EnrollmentsList.FindAll(e => e.CourseInfo == course);
                if (enrollements.Count() < 8)
                {
                    errorMessageCoursesWithTooFewOrTooManyStudents.Add("Der er for få elever i " + course.CourseName);
                }
                else if (enrollements.Count() > 16)
                {
                    errorMessageCoursesWithTooFewOrTooManyStudents.Add("Der er for mange elever i " + course.CourseName);
                }
            }
            return errorMessageCoursesWithTooFewOrTooManyStudents;
        }
    }
}
