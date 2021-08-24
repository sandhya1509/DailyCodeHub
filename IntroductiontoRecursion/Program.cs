using System;
using System.Collections.Generic;

namespace IntroductiontoRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = sumofdigits(456);
            i = findAthFibonacci(0);
            i = findAthFibonacci1(9);
            i = Check_Palindrome("NAmcAN");


        }

        public static int sumofdigits(int A)
        {
         if(A!=0)
            { return (A % 10 + sumofdigits(A / 10)); }
           else
            return 0;
        }


        public static int findAthFibonacci(int A)//use recurssion
        {
            int fib = 0;
            Dictionary<int, int> fibdict = new Dictionary<int, int>();
            for(int i = 0; i <= A; i++) {
                fibdict[i] = i;
                if (i > 1)
                    fibdict[i] = fibdict[i-1] + fibdict[i-2];

                  }
            if (A > 1)
                fib = fibdict[A - 1] + fibdict[A - 2];
            else
                fib = fibdict[A];
            return fib;
        }
        public static int findAthFibonacci1(int A)
        {
            return fib(A);
        }
        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }

        /************************************************************************************************/
        public static int Check_Palindrome(string A)
        {
            int i = 0;
            
            List<char> charA = new List<char>();
            charA.AddRange(A);
            int lindex = charA.Count-1;
            for (int index=0;index<charA.Count;index++)
            {
                i = Check_Palindromefun(charA[index], charA[lindex]);
                if (i == 0)
                    return i;
                lindex--;
            }

            return i;

        }

        private static int Check_Palindromefun(char v1, char v2)
        {
            if (v1 == v2)
                return 1;
            else
                return 0;
        }
    }
}
