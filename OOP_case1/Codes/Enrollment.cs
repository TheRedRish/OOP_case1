using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal class Enrollment
    {
        public Student? StudentsInfo { get; set; }
        public Course? CourseInfo { get; set; }
        public List<Enrollment> EnrollmentsList { get; set; }
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentsInfo = studentInfo;
            CourseInfo = courseInfo;
        }
        public Enrollment() { }
    }
}
