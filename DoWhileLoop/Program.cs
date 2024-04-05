using System;
using System.Reflection.Metadata;
namespace DoWhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        string answer = " ";
        do
        {
           Console.WriteLine("Enter the number: ");
           int number = int.Parse(Console.ReadLine());
           if (number % 2 == 0)
           {
            Console.WriteLine("This is even number");
           }
           else
           {
            Console.WriteLine("This is odd number");
           }
           Console.WriteLine("Do you want to repeat process : Yes or No");
           answer = Console.ReadLine();
           if(answer == "no")
           {
             break;
           }
           while (answer != "yes")
           {
            Console.WriteLine("Enter Valid Output: ");
            Console.WriteLine("Do you want to repeat process : Yes or No");
            answer = Console.ReadLine();

           }
           
        }while(answer!="yes");
        
    }
}