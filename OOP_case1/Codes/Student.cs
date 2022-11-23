using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal sealed class Student : PersonModel
    {
        public int? StudentID { get; set; }

        public Student(int studentID, string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
        {
            StudentID = studentID;
        }
    }
}
