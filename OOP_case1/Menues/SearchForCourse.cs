using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Menues
{
    internal class SearchForCourse
    {
        public static void RunSearchForCourse(Enrollment enrollment)
        {
            if (enrollment?.EnrollmentsList == null)
            {
                throw new Exception("You have not added any students yet.");
            }
            do
            {
                //Get list of courses and print with 5 per line
                Console.Clear();

                var courses = from e in enrollment.EnrollmentsList
                               select e.CourseInfo.CourseName;

                List<string> coursesList = courses.Distinct().ToList();
                Console.WriteLine("These are your options: ");
                for (int i = 0; i < coursesList.Count; i++)
                {
                    if (i != 0 && i % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                    if (i < coursesList.Count - 1)
                    {
                        Console.Write($"{coursesList[i]}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{coursesList[i]}");
                    }
                }
                Console.WriteLine();
                Console.Write("Insert the name of the course you want to find: ");
                string searchName = Console.ReadLine();
                Console.WriteLine();

                List<Enrollment>? chosenEnrollmentsWithCourse = enrollment.EnrollmentsList.FindAll(e => e.CourseInfo.CourseName.ToLower() == searchName.ToLower());

                if (chosenEnrollmentsWithCourse.Count == 0)
                {
                    Console.WriteLine("Could not find a course with the name: " + searchName);
                    Console.ReadLine();
                    continue;
                }

                
                bool firstTimeToWriteTitle = true;
                List<Person?> personsLoopedThrough = new();
                foreach (Enrollment enrollmentWithCourse in chosenEnrollmentsWithCourse)
                {
                    if (firstTimeToWriteTitle)
                    {
                        Console.WriteLine("Students for the course: " + searchName);
                        firstTimeToWriteTitle = false;
                    }

                    if (!personsLoopedThrough.Contains(enrollmentWithCourse.CourseInfo.TeacherInfo))
                    {
                    Console.WriteLine($"Teacher: {enrollmentWithCourse.CourseInfo.TeacherInfo.LastName} {enrollmentWithCourse.CourseInfo.TeacherInfo.LastName}");
                    personsLoopedThrough.Add(enrollmentWithCourse.CourseInfo.TeacherInfo);
                    }

                    if (!personsLoopedThrough.Contains(enrollmentWithCourse.StudentsInfo))
                    {
                    Console.WriteLine($"{enrollmentWithCourse.StudentsInfo.FirstName} {enrollmentWithCourse.StudentsInfo.LastName}");
                    personsLoopedThrough.Add(enrollmentWithCourse.StudentsInfo);
                    }
                }
                Console.WriteLine("-------------------------------");

                Console.WriteLine();
                Console.Write("Press 'M' to go back to the menu or 'Enter' to search for another student: ");
                string closeProgramUserInput = Console.ReadLine();
                if (closeProgramUserInput.ToLower() == "m")
                {
                    break;
                }
            } while (true);
        }
    }
}
