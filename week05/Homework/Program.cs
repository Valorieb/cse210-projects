using System;
using Homework;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Fred", "Biology");
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        MathAssignment math1 = new MathAssignment("Gabe", "Algebra","Section 5.2", "Problems 1-20");
        string hwList1 = math1.GetHomeworkList();
        string mathSummary1 = math1.GetSummary();
        Console.Write(mathSummary1);
        Console.WriteLine(hwList1);

        WritingAssignment write1 = new WritingAssignment("Anna", "Shakespeare", "Hamlet");
        Console.Write(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}