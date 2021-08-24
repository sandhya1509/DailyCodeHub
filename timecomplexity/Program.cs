using System;

namespace timecomplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            num(10);
            fun(10);
        }

        public static int num(int yi)
        {
            var x=true;
            var y = yi;

            if (x)
            {
                y = y + Convert.ToInt32(x);
            }
           Console.WriteLine(y);
            return y;

        }

        public static void fun(int n)
          
        {
            // int i;
            //for (i = n; i > -1; i /= 2)
            //{
            //    Console.WriteLine(i.ToString());
            //        };

            //for (i = 1; i < n; i *= 2)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //int i, j, k = 0;
            //for (i = n / 2; i <= n; i++) //n/2--o(n)
            //{
            //    for (j = 2; j <= n; j = j * 2)//nsqrt
            //    {
            //        k = k + n / 2;
            //    }
            //}

            int countx = 0;
            int county = 0;
            for (int i = n; i > 0; i /= 2)
            {
                for (int j = 0; j < i; j++)     
                {
                    county += 1;
                }
            
                Console.WriteLine("inner loop"+ county);
               // county = 0;
                countx += 1;
                Console.WriteLine("outer loop" + county);
            }
            Console.WriteLine("x" +countx.ToString());
            Console.WriteLine("y"+county.ToString());
        }
    }
}
