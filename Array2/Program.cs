using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;

            Console.WriteLine("Even numbers from 0 to 100 are: ");
    
            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");

                    add += i;  
                }
            }
            Console.Write("The sum of all the even number is {0}",add );
            
 
        }
    }
}
