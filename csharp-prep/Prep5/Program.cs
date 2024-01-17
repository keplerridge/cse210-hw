using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        int Add2(int number) {
            return number + 2;
        }
        Console.WriteLine($"4 + 2 = {Add2(4)}");
    }
}