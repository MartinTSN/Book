using System;

class StudentRecordTest
{
    static void Main()
    {
        Student student1 = new Student("1", default, default, default, default);
        Student student2 = new Student("2", default, default, default, default);

        Console.Write("Enter Name for student1: ");
        student1.StudentName = Console.ReadLine();
        Console.Write("Enter Math marks: ");
        student1.Math = decimal.Parse(Console.ReadLine());
        Console.Write("Enter English marks: ");
        student1.English = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Biology marks: ");
        student1.Biology = decimal.Parse(Console.ReadLine());

        Console.Write("Press enter to continue");
        Console.ReadLine();
        Console.Clear();

        Console.Write("Enter Name for student2: ");
        student2.StudentName = Console.ReadLine();
        Console.Write("Enter Math marks: ");
        student2.Math = decimal.Parse(Console.ReadLine());
        Console.Write("Enter English marks: ");
        student2.English = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Biology marks: ");
        student2.Biology = decimal.Parse(Console.ReadLine());

        Console.Write("Press enter to continue");
        Console.ReadLine();
        Console.Clear();

        Console.Write($"Student1's aggregated score is: {student1.GetAggregate(student1.Math, student1.English, student1.Biology)}");
        Console.Write($"\nStudent1's score percentage is: {student1.GetPercentage(student1.Math, student1.English, student1.Biology)}");

        Console.Write($"\n\nStudent2's aggregated score is: {student2.GetAggregate(student2.Math, student2.English, student2.Biology)}");
        Console.Write($"\nStudent2's score percentage is: {student2.GetPercentage(student2.Math, student2.English, student2.Biology)}");
        Console.ReadLine();
    }
}