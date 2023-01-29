using System;
using System.Diagnostics.CodeAnalysis;

namespace Perfact_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a no.");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i =1;i<=a/2;i++) 
            {
                if (a % i == 0)
                {
                    sum = i + sum;

                   
                }


       
            }

            if (sum == a) 
            {
                Console.WriteLine(a+" is a perfact no.");
            }
            else
            {
                Console.WriteLine(a + " is not a perfact no.");
            }


            
        }
    }
}
