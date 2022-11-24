Enrollment enrollment = new();
do
{
    Console.Write("Angiv elevens ID: ");
    int studentID = Convert.ToInt16(Console.ReadLine());
    Console.Write("Angiv elevens fornavn: ");
    string studentFirstName = Console.ReadLine();
    Console.Write("Angiv elevens efternavn: ");
    string studentLastName = Console.ReadLine();
    Console.Write("Angiv elevens fødselsdag: ");
    string studentDateOfBirthUserInput = Console.ReadLine();
    bool isDateTime = DateTime.TryParse(studentDateOfBirthUserInput, out DateTime studentDateOfBirth);
    if (!isDateTime)
    {
        Console.WriteLine("Forkert dato format!");
        continue;
    }

    Console.WriteLine("Angiv fag (Vælg mellem disse fag): ");
    foreach (var course in Enum.GetValues(typeof(EnumCourses)))
    {
        Console.WriteLine(course.ToString());
    }
    Console.WriteLine("---------------------------------------");
    string courseInput = Console.ReadLine();

    FindCourse findCourse = new();
    Course? studentCourse = findCourse.FindMatchingCourse(courseInput);
    if (studentCourse == null)
    {
        Console.WriteLine("Ingen fag ved dette navn");
        continue;
    }

    try
    {
        enrollment.Enroll(new Enrollment(new Student(studentID, studentFirstName, studentLastName, studentDateOfBirth), studentCourse));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    foreach (Enrollment enrollment1 in enrollment.EnrollmentsList)
    {
        if (enrollment1.CourseInfo.CourseName == studentCourse.CourseName)
        {
            Console.WriteLine($"{enrollment1.StudentsInfo.FirstName} {enrollment1.StudentsInfo.LastName} er tilmeldt {enrollment1.CourseInfo.CourseName}");
        }
    }
} while (true);

//Student alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(2005, 5, 2));
//Student amanda = new Student(2, "Amanda", "Elisabeth Vang Gudmand", new DateTime(1999, 6, 2));
//Student dennis = new Student(3, "Dennis", "Daniel B. Paaske", new DateTime(1981, 1, 22));
//Student rune = new Student(4, "Rune", "Røddik Hansen", new DateTime(1990, 10, 24));
//Student mikkel = new Student(5, "Mikkel", "Jensen", new DateTime(1999, 3, 10));

//List<Enrollment> enrollmentsList = new() {
//new Enrollment(alexander, studieTeknik),
//new Enrollment(alexander, grundProg),
//new Enrollment(alexander, oop),
//new Enrollment(amanda, studieTeknik),
//new Enrollment(amanda, grundProg),
//new Enrollment(amanda, oop),
//new Enrollment(dennis, studieTeknik),
//new Enrollment(dennis, grundProg),
//new Enrollment(dennis, oop),
//new Enrollment(rune, grundProg),
//new Enrollment(rune, oop),
//new Enrollment(mikkel, grundProg),
//new Enrollment(mikkel, oop)
//};

//Enrollment enrollment = new();

//// Enroll initial group
//enrollment.Enroll(enrollmentsList);

//// Enroll from user input
//try
//{
//    enrollment.Enroll(new Enrollment(mikkel, studieTeknik));
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//foreach (var enrollment1 in enrollment.EnrollmentsList)
//{
//    Console.WriteLine(enrollment1.StudentsInfo.LastName);
//}

//foreach (string someCourse in niels.GetAllCourses(enrollment.EnrollmentsList))
//{
//    Console.WriteLine(someCourse + ", ");
//};

//foreach (var course in enrollment.EnrollmentsList)
//{
//    if (course.CourseInfo != null && course.CourseInfo.TeacherInfo != null && course.StudentsInfo != null)
//    {
//        Console.Write(course.StudentsInfo.GetAge() + " ");
//        Console.WriteLine(course.StudentsInfo.FirstName + " " + course.StudentsInfo.LastName + ", fag: " + course.CourseInfo.CourseName
//            + ", Lærer: " + course.CourseInfo.TeacherInfo.FirstName + " " + course.CourseInfo.TeacherInfo.LastName);
//    }
//}

//Console.WriteLine(niels.KickAssAndTakeNames(false));
//Console.WriteLine(rune.KickAssAndTakeNames(true));