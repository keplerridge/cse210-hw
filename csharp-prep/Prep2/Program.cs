using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int gpa = int.Parse(Console.ReadLine());

        char letter;

        if (gpa >= 90)
        {
            letter = 'A';
        }
        else if (gpa >= 80)
        {
            letter = 'B';
        }
        else if (gpa >= 70)
        {
            letter = 'C';
        }
        else if (gpa >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your grade: {letter}");

        if (letter == 'A' || letter == 'B' || letter == 'C')
        {
            Console.WriteLine($"Well done you are passing the class with a/an {letter}!");
        }
        else
        {
            Console.WriteLine($"You are failing the course, your grade is a/an {letter}, please try harder!");
        }
    }
}