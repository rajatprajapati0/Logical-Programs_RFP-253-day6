using System;
using System.Diagnostics;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Stopwatch a = new Stopwatch();
          


            a.Start();

            for (int i= 0;i<10;i++)
             {
                
                Console.Write("");
             }
           
              a.Stop();
            Console.WriteLine(a.Elapsed);


            

        }
    }
}
