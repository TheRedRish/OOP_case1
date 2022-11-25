using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Menues
{
    internal static class SearchForStudent
    {
        public static void RunSearchForStudent(Enrollment enrollment)
        {
            if (enrollment?.EnrollmentsList == null)
            {
                throw new Exception("You have not added any students yet.");
            }
            do
            {
                //Get list of students and print with 5 per line
                Console.Clear();

                var students = from e in enrollment.EnrollmentsList
                               select e.StudentsInfo;

                List<Student> studentsList = students.Distinct().ToList();
                Console.WriteLine("These are your options: ");
                for (int i = 0; i < studentsList.Count; i++)
                {
                    if (i != 0 && i % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                    if (i < studentsList.Count - 1)
                    {
                        Console.Write($"{studentsList[i].FirstName} {studentsList[i].LastName}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{studentsList[i].FirstName} {studentsList[i].LastName}");
                    }
                }
                Console.WriteLine();
                Console.Write("Insert the name of the student you want to find: ");
                string searchName = Console.ReadLine();
                Console.WriteLine();

                List<Enrollment>? chosenEnrollmentsWithStudent = enrollment.EnrollmentsList.FindAll(e => e.StudentsInfo.FirstName.ToLower() + " " + e.StudentsInfo.LastName.ToLower() == searchName.ToLower());

                if (chosenEnrollmentsWithStudent.Count == 0)
                {
                    Console.WriteLine("Could not find a student with the name: " + searchName);
                    Console.ReadLine();
                    continue;
                }


                foreach (Enrollment enrollmentWithStudent in chosenEnrollmentsWithStudent)
                {
                    if (enrollmentWithStudent != null)
                    {
                        Console.Write(enrollmentWithStudent.CourseInfo?.CourseName + " - ");
                        Console.WriteLine($"{enrollmentWithStudent.CourseInfo.TeacherInfo.FirstName} {enrollmentWithStudent.CourseInfo.TeacherInfo.LastName}");
                        Console.WriteLine("-------------------------------");
                    }
                }

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
