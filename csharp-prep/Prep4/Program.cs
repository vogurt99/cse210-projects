using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write($"Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        int listTotal = numbers.Sum(x => Convert.ToInt32(x));
        Console.WriteLine($"The sum is: {listTotal}");

        double listAverage = numbers.Average();
        Console.WriteLine($"The average is: {listAverage}");

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            largestNumber = number;
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}