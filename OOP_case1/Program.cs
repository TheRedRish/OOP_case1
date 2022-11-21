

Student alexander = new() { StudentID = 1, FirstName = "Alexander", LastName = "K. H. Runge", DateOfBirth = new DateTime(2005, 5, 2) };
Student rune = new() { StudentID = 2, FirstName = "Rune", LastName = "Røddik Hansen", DateOfBirth = new DateTime(1998, 5, 10) };
Student amanda = new() { StudentID = 3, FirstName = "Amanda", LastName = "Gudmand", DateOfBirth = new DateTime(1999, 6, 2) };
Student dennis = new() { StudentID = 4, FirstName = "Dennis", LastName = "Paaske", DateOfBirth = new DateTime(1981, 1, 22) };
Student mikkel = new() { StudentID = 5, FirstName = "Mikkel", LastName = "Jensen", DateOfBirth = new DateTime(2005, 10, 9) };


Teacher niels = new() { Department = "Programmering Underviser", FirstName = "Niels", LastName = "Olesen", DateOfBirth = new DateTime(1972 - 9 - 11) };



Course oop = new() { CourseName = "OOP", TeacherInfo = niels };
Course grundProg = new() { CourseName = "Grundlæggende Programmering", TeacherInfo = niels };
Course studieTeknik = new() { CourseName = "Studieteknik", TeacherInfo = niels };


List<Enrollment> courseList = new()
{
    new Enrollment { StudentsInfo = alexander, CourseInfo = oop},
    new Enrollment { StudentsInfo = alexander, CourseInfo = grundProg},
    new Enrollment { StudentsInfo = alexander, CourseInfo = studieTeknik},
    new Enrollment { StudentsInfo = rune, CourseInfo = oop},
    new Enrollment { StudentsInfo = rune, CourseInfo = grundProg},
    new Enrollment { StudentsInfo = rune, CourseInfo = studieTeknik},
    new Enrollment { StudentsInfo = amanda, CourseInfo = oop},
    new Enrollment { StudentsInfo = amanda, CourseInfo = grundProg},
    new Enrollment { StudentsInfo = amanda, CourseInfo = studieTeknik},
    new Enrollment { StudentsInfo = dennis, CourseInfo = oop},
    new Enrollment { StudentsInfo = dennis, CourseInfo = grundProg},
    new Enrollment { StudentsInfo = mikkel, CourseInfo = oop},
    new Enrollment { StudentsInfo = mikkel, CourseInfo = grundProg},
};

foreach (var course in courseList)
{
    if (course.CourseInfo != null && course.CourseInfo.TeacherInfo != null && course.StudentsInfo != null)
    {
        Console.WriteLine(course.StudentsInfo.FirstName + " " + course.StudentsInfo.LastName + ", fag: " + course.CourseInfo.CourseName 
            + ", Lærer: " + course.CourseInfo.TeacherInfo.FirstName + " " + course.CourseInfo.TeacherInfo.LastName);
    }
}