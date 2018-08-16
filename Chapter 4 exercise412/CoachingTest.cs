using System;

class CoachingTest
{
    static void Main()
    {
        Coaching coaching1 = new Coaching(default, default, default, default);

        Console.Write("Enter coaching type: ");
        coaching1.CoachingType = Console.ReadLine();
        Console.Write("Enter number of players: ");
        coaching1.Players = int.Parse(Console.ReadLine());
        Console.Write("Enter class timings: ");
        coaching1.ClassTimings = Console.ReadLine();
        Console.Write("Enter charges: ");
        coaching1.Charges = decimal.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write(coaching1.DisplayDetails());

        Console.ReadLine();
    }
}

