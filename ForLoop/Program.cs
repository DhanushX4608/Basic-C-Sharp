using System;
namespace ForLoop;
class Program 
{
    /*public static void Main(string[] args)
    {
        Console.WriteLine("Enter Num1: ");
        int Num1 =int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Num2: ");
        int Num2 =int.Parse(Console.ReadLine());
        int temp = 0;
        for(int i = Num1; i <= Num2; i++)
        {
           int square1  = i*i;
           temp = temp + square1;
        }
        Console.WriteLine("The sum of square of two numbers is :" + temp);
    }*/
    public static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[]array1 = new int[n];
                for(int i = 0;i<n;i++)
                {
                     array1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(Add(array1));
            
    static int Add(int[] b)
            {
              int sum = 0;
              for(int i = 0;i<b.Length;i++)
              {
                sum = sum + b[i];
              }
              return sum;
            } 
            }

             
}