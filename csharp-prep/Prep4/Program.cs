using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int newNum = -1;
        int sum = 0;
        int largest;
        int length;

        float avg;

        var numList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (newNum != 0) {
            Console.Write("Enter number: ");
            newNum = int.Parse(Console.ReadLine());
            sum += newNum;

            if (newNum != 0) {
                numList.Add(newNum);
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");

        length = numList.Count;
        avg = (float)sum / length;
        Console.WriteLine($"The average is: {avg}");

        largest = numList[0];
        foreach (int num in numList) {
            if (num > largest) {
                largest = num;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");
        
        }
}