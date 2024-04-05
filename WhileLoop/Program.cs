using System;
namespace WhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        int Number = 25;
        int i = 0;
        while(i < Number)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        Console.WriteLine("Enter the No1: ");
        bool isvalid = int.TryParse(Console.ReadLine(),out int No1);
        while(!isvalid)
        {
            Console.Write("Invalid Number. Try Again");
            isvalid = int.TryParse(Console.ReadLine(),out No1);
        }
    }
}