using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Codes
{
    internal class FindCourse
    {
        static Teacher niels = new Teacher("Programmering Underviser", "Niels", "Olesen", new DateTime(1972, 9, 11));

        Course oop = new Course(EnumCourses.OOP.ToString(), niels);
        Course grundProg = new Course(EnumCourses.Grundlæggendeprogrammering.ToString(), niels);
        Course clientsideprogrammering = new Course(EnumCourses.Clientsideprogrammering.ToString(), niels);
        Course databaseprogrammering = new Course(EnumCourses.Databaseprogrammering.ToString(), niels);
        Course netvaerk = new Course(EnumCourses.Netværk.ToString(), niels);
        Course studieTeknik = new Course(EnumCourses.Studieteknik.ToString(), niels);
        Course computerteknologi = new Course(EnumCourses.Computerteknologi.ToString(), niels);

        public Course? FindMatchingCourse(string userInput)
        {
            string userInputToLower = userInput.ToLower();
            switch (userInputToLower)
            {
                case "oop":
                    return oop;
                case "grundprog":
                    return grundProg;
                case "clientsideprogrammering":
                    return clientsideprogrammering;
                case "databaseprogrammering":
                    return databaseprogrammering;
                case "netværk":
                    return netvaerk;
                case "studieteknik":
                    return studieTeknik;
                case "computerteknologi":
                    return computerteknologi;
                default:
                    return null;
            }
        }
    }
}
