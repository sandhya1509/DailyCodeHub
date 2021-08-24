using System;
using System.Collections.Generic;
using System.Linq;
namespace ProblemsonArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> L = new List<int>() { 834, 563, 606, 221, 165 };// 613, 116, 420, 672, 426 };

            List<List<int>> PP;
             PP = PatternPrint(3);
            int Ll = lengthofLongeshones("010100110101");

            //int h = ClosestMinMax(L);

            //int y = solve("GUGPUAGAFQBMPYAGGAAOALAELGGGAOGLGEGZ");//ABCGAG//GAB
        }
        /*Input Format
        First and only argument is a string A.
        Output Format
        Return an integer denoting the answer.
        Example Input
                    Input 1:
                    A = "ABCGAG"
                    Input 2:
                    A = "GAB"
        Example Output
                    Output 1:
                     3
                    Output 2:
                     0

        Example Explanation
        Explanation 1:
         Subsequence "AG" is 3 times in given string 
        Explanation 2:
         There is no subsequence "AG" in the given string.
        {
        var i = A.count-1, g = 0, a = 0
        let B = Array(A)
        while i > -1 {
            let v = String(B[i])
            if v == "g" || v == "G" { // MISTAKE g & G
                g+=1
            }
            else if v == "a" || v == "A" {
                a+=g // MISTAKE combine all g's. Not number of g
            }
            i-=1
        }
        return a
    }
         */
        public static int solve(string A)
        {
            int j = 0;
            int ans = 0;
            char[] B = new char[A.Length];
            B = A.ToCharArray();

            for (int i = B.Length - 1; i >= 0; i--)
            {
                if (B[i] == 'G')
                    j++;
                if (B[i] == 'A')
                    ans += j;// + ans;               

            }

            return ans;
        }
        /*Closest MinMax
Problem Description
Given an array A. Find the size of the smallest subarray such that it contains atleast one occurrence of the maximum value of the array
and atleast one occurrence of the minimum value of the array.
Problem Constraints
1 <= |A| <= 2000
Input Format
First and only argument is vector A
Output Format
Return the length of the smallest subarray which has atleast one occurrence of minimum and maximum element of the array
        Example Input
        Input 1:

        A = [1, 3]
        Input 2:

        A = [2]


Example Output
Output 1:

 2
Output 2:

 1


Example Explanation
Explanation 1:

 Only choice is to take both elements.
Explanation 2:

 Take the whole array.*/
        public static int ClosestMinMax(List<int> A)
        {
            int min = A.Min();
            int max = A.Max();
            int minIndx = -1;
            int maxIndecx = -1;
            int size = A.Count;

            for (int i = A.Count - 1; i >= 0; i--)
            {
                if (A[i] == min)
                {
                    minIndx = i;
                }
                if (A[i] == max)
                {
                    maxIndecx = i;
                }
                //size = (size > Math.Abs(minIndx - maxIndecx)) ? minIndx - maxIndecx : size;
                if (minIndx != -1 && maxIndecx != -1)
                    size = Math.Min(size, Math.Abs(minIndx - maxIndecx) + 1);
            }


            return size;

        }
        /*Pattern Printing -2
        Problem Description

        Print a Pattern According to The Given Value of A.

        Example: For A = 3 pattern looks like:

            1
          2 1
        3 2 1


        Problem Constraints
        1 <= A <= 1000


        Input Format
        First and only argument is an integer denoting A.
        Output Format
        Return a two-dimensional array where each row in the returned array represents a row in the pattern.
        Example Input
        Input 1:

         A = 3
        Input 2:

         A = 4
        Example Output
        Output :1

         [ 
           [0, 0, 1]
           [0, 2, 1]
           [3, 2, 1]
         ]
        Output 2:

         [ 
           [0, 0, 0, 1]
           [0, 0, 2, 1]
           [0, 3, 2, 1]
           [4, 3, 2, 1]
         ]
        Example Explanation
        Explanation 2: 
         For A = 4 pattern looks like:  
                                           1
                                         2 1
                                       3 2 1
                                     4 3 2 1
         So we will return it as two-dimensional array. 
         Row 1 contains 3 spaces and 1 integer so spaces will be considered as 0 in the output.*/
        public static List<List<int>> PatternPrint(int A)
        {
            //   int y;
            // int[,] pp=new int[A,A];
            //   y = A - 1;
            //   for (int k =1; k <= i+1; k++)
            //   {
            //       pp[i, y]=k;
            //       P.Insert(i, k);
            //    y--;
            //}


            List<List<int>> PP = new List<List<int>>();
            for (int i = 1; i <= A; i++)
            {
                List<int> P = new List<int>(A);

                for (int j = A; j >= 1; j--)
                {
                    if (j <= i)
                        P.Add(j);
                    else
                        P.Add(0);
                }

                PP.Add(P);
            }

            return PP;
        }

        public static int lengthofLongeshones(string A)//010100110101
        {
            int i = 0;
            List<char> LL = new List<char>();
            for (int p = 0; p < A.Length; p++)
            {
                if (p != A.Length)
                    LL.Insert(p, A[p]);
            };
            LL.Insert(A.Length, '0');
            LL.Insert(0, '0');


            List<int> LI = new List<int>();
            List<int> IR = new List<int>();
            /*Create list index left and right*/
            for (int li = 0; li < LL.Count; li++)
            {
                if (LL[li] == '0')
                {
                    i = 0;
                    LI.Insert(li, 0);
                }
                else
                {
                    LI.Insert(li, i + 1);
                    i++;
                }
            }
            i = LI.Count - 1;
            for (int li = 0; li < LI.Count; li++)
            {
                IR.Insert(li, LI[i]);
                i--;
            }
            int index = 0;
            /*compare all*/
            for (int li = 1; li < LL.Count - 1; li++)
            {
                if (LL[li] == '1')
                {
                    i = LI[li] + IR[li] - 1;
                }
                else
                {

                    i = LI[li - 1] + IR[li + 1] + 1;
                }

                //i=Math.Max()

                index = Math.Max(index, i);
            }


            return index;

        }
    }
}
