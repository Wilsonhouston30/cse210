using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Enter as many numbers are you want:");
        Console.WriteLine("Type 0 when done");
        int numberInput = -1;

        List<int> numbers = new List<int>();

        while (numberInput != 0)
        {
            Console.WriteLine("Type 0 when done");
            numberInput = Int32.Parse(Console.ReadLine());
            numbers.Add(numberInput);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}