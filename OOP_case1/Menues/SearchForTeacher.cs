using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Menues
{
    internal static class SearchForTeacher
    {
        public static void RunSearchForTeacher(Enrollment? enrollment)
        {
            if (enrollment?.EnrollmentsList == null)
            {
                throw new Exception("You have not added any students yet.");
            }
            do
            {
                //Get list of teachers and print with 5 per line
                Console.Clear();
                var teachers = from e in enrollment.EnrollmentsList
                               select e.CourseInfo?.TeacherInfo;

                List<Teacher> teachersList = teachers.Distinct().ToList();

                Console.WriteLine("These are your options: ");
                for (int i = 0; i < teachersList.Count; i++)
                {
                    if (i != 0 && i % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                    if (i < teachersList.Count - 1)
                    {
                        Console.Write($"{teachersList[i].FirstName} {teachersList[i].LastName}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{teachersList[i].FirstName} {teachersList[i].LastName}");
                    }
                }

                Console.WriteLine();
                Console.Write("Insert the name of the teacher you want to find: ");
                string searchName = Console.ReadLine();
                Console.WriteLine();

                List<Enrollment>? chosenEnrollmentsWithTeacher = enrollment.EnrollmentsList.FindAll(e => e.CourseInfo?.TeacherInfo?.FirstName.ToLower() + " " + e.CourseInfo?.TeacherInfo?.LastName.ToLower() == searchName.ToLower());

                if (chosenEnrollmentsWithTeacher.Count == 0)
                {
                    Console.WriteLine("Could not find a teacher with the name: " + searchName);
                    Console.ReadLine();
                    continue;
                }

                List<string?> coursesLoopedThrough = new();
                foreach (Enrollment enrollmentWithTeacher in chosenEnrollmentsWithTeacher)
                {
                    if (enrollmentWithTeacher != null)
                    {
                        if (enrollmentWithTeacher.CourseInfo?.CourseName != null && !coursesLoopedThrough.Contains(enrollmentWithTeacher.CourseInfo?.CourseName))
                        {
                            Console.WriteLine(enrollmentWithTeacher.CourseInfo?.CourseName + ":");
                            List<Enrollment> enrollmentsWithCourse = chosenEnrollmentsWithTeacher.FindAll(e => e.CourseInfo?.CourseName == enrollmentWithTeacher.CourseInfo?.CourseName);
                            foreach (Enrollment enrollmentWithCourse in enrollmentsWithCourse)
                            {
                                Console.WriteLine(enrollmentWithTeacher.StudentsInfo?.FirstName + " " + enrollmentWithTeacher.StudentsInfo?.LastName);
                            }
                            Console.WriteLine("-------------------------------");
                            coursesLoopedThrough.Add(enrollmentWithTeacher.CourseInfo?.CourseName);
                        }
                    }
                }

                Console.WriteLine();
                Console.Write("Press 'M' to go back to the menu or 'Enter' to search for another teacher: ");
                string closeProgramUserInput = Console.ReadLine();
                if (closeProgramUserInput.ToLower() == "m")
                {
                    break;
                }
            } while (true);
        }
    }
}
