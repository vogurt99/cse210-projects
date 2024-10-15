using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War");

        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeworkList);

        string writingInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingInformation);
    }
}