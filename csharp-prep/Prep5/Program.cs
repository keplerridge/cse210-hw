using System;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SqaureNumber(int num) {
        return num * num;
    }

    static void DisplayResult(string name, int num) {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
    static void Main(string[] args)
    {
        int numSquared;
        string name;
        DisplayWelcome();
        name = PromptUserName();
        numSquared = SqaureNumber(PromptUserNumber());
        DisplayResult(name, numSquared);
    }
}