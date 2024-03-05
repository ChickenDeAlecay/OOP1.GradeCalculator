namespace GradeCalculator;

internal static class GradeCalculation
{
    private static List<string?> Grades { get; }
    private static List<int> HigherMarks { get; }
    private static List<int> LowerMarks { get; }

    static GradeCalculation()
    {
        GradeCalculation.Grades = new List<string?> { "A*", "A", "B", "C", "D", "E", "F", "U" };
        GradeCalculation.HigherMarks = new List<int> { 91, 81, 71, 61, 51, 31, 11, 0 };
        GradeCalculation.LowerMarks = new List<int> { 91, 81, 61, 41, 21, 0 };
    }

    public static string? CalculateGrade(int mark, bool higherBand)
    {
        if (higherBand)
            return (from higherMark in GradeCalculation.HigherMarks
                where mark >= higherMark
                select GradeCalculation.Grades[GradeCalculation.HigherMarks.IndexOf(higherMark)]).FirstOrDefault();
        return (from lowerMark in GradeCalculation.LowerMarks
            where mark >= lowerMark
            select GradeCalculation.Grades[GradeCalculation.LowerMarks.IndexOf(lowerMark) + 2]).FirstOrDefault();
    }
}