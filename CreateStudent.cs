namespace GradeCalculator;

public static class CreateStudent
{
    public static Student AddStudent()
    {
        string? name;
        string? marks;
        int intMarks;
        bool higherBand;

        //Get students name
        do
        {
            Console.WriteLine("Enter the students name");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) continue;
            //Capitalises first letter
            name = name.ToLower();
            var letters = name.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            name = string.Join("", letters);
        } while (string.IsNullOrEmpty(name));

        //Get students grade from 0-100
        do
        {
            Console.WriteLine("Enter the students grade 0-100");
            marks = Console.ReadLine();
            //validates the input
        } while (!int.TryParse(marks, out intMarks) || intMarks < 0 || intMarks > 100 || marks == "");

        //Gets what band the student is in
        do
        {
            Console.WriteLine($"Qualification level of {name}:\n1.Higher\n2.Lower");
            var entry = Console.ReadLine();
            if (entry?.ToLower() == "higher" || entry == "1")
            {
                higherBand = true;
                break;
            }

            if (entry?.ToLower() == "lower" || entry == "2")
            {
                higherBand = false;
                break;
            }
        } while (true);

        var student = new Student(name, higherBand, intMarks);
        return student;
    }
}