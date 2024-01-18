using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*int count = 0;
        while (count < 10)
        {
            Console.WriteLine($"Count is {count}");
            count++;
        }*/

        /*int newCount = 0;
        do
        {
            Console.WriteLine($"Count is {newCount}");
            newCount++;
        } while (newCount < 5);*/

        /*for (var i = 0; i < 5; ++i)
        {
            Console.WriteLine($"i is {i}");
        }*/

        // string magicNumber;
        int guess;

        Random randomGenerator = new Random();
        int rand = randomGenerator.Next(1, 11);

        Console.Write("Guess a number from 1-10: ");
        guess = int.Parse(Console.ReadLine());

        while (guess != rand)
        {
            if (guess > rand)
            {
                Console.Write("Wrong guess, too high, guess again: ");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Wrong guess, too low, guess again: ");
                guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Good job you guessed it!");
    }
}