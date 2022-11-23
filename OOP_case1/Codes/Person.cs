using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal abstract class Person
    {
        private string _AssKicked = "I've just kicked ass";
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

        public Person(string? firstName, string? lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public int? GetAge()
        {
            return Age;
        }
        public virtual string KickAssAndTakeNames(bool kickAss)
        {
            if (kickAss)
            {
                return _AssKicked;
            }
            else return FirstName + " " + LastName;
        }
    }
}
