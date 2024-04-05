using System;
namespace IfCondition;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your marks: ");
        double marks = double.Parse(Console.ReadLine());
        Console.WriteLine(" Enter the Totalmarks: ");
        double Totalmarks = double.Parse(Console.ReadLine());

        if (marks > 80 && marks <= Totalmarks)
        {
            Console. WriteLine("Your Grade is A");
        }
        else if (marks >= 61 && marks <= 80)
        {
            Console. WriteLine("Your Grade is B");
        }
        else if (marks >= 36 && marks <= 60)
        {
            Console. WriteLine("Your Grade is C");
        }
        else if (marks < 36 && marks >= 0)
        {
            Console. WriteLine("Your Grade is D");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
}