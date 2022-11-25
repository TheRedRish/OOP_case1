using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case1.Menues
{
    internal class AddStudent
    {
        public static void RunAddStudent(Enrollment enrollment)
        {
            do
            {
                Console.Clear();
                Console.Write("The students ID: ");
                bool studentIDUserInput = int.TryParse(Console.ReadLine(), out int studentID);
                if (!studentIDUserInput)
                {
                    Console.WriteLine(studentIDUserInput + " is not a number, try again!");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("The students first name: ");
                string studentFirstName = Console.ReadLine();
                Console.Write("The students last name: ");
                string studentLastName = Console.ReadLine();
                Console.Write("The students birthday: ");
                string studentDateOfBirthUserInput = Console.ReadLine();
                bool isDateTime = DateTime.TryParse(studentDateOfBirthUserInput, out DateTime studentDateOfBirth);
                if (!isDateTime)
                {
                    Console.WriteLine("Wrong date format, try again!");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Choose course (Choose between these courses): ");
                Console.WriteLine("---------------------------------------");
                foreach (EnumCourses course in Enum.GetValues(typeof(EnumCourses)))
                {
                    Console.WriteLine(course.ToString());
                }
                Console.WriteLine("---------------------------------------");
                string courseInput = Console.ReadLine();

                FindCourse findCourse = new();
                Course? studentCourse = findCourse.FindMatchingCourse(courseInput);
                if (studentCourse == null)
                {
                    Console.WriteLine("No course with that name");
                    Console.ReadKey();
                    continue;
                }

                enrollment.Enroll(new Enrollment(new Student(studentID, studentFirstName, studentLastName, studentDateOfBirth), studentCourse));

                Console.WriteLine($"{studentFirstName} {studentLastName} has been added to {studentCourse.CourseName}");
                Console.WriteLine();
                if (enrollment.EnrollementMessage != null)
                {
                    Console.WriteLine("Note! " + enrollment.EnrollementMessage);
                }
                Console.WriteLine("This is the current list of students for " + studentCourse.CourseName);
                foreach (Enrollment enrollment1 in enrollment.EnrollmentsList)
                {
                    if (enrollment1.CourseInfo.CourseName == studentCourse.CourseName)
                    {
                        Console.WriteLine($"{enrollment1.StudentsInfo.FirstName} {enrollment1.StudentsInfo.LastName}");
                    }
                }

                Console.Write("Press 'M' to go back to the menu or 'Enter' to add another student: ");
                string closeProgramUserInput = Console.ReadLine();
                if (closeProgramUserInput.ToLower() == "m")
                {
                    break;
                }
            } while (true);
        }
    }
}
