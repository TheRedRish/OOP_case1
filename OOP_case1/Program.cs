Student alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(2005, 5, 2));
Student amanda = new Student(2, "Amanda", "Elisabeth Vang Gudmand", new DateTime(1999, 6, 2));
Student dennis = new Student(3, "Dennis", "Daniel B. Paaske", new DateTime(1981, 1, 22));
Student rune = new Student(4, "Rune", "Røddik Hansen", new DateTime(1990, 10, 24));
Student mikkel = new Student(5, "Mikkel", "Jensen", new DateTime(1999, 3, 10));

Teacher niels = new Teacher("Programmering Underviser", "Niels", "Olesen", new DateTime(1972, 9, 11));

Course oop = new Course(CoursesEnum.OOP.ToString(), niels);
Course grundProg = new Course(CoursesEnum.Grundlæggendeprogrammering.ToString(), niels);
Course clientsideprogrammering = new Course(CoursesEnum.Clientsideprogrammering.ToString(), niels);
Course databaseprogrammering = new Course(CoursesEnum.Databaseprogrammering.ToString(), niels);
Course netvaerk = new Course(CoursesEnum.Netværk.ToString(), niels);
Course studieTeknik = new Course(CoursesEnum.Studieteknik.ToString(), niels);
Course computerteknologi = new Course(CoursesEnum.Computerteknologi.ToString(), niels);

List<Enrollment> enrollmentsList = new() {
new Enrollment(alexander, studieTeknik),
new Enrollment(alexander, grundProg),
new Enrollment(alexander, oop),
new Enrollment(amanda, studieTeknik),
new Enrollment(amanda, grundProg),
new Enrollment(amanda, oop),
new Enrollment(dennis, studieTeknik),
new Enrollment(dennis, grundProg),
new Enrollment(dennis, oop),
new Enrollment(rune, grundProg),
new Enrollment(rune, oop),
new Enrollment(mikkel, grundProg),
new Enrollment(mikkel, oop)
};

Enrollment enrollment = new();

// Enroll initial group
enrollment.Enroll(enrollmentsList);

// Enroll from user input
try
{
    enrollment.Enroll(new Enrollment(mikkel, studieTeknik));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


foreach (var enrollment1 in enrollment.EnrollmentsList)
{
    Console.WriteLine(enrollment1.StudentsInfo.LastName);
}

foreach (string someCourse in niels.GetAllCourses(enrollment.EnrollmentsList))
{
    Console.WriteLine(someCourse + ", ");
};

foreach (var course in enrollment.EnrollmentsList)
{
    if (course.CourseInfo != null && course.CourseInfo.TeacherInfo != null && course.StudentsInfo != null)
    {
        Console.Write(course.StudentsInfo.GetAge() + " ");
        Console.WriteLine(course.StudentsInfo.FirstName + " " + course.StudentsInfo.LastName + ", fag: " + course.CourseInfo.CourseName
            + ", Lærer: " + course.CourseInfo.TeacherInfo.FirstName + " " + course.CourseInfo.TeacherInfo.LastName);
    }
}

Console.WriteLine(niels.KickAssAndTakeNames(false));
Console.WriteLine(rune.KickAssAndTakeNames(true));