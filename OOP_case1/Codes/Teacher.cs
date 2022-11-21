using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal class Teacher : PersonModel
    {
        public string? Department { get; set; }

        public Teacher(string derpartment, string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth) 
        {
            Department = derpartment;
        } 
    }
}
