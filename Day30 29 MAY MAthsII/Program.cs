using System;

namespace Day30_29_MAY_MAthsII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int Gcd = gcd(350, 136);
        }
        #region Greatest Common Divisor
        /*Greatest Common Divisor
Problem Description

Given 2 non negative integers A and B, find gcd(A, B)

GCD of 2 integers A and B is defined as the greatest integer g such that g is a divisor of both A and B. Both A and B fit in a 32 bit signed integer.

Note: DO NOT USE LIBRARY FUNCTIONS.



Problem Constraints
0 <= A, B <= 109



Input Format
First argument is an integer A.
Second argument is an integer B.



Output Format
Return an integer denoting the gcd(A, B).



Example Input
Input 1:

A = 4
B = 6
Input 2:

A = 6
B = 7


Example Output
Output 1:

 2
Output 2:

 1


Example Explanation
Explanation 1:

 2 divides both 4 and 6
Explanation 2:

 1 divides both 6 and 7*/
        #endregion

        public static int gcd(int A, int B)
        {
            int _gcd = 1;
            int min = Math.Min(A, B);
            int max = Math.Max(A, B);
            int mod = max % min;
            if (min == 0)
                return Math.Max(A, B);
            #region correct but not optimal
            /*
            for (int i = min; i > 0; i--)
            {
                if ((A % i == 0) && (B % i == 0))
                {
                    _gcd = i;
                    return i;
                }
            }*/
            #endregion

            while (mod != 0)
            {
                _gcd = gcdcalc(min, mod);
                mod = min % mod;
            }
            if (B == 0)
                return Math.Max(A, B);
            if (mod == 1)
                return _gcd;
            return _gcd;
        }
        public static int gcdcalc(int A, int B)
        {
            int _gcd = 1;
            
            if ((A % B == 0) )
                {
                    _gcd = A / B;
                 
                }

            return _gcd;
        }
    }
}