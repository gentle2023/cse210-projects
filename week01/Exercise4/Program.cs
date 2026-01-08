using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        double average = (double)sum / numbers.Count;

        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }
        int smallest = numbers[0];
        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                smallest = num;
            }

        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
    }

}