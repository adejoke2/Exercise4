using System;

namespace StringManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the first string : ");
            string string1 = Console.ReadLine();
            
            Console.Write("Enter the second  string : ");
            string string2 = Console.ReadLine();
            
            if (string1.IndexOf(string2) != -1) 
            {
                Console.WriteLine($"{string1} is a substring of {string2}");
            }
            else
            {
                Console.WriteLine($"{string1} is not a substring of {string2}");
            }
        }               

    }
}
