using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal class Student
    {
        public int? StudentID { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;
                Age = (int)AgeConverter.GetAge(_DateOfBirth);
            }
        }
        public int? Age { get; set; }
    }
}
