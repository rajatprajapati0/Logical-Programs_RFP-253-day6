using System;

namespace Prime_Number
{
    internal class Prime_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no.and find it is a prime no. or not");

            int a = int.Parse(Console.ReadLine());
            bool check = false;


            for (int i = 2; i <= a / 2; i++) // a/2 used for fast execution of prgram 
                                             
                                             
            {
                if (a % i == 0)
                {
                    check = true;
                    break;

                }
            }
                if (check == true)
                {
                    Console.WriteLine(a + " is not prime number ");
                }
                else 
                {
                    Console.WriteLine(a + " is  prime number ");


                }
            

        }

    }
}
