using System;

namespace Fibonacci_Series
{
    internal class fibonacci_Series
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;

            for (int i = 0; i<20;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1=n2;
                n2=n3;

            }
           
        }
    }
}
