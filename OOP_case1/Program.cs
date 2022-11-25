using OOP_case1.Menues;

Enrollment enrollment = new();
do
{
    Console.Clear();
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. AddStudent");
    Console.WriteLine("2. Teacher");
    Console.WriteLine("3. Student");
    Console.WriteLine("4. Subject");
    Console.WriteLine("9. Exit");
    string? searchUserInput = Console.ReadLine();

    bool isExitNumber = int.TryParse(searchUserInput, out int searchUserInputInt);
    if (searchUserInput.ToLower() == "exit" || (isExitNumber && searchUserInputInt == 9))
    {
        break;
    }
    bool isAnOption = CheckUserInput.CheckIfUserInputMatchesCriteria(searchUserInput);

    if (!isAnOption)
    {
        Console.Write("You have entered something wrong, try again");
        Console.ReadKey();
        continue;
    }

    if (searchUserInput == ((int)EnumCriteria.AddStudent).ToString() || searchUserInput.ToLower() == EnumCriteria.AddStudent.ToString().ToLower())
    {
        AddStudent.RunAddStudent(enrollment);
    }

    // If number for Teacher or text of "Teacher" is input
    if (searchUserInput == ((int)EnumCriteria.Teacher).ToString() || searchUserInput.ToLower() == EnumCriteria.Teacher.ToString().ToLower())
    {
        try
        {
            SearchForTeacher.RunSearchForTeacher(enrollment);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
    //If number for Student or text of "Student" is input
    else if (searchUserInput == ((int)EnumCriteria.Student).ToString() || searchUserInput.ToLower() == EnumCriteria.Student.ToString().ToLower())
    {
        try
        {
            SearchForStudent.RunSearchForStudent(enrollment);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
    // If number for Subject or text of "Subject" is input
    else if (searchUserInput == ((int)EnumCriteria.Subject).ToString() || searchUserInput.ToLower() == EnumCriteria.Subject.ToString().ToLower())
    {
        try
        {
            SearchForCourse.RunSearchForCourse(enrollment);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }

} while (true);