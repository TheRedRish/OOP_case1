

Student alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(2005, 5, 2));
Student amanda = new Student(2, "Amanda", "Elisabeth Vang Gudmand", new DateTime(1999, 6, 2));
Student dennis = new Student(3, "Dennis", "Daniel B. Paaske", new DateTime(1981, 1, 22));
Student rune = new Student(4, "Rune", "Røddik Hansen", new DateTime(1990, 10, 24));
Student mikkel = new Student(5, "Mikkel", "Jensen", new DateTime(1999, 3, 10));

Teacher niels = new Teacher("Programmering Underviser", "Niels", "Olesen", new DateTime(1972, 9, 11));

Course oop = new("OOP", niels);
Course grundProg = new("Grundlæggende Programmering", niels);
Course studieTeknik = new("Studieteknik", niels);

List<Enrollment> courseList = new()
{
    new Enrollment(alexander, studieTeknik),
    new Enrollment(alexander, grundProg),
    new Enrollment(alexander, oop),
    new Enrollment(amanda, studieTeknik),
    new Enrollment(amanda, grundProg),
    new Enrollment(amanda, oop),
    new Enrollment(dennis, studieTeknik),
    new Enrollment(dennis, grundProg),
    new Enrollment(dennis, oop),
    new Enrollment(ozan, grundProg),
    new Enrollment(ozan, oop,
    new Enrollment(camilla, grundProg),
    new Enrollment(camilla, oop)
};

foreach (var course in courseList)
{
    if (course.CourseInfo != null && course.CourseInfo.TeacherInfo != null && course.StudentsInfo != null)
    {
        Console.WriteLine(course.StudentsInfo.FirstName + " " + course.StudentsInfo.LastName + ", fag: " + course.CourseInfo.CourseName 
            + ", Lærer: " + course.CourseInfo.TeacherInfo.FirstName + " " + course.CourseInfo.TeacherInfo.LastName);
    }
}