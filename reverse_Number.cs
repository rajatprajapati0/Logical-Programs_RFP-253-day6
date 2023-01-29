using System;

namespace Reverse_a_Number
{
    internal class reverse_Number
    {
        static void Main(string[] args)
        {
            int revers= 0;
            int rem;
            int num = int.Parse(Console.ReadLine());
            while (num != 0)                        
            {                                       
                rem = num % 10;                       

                revers = revers * 10 + rem;        
                num = num / 10;                    
                    }
            Console.WriteLine(revers);              

            Console.WriteLine("Hello World!");
        }
    }
}
