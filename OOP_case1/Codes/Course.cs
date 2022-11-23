using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal class Course
    {
        public string? CourseName { get; set; }
        public Teacher? TeacherInfo { get; set; }

        public Course(string courseName, Teacher teacherInfo)
        {
            CourseName = courseName;
            TeacherInfo = teacherInfo;
        }
    }
}
