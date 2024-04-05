using System;
namespace TypeConversion;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter subject1 marks: ");
        double marks1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter subject2 marks: ");
        double marks2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter subject3 marks: ");
        double marks3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Grade: ");
        char Grade = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter MobileNo: ");
        double MobileNo = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter MailID: ");
        string MailID = Console.ReadLine();
        Console.WriteLine("Trainee Details are: ");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Marks1: " + marks1 );
        Console.WriteLine("Marks2: " + marks2 );
        Console.WriteLine("Marks3: " + marks3 );
       double Total = marks1 + marks2 + marks3;
        Console.WriteLine("Total: " + Total);
       double Average = Total / 3;
        Console.WriteLine("Average: " + Average);
        Console.WriteLine("Grade: " + Grade);
        Console.WriteLine("MobileNo: " + MobileNo);
        Console.WriteLine("MailID: " + MailID);



    }
}