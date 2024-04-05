using System;
namespace SwitchCase;
class Program 
{
    /*public static void Main(string[] args)
    {
        Console.WriteLine("Enter Num1: ");
        double Num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Num2: ");
        double Num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Symbol: ");
        char Symbol = char.Parse(Console.ReadLine());
        switch(Symbol)
        {
            case '+':
            {
                Console.WriteLine(Num1 + Num2);
                break;
            }

            case '-':
            {
                Console.WriteLine(Num1 - Num2);
                break;
            }

            case '*':
            {
                Console.WriteLine(Num1 * Num2);
                break;
            }

            case '/':
            {
                Console.WriteLine(Num1 / Num2);
                break;
            }

            case '%':
            {
                Console.WriteLine(Num1 % Num2);
                break;
            }

            default:
            {
                Console.WriteLine("Invalid Operation");
                break;
            }

        }
    }*/
    static int Add(int[] b)
            {
              int sum = 0;
              for(int i = 0;i<b.Length;i++)
              {
                sum = sum + b[i];
              }
              return sum;
            } 

             public static void main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[]array1 = new int[n];
                for(int i = 0;i<n;i++)
                {
                     array1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(Add(array1));
            }
}