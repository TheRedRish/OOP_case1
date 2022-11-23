using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal interface ITecPerson
    {
        public abstract List<string>? GetAllCourses(Enrollment enrollment);
    }
}
