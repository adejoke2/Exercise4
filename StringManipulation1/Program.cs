using System;

namespace StringManipulation1
{
    class Program
    {
        static void Main(string[] args)
        {
         string str;

         Console.Write("Enter the string : ");
		 str = Console.ReadLine();

		 int j = 0;

		 char temp = '0';

		 char[] chars = str.ToCharArray();

		 for (int i = 0; i < chars.Length; i++)
		 {
			for (j = 0; j < chars.Length; j++) 
			{
				if (chars[j] > chars[i]) 
				{
					temp = chars[i];
					chars[i] = chars[j];
					chars[j] = temp;
				}
			}
		}
			Console.WriteLine("The sorted string is : ");

			for (int i = 0; i < chars.Length; i++) 
			{
			 Console.WriteLine(chars[i]);
			}
        }
    }
}
