
List<Student> students = new()
{
    new Student { StudentID = 1, FirstName = "Alexander", LastName = "K. H. Runge", DateOfBirth = new DateTime(2005,5,2)},
    new Student { StudentID = 2, FirstName = "Rune", LastName = "Røddik Hansen", DateOfBirth = new DateTime(1998,5,10) },
    new Student { StudentID = 3, FirstName = "Amanda", LastName = "Gudmand", DateOfBirth = new DateTime(1999,6,2)},
    new Student { StudentID = 4, FirstName = "Dennis", LastName = "Paaske", DateOfBirth = new DateTime(1981,1,22)},
    new Student { StudentID = 5, FirstName = "Mikkel", LastName = "Jensen", DateOfBirth = new DateTime(2005,10,9)}
};

List<Teacher> teachers = new()
{
    new Teacher { Department = "Programmering Underviser", FirtName = "Niels", LastName = "Olesen", DateOfBirth = new DateTime(1972-9-11)}
};

List<Course> courses = new()
{
    new Course { CourseName = "OOP", TeacherInfo = teachers.Find(t => t.FirtName == "Niels")},
    new Course { CourseName = "Grundlæggende Programmering", TeacherInfo = teachers.Find(t => t.FirtName == "Niels")},
    new Course { CourseName = "Studieteknik", TeacherInfo = teachers.Find(t => t.FirtName == "Niels")}
};

List<Enrollment> courseList = new()
{
    new Enrollment { StudentsInfo = students, CourseInfo = courses.Find(c => c.CourseName == "OOP")},
    new Enrollment { StudentsInfo = students, CourseInfo = courses.Find(c => c.CourseName == "Grundlæggende Programmering")},
    new Enrollment { StudentsInfo = students.FindAll(s => s.StudentID != 5 && s.StudentID != 4), CourseInfo = courses.Find(c => c.CourseName == "Studieteknik")}
};

foreach (var course in courseList)
{
    if (course.CourseInfo != null && course.CourseInfo.TeacherInfo != null && course.StudentsInfo != null)
    {
        Console.WriteLine("Elever for følgende fag " + course.CourseInfo.CourseName + ":");
        Console.WriteLine("Lærer: " + course.CourseInfo.TeacherInfo.FirtName + " " + course.CourseInfo.TeacherInfo.LastName);
        foreach (var student in course.StudentsInfo)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
        Console.WriteLine();
    }
}