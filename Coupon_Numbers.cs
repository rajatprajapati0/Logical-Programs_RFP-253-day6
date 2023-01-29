using System;


namespace Rendom_Coupon
{
    internal class Coupon_Numbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter quntity how many coupons u want  ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                int d = Intrange(500, 1000);
                char c = bigchar();
                string e = strRand();


                Console.WriteLine(d + "" + c + "" + e);
            }
        }
   
 
    
       static char bigchar() 
        {
          Random rnd = new Random();
            int a = rnd.Next(0,26);
          char e = (char)('a'+ a);
        return e;
        }
        static int Intrange(int i,int j) 
        {
            int a = i;
            int b = j;
            Random rnd = new Random();
            int c = rnd.Next(a,b);
            return c;
        }
        static string strRand() 
        {
            Random rnd=new Random();
            
            int  a = rnd.Next(1,5);

            string str = "";
            char letter;
            for (int i = 0; i < a; i++)
            {
                int randv = rnd.Next(0, 26);
                letter=Convert.ToChar(randv+65);
                str = str + letter;
            }
            return str;
        }



    
    }
}
