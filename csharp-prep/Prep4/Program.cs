using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> myInts = new List<int>();
        var otherInts = new List<int>();    // equivalent list declarations

        // add items
        myInts.Add(10);
        myInts.Add(3);
        myInts.Add(45);

        foreach(var n in myInts) {
            Console.WriteLine($"n = {n}");
        }
    }
}