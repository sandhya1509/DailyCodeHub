using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    class Program
    {
        static int o;
        static int h;
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World!");
            List<int> i = new List<int>() { 0, 1, 3, 3, 4, 5, 7, 7, 8, 9 };
            List<int> A = new List<int>() { 4, 4, 4, 4 };//97, 43, 29, 11, 100, 47, 76, 83, 37, 19, 17, 19, 71, 0, 1, -82, 2, -83, 37, 13, 5, 97, 17, 30, 31, 48, 2, 19, 31, 91, 19, 2, 5, 89, 2, 67, 31, 47, 43, 31, 5, 17, 83, 11, 47, 73, 19, 3, 3, 19, 59, 91, 67, 7, 43, 4, 3, 51, 52, 23, 3, 37, 53, 89, 9, 41, 19, 61, 7, 5, 53, 59, 19, 11, 79, 37, 31, 37, 73, 82, 41, 2, 13, 8, 2, 36, 19, 58, 17, 17, 59, 59, 37, 11, 13, 37, 47, 83, 31, 3 };

            List<int> A1 = new List<int> { 1, 2, 3, 4, 5 };
            // int j=GoodPair(A1,3); ;
            List<int> B = new List<int> { 2, 3 };
            //List<List<int>> rotatearry = Rotatearray(A1, B);

            // int prime = primalPower(A);            //A = solve(A);//1, 2, 3, 4, 5//5, 17, 100, 11
            //int y=   searchNumOccurrence(i,7,0,i.Count-1);
            //fizzBuzz(15);
            //oddenenlistsubarray(A);
            int t = TimeToEquality(A);
        }

        /*Odd Even Subsequences
Given an array of integers A of size N. Find the longest subsequence of A which is odd-even.

A subsequence is said to odd-even in the following cases:

The first element of the subsequence is odd, second element is even, third element is odd and so on. For example: [5, 10, 5, 2, 1, 4], [1, 2, 3, 4, 5]

The first element of the subsequence is even, second element is odd, third element is even and so on. For example: [10, 5, 2, 1, 4, 7], [10, 1, 2, 3, 4]

Return the maximum possible length of odd-even subsequence.

Note: An array B is a subsequence of an array A if B can be obtained from A by deletion of several (possibly, zero or all) elements.


Input Format

The only argument given is the integer array A.
Output Format

Return the maximum possible length of odd-even subsequence.
Constraints

1 <= N <= 100000
1 <= A[i] <= 10^9 
For Example

Input 1:
    A = [1, 2, 2, 5, 6]
Output 1:
    4
    Explanation 1:
        Maximum length odd even subsequence is [1, 2, 5, 6]

Input 2:
    A = [2, 2, 2, 2, 2, 2]
Output 2:
    1
    Explanation 2:
        Maximum length odd even subsequence is [2]*/
        #region scalar answer
        /*
     class Solution :
        # @param A : list of integers
        # @return an integer
            def solve(self, A):
        
                n=len(A)
                ans1, ans2 = 0, 0
                x, y = 1, 0
        
                for it in A:
                    it=(it&1)
                    if(it==x):
                        ans1+=1
                        x^=1
                
                    if(it==y):
                        y^=1;
                        ans2+=1
        
                return max(ans1, ans2)*/
        #endregion
        public static int oddenenlistsubarray(List<int> A)
        {
            int n = A.Count();
            int ans1 = 0, ans2 = 0;
            int x = 1, y = 0;


            foreach (int k in A)
            {
                int it;
                it = (k & 1);
                if (it == x)
                {
                    ans1 += 1;
                    x ^= 1;
                }
                if (it == y)
                {
                    y ^= 1;
                    ans2 += 1;
                }
            }

            return Math.Max(ans1, ans2);
        }
        public static int oddenenlistsubarray1(List<int> A)
        {
            List<int> B = new List<int>();
            // int count = 1;
            bool odd = Convert.ToBoolean((A[0] & 1));
            // int j;


            for (int i = 0; i < A.Count; i++)
            {
                if ((A[i] & 1) == 0 && odd == false)
                {
                    B.Add(A[i]);
                    odd = true;
                }
                else if (odd == true)
                {
                    B.Add(A[i]);
                    odd = false;

                }
            }
            return B.Count();

            /* if (i == A.Count - 1)
                 j = A.Count - 1;
             else j = i + 1;
             if (odd == 1)
                 if (i < A.Count)
                 {
                     if ((A[i] == A[j]))
                     {
                         count = count + 0;
                         B.Add(A[i]);
                         Console.WriteLine(A[i].ToString() + "is equal");
                     }


                     if ((A[i] & 1) == 1 && ((A[j]) & 1) == 0)
                     {
                         count = count + 2;
                         B.Add(A[i]);
                         B.Add(A[j]);
                         Console.WriteLine(A[i].ToString() + "is oddeven"); ;
                     }

                     else
                     {
                         //count = 0;
                         Console.WriteLine(A[i].ToString() + "is out");
                         break;
                     }
                 }
                 else
                        if (i < A.Count)
                 {
                     if ((A[i] == A[j]))
                     {
                         count = count + 0;
                         Console.WriteLine(A[i].ToString() + "is equal");
                     }


                     if ((A[i] & 1) == 0 && ((A[j]) & 1) == 1)
                     {
                         count = count + 2;
                         B.Add(A[i]);
                         B.Add(A[j]);
                         Console.WriteLine(A[i].ToString() + "is evenodd"); ;
                     }

                     else
                     {
                         //count = 0;
                         Console.WriteLine(A[i].ToString() + "is out");
                         break;
                     }
                 }


         }

         return count - 1;*/
        }


        public static List<string> fizzBuzz(int A)
        {
            List<string> arr = new List<string>();

            for (int i = 1; i <= A; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    arr.Add("FizzBuzz");
                else if (i % 3 == 0)
                    arr.Add("Fizz");
                else if (i % 5 == 0)
                    arr.Add("Buzz");
                else
                    arr.Add(i.ToString());


            }

            return arr;

        }

        public static int searchNumOccurrence(List<int> V, int k, int start, int end)// 0, 1, 3  ,3, 4, 5, 7, 7, 8 ,9
        {

            if (start > end) return 0;
            int mid = (start + end) / 2;
            Console.WriteLine("k=" + k + "mid=" + mid + "strat " + start + "end " + end);
            if (V[mid] < k) return searchNumOccurrence(V, k, mid + 1, end);
            else if (V[mid] > k) return searchNumOccurrence(V, k, start, mid - 1);

            else
            {
                o = searchNumOccurrence(V, k, start, mid - 1) + 1;
                h = searchNumOccurrence(V, k, mid + 1, end);
                Console.WriteLine(mid);
                return o + h;
            }

            // return searchNumOccurrence(V, k, start, mid - 1) + 1 + searchNumOccurrence(V, k, mid + 1, end);
        }

        public static List<int> solve(List<int> A)
        {
            /*Multiplication of previous and next
            Given an array of integers A, update every element with multiplication of previous and next elements with following exceptions. a) First element is replaced by multiplication of first and second. b) Last element is replaced by multiplication of last and second last.


            Input Format

            The only argument given is the integer array A.
            Output Format

            Return the updated array.
            Constraints

            1 <= length of the array <= 100000
            -10^4 <= A[i] <= 10^4 
            For Example

            Input 1:
                A = [1, 2, 3, 4, 5]
            Output 1:
                [2, 3, 8, 15, 20]

            Input 2:
                A = [5, 17, 100, 11]
            Output 2:
                [85, 500, 187, 1100]*/
            List<int> B = new List<int>();
            if (A.Count == 1)
                return A;//DID NOT CONSIDER SINGLE ARRAY
            for (int i = 0; i < A.Count; i++)  //mistake count id count-1
            {

                if (i == 0)
                    B.Insert(i, A[i] * A[i + 1]);
                else if (i == A.Count - 1)
                    B.Insert(i, A[i] * A[i - 1]);
                else
                    B.Insert(i, A[i - 1] * A[i + 1]);


            }
            return B;
        }

        public static int primalPower(List<int> A)
        {

            int prime = 0;
            foreach (int i in A)
            {
                if (i > 0)
                    if (primenum(i))
                        prime++;
            }
            return prime;
        }

        private static bool primenum(int n)
        {
            for (int i = 2; i < Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0)
                {
                    return false;

                }

            }
            return true;

        }
        #region rotation
        /*
        Multiple left rotations of the array
Given an array of integers A and multiple values in B which represents the indices of the array A around which left rotation of the array A needs to be performed.

Find the rotated array for each value and return the result in the from of a matrix where i'th row represents the rotated array for the i'th value in B.


Input Format

The first argument given is the integer array A.
The second argument given is the integer array B.
Output Format

Return the resultant matrix.
Constraints

1 <= length of both arrays <= 2000
-10^9 <= A[i] <= 10^9 
0 <= B[i] <= 2000
For Example

Input 1:
    A = [1, 2, 3, 4, 5]
    B = [2, 3]
Output 1:
    [ [3, 4, 5, 1, 2]
      [4, 5, 1, 2, 3] ]

Input 2:
    A = [5, 17, 100, 11]
        B = [1]
        Output 2:
    [ [17, 100, 11, 5] ]*/
        #endregion

        public static List<List<int>> Rotatearray(List<int> A, List<int> B)
        {
            List<List<int>> rotatedarr = new List<List<int>>();
            foreach (int i in B)
            {
                int countrot = i % A.Count;
                List<int> listrotlist = new List<int>();
                List<int> temparr = new List<int>();

                listrotlist.AddRange(A);
                temparr.AddRange(A.GetRange(0, countrot));
                listrotlist.RemoveRange(0, countrot);
                listrotlist.InsertRange(listrotlist.Count, temparr);
                rotatedarr.Add(listrotlist);
            }






            return rotatedarr;
        }
        #region Good pair
        /*Good Pair
        Problem Description

        Given an array A and a integer B. A pair(i,j) in the array is a good pair if i!=j and (A[i]+A[j]==B). Check if any good pair exist or not.

        Problem Constraints
        1 <= A.size() <= 104
        1 <= A[i] <= 109
        1 <= B <= 109

        Input Format
        First argument is an integer array A.
        Second argument is an integer B.
        Output Format
        Return 1 if good pair exist otherwise return 0.
        Example Input
        Input 1:
        A = [1,2,3,4]
        B = 7
        Input 2:
        A = [1,2,4]
        B = 4
        Input 3:
        A = [1,2,2]
        B = 4


        Example Output
        Output 1:
        1
        Output 2:
        0
        Output 3:
        1


        Example Explanation
        Explanation 1:

         (i,j) = (3,4)
        Explanation 2:

        No pair has sum eqaual to 4.
        Explanation 3:

         (i,j) = (2,3)*/
        #endregion

        public static int GoodPair(List<int> A, int B)
        {
            int goodPair = 0;
            A.Sort();

            List<int> Acopy = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if ((A[i] < B) && (i != j) && (A[i] + A[j] == B))//((A[i] < B) && (A[i] != A[j]) && (A[i] + A[j] == B) read the question properly (index should not be same)
                    {
                        goodPair = 1;
                        return goodPair;
                    }

                }
            }

            return goodPair;
        }

        #region time to equal
        /*Time to equality
        Problem Description
        Given an integer array A of size N. In one second you can increase the value of one element by 1.
        Find the minimum time in seconds to make all elements of the array equal.
        Problem Constraints
        1 <= N <= 1000000
        1 <= A[i] <= 1000
        Input Format
        First argument is an integer array A.
        Output Format
        Return an integer denoting the minimum time to make all elements equal.
        Example Input
        A = [2, 4, 1, 3, 2]
        Example Output
        8
        Example Explanation
        We can change the array A = [4, 4, 4, 4, 4]. The time required will be 8 seconds.*/
        #endregion

        public static int TimeToEquality(List<int> A)
        {
            int count = 0;
            A.Sort();
            int max = A[A.Count - 1];
            for (int i = 0; i < A.Count - 1; i++)
            {
                count += max - A[i];

            }

            return count;
        }


    } 

}
