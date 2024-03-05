namespace GradeCalculator;

internal static class Program
{
   private static void Main()
    {
        //variables
        var students = new List<Student>();

        //adding students to list
        while (true)
        {
            Console.WriteLine("Add Student:\n1.Add\n2.Continue");
            var menuChoice = Console.ReadLine();
            if (menuChoice?.ToLower() == "add" || menuChoice?.ToLower() == "1") students.Add(CreateStudent.AddStudent());

            if (menuChoice?.ToLower() == "continue" || menuChoice?.ToLower() == "2") break;

            Console.Clear();
        }

        //formatting and displaying all students
        Console.Clear();
        foreach (var student in students)
            Console.WriteLine($"|{student.Name,10}|{student.Marks,10}|{student.Grade,10}|{student.Passed,10}|");

        //highest grade 
        students.Sort((x, y) => string.CompareOrdinal(x.Grade, y.Grade));
        Console.WriteLine($"\n{students[0].Name} achieved the highest grade of {students[0].Grade}\n");

        //average mark
        var totalGrades = students.Sum(student => student.Marks);

        Console.WriteLine(
            $"For the class the mean average was: {totalGrades / students.Count} which was a grade {GradeCalculation.CalculateGrade(totalGrades / students.Count, true)} " +
            $"for the higher band and a grade {GradeCalculation.CalculateGrade(totalGrades / students.Count, false)} for the lower band ");

        Console.WriteLine(
            $"For the class the median average was: {students[students.Count() / 2].Marks} which was a grade {GradeCalculation.CalculateGrade(students[students.Count() / 2].Marks, true)} " +
            $"for the higher band and a grade {GradeCalculation.CalculateGrade(students[students.Count() / 2].Marks, false)} for the lower band ");

        Console.ReadKey();
    }
}