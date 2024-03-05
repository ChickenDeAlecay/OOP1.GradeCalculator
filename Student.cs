namespace GradeCalculator;

public class Student
{
    public string Name { get; }
    private bool HigherBand { get; }
    public int Marks { get; }
    public string? Grade { get; }
    public string Passed { get; set; }

    public Student(string name, bool higherBand, int marks)
    {
        this.Name = name;
        this.HigherBand = higherBand;
        this.Marks = marks;
        this.Grade = GradeCalculation.CalculateGrade(this.Marks, this.HigherBand);
        this.Passed = this.StudentPassed();
    }

    private string StudentPassed()
    {
        if (this.Grade is "A*" or "A" or "B" or "C")
            return "Passed";

        return "Failed";
    }
}