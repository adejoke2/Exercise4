using System;

namespace Loos2
{
    class Program
    {
        static void Main(string[] args)
        {

		 Console.Write("Enter the first string: ");
		 string FirstInput = (Console.ReadLine());

		 Console.Write("Enter the second string: ");
		 string SecondInput = (Console.ReadLine());

         SecondInput.ToLower();

         int Indexbreak = 0;

		 string prefix = "";	

         string lowestString = FirstInput.Length < SecondInput.Length ? FirstInput : SecondInput;

		for (int i = 0; i < lowestString.Length; i++)
        {
            if (FirstInput[i] == SecondInput[i])
            {
               prefix += FirstInput[i];
            }
            else 
            {
                break;
                
            }

		}
            Console.WriteLine(SecondInput.Substring(0, Indexbreak) );

            Console.WriteLine($"The commmon prefix of {FirstInput} and  {SecondInput} is " + prefix);


           
        }
    }
}
