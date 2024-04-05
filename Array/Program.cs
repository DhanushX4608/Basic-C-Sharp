using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        string [] names = new string[5]{"Ramu","Somu","Chan","Cho","Gokul"};
        for (int i = 0; i< names.Length;i++)
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            if (names[i] == name)
            {
                Console.WriteLine("Enter the name is present");
            }

            else
            {
                Console.WriteLine("Enter the name is not present");
            }

        }

    }
}