using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_1319_MayIntroduction_to_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program P = new Program();
            List<int> A = new List<int>() { 51, 6, 10, 8, 22, 61, 56, 48, 88, 85, 21, 98, 81, 76, 71, 68, 18, 6, 14, 23, 72, 18, 56, 30, 97, 100, 81, 5, 99, 2, 85, 67, 46, 32, 66, 51, 76, 53, 36, 31, 81, 56, 26, 75, 69, 54, 54, 54, 83, 41, 86, 48, 7, 32, 85, 23, 47, 23, 18, 45, 79, 95, 73, 15, 55, 16, 66, 73, 13, 85, 14, 80, 39, 92, 66, 20, 22, 25, 34, 14, 51, 14, 17, 10, 100, 35, 9, 83, 31, 60, 24, 37, 69, 62 };// 5, 1, 3, 2, 2 };// 4,1-6};// 9, 6, 2, 4, 1, 2, 3, 3-10//2, 8, 3, 7, 8, 7, 9 -9
                                                                  // int sortDist=P.SortestDistance(A,9);
            A = P.wave(A);
            int uniquElmt = P.UniqueEle(A);
        }

        #region min distance
        #region Minimize Difference
        /*
        Problem Description

Given an array of integers A of size, N. Minimize the absolute difference between the maximum and minimum element of the array.

You can perform two types of operations at most B times in total to change the values in the array.
Multiple operations can be performed on the same element.

Increment : A[i] -> A[i] + 1.

Decrement : A[i] -> A[i] - 1.

Return the minimum difference possible.



Problem Constraints
1 <= N <= 105

1 <= A[i] <= 106

1 <= B <= 109



Input Format
First argument is an integer array A.
Second argument is an integer B which represents the maximum number of operations that can be performed.
Output Format
Return an integer denoting the minimum difference.
Example Input
Input 1:

 A = [2, 6, 3, 9, 8]
 B = 3
Input 2:

 A = [4, 6, 3, 1, 4]
 B = 5


Example Output
Output 1:

 5
Output 2:

 1


Example Explanation
Explanation 1:

 We can apply the atmost 3 operations in the following sequence.
 Initial array => [2, 6, 3, 9, 8].
   Decrement 9 => [2, 6, 3, 8, 8].
   Increment 2 => [3, 6, 3, 8, 8].
   Increment 3 => [3, 6, 4, 8, 8].
 Max = 8.Min = 3.
 Therefore, abs|Max - Min| = |8 - 3| = 5.
Explanation 2:

 We can apply the atmost 5 operations in the following sequence.
 Initial array => [4, 6, 3, 1, 4].
   Increment 1 => [4, 6, 3, 2, 4].
   Decrement 6 => [4, 5, 3, 2, 4].
   Increment 2 => [4, 5, 3, 3, 4].
   Decrement 5 => [4, 4, 3, 3, 4].
   Increment 3 => [4, 4, 4, 3, 4].
 Max = 4.Min = 3.
 Therefore, abs|Max - Min| = |4 - 3| = 1.
   */
        #endregion
        public int SortestDistance(List<int> Listofarry, int numOperatns)
        {
            int sortDist;
            int minCount;
            int maxCount;
            //if (Listofarry.Count > 2)
            //{
                for (int i = 0; i < numOperatns; i++)
                {
                    Listofarry.Sort();
                minCount = Listofarry.Where(temp => temp.Equals(Listofarry[0])).Select(temp => temp).Count();
                maxCount = Listofarry.Where(t => t.Equals(Listofarry[Listofarry.Count-1])).Select(t => t).Count();


                    if (Listofarry[Listofarry.Count - 1] - Listofarry[0] > 1)
                    {
                        if ((Listofarry[Listofarry.Count - 1] - Listofarry[Listofarry.Count - 2] > 0) || ((Listofarry[Listofarry.Count - 1] - Listofarry[Listofarry.Count - 2] == 0)&&minCount>(maxCount)))
                        {
                            Listofarry[Listofarry.Count - 1] = Listofarry[Listofarry.Count - 1] - 1;

                        }

                        else
                        {
                            Listofarry[0] = Listofarry[0] + 1;

                        }
                    }
                    else if ((Listofarry[Listofarry.Count - 1] - Listofarry[0] == 1) && i < numOperatns - 1)
                    {
                        return 0;

                    }
                }
           // }
            if (Listofarry.Count == 1)
                return 0;
            
            Listofarry.Sort();
            sortDist = (Listofarry[Listofarry.Count - 1]- Listofarry[0]);

            return sortDist;
        }
        #endregion

        #region Wave Array
        #region Question
        /*
        Problem Description

Given an array of integers A, sort the array into a wave like array and return it, In other words, arrange the elements into a sequence such that

a1 >= a2 <= a3 >= a4 <= a5.....
NOTE : If there are multiple answers possible, return the one that's lexicographically smallest.



Problem Constraints
1 <= len(A) <= 106
1 <= A[i] <= 106



Input Format
First argument is an integer array A.



Output Format
Return an array arranged in the sequence as described.



Example Input
Input 1:

A = [1, 2, 3, 4]
Input 2:

A = [1, 2]


Example Output
Output 1:

[2, 1, 4, 3]
Output 2:

[2, 1]


Example Explanation
Explanation 1:

One possible answer : [2, 1, 4, 3]
Another possible answer : [4, 1, 3, 2]
First answer is lexicographically smallest. So, return [2, 1, 4, 3].
Explanation 1:

Only possible answer is [2, 1].*/
        #endregion
        public List<int> wave(List<int> A)
        {
        //    List<int> wavelist = new List<int>();
        //    int counter = 0;
            A.Sort();
            //A.Sort((int a, int b) =>
            //  {

            //      if (counter == 0)
            //      {
            //           counter = 1;
            //          return b.CompareTo(a);
            //      }
                  
            //      else
            //      {
                      
            //          counter = 0;
            //          return a.CompareTo(b);
            //      }

            //  });

            for (int i = 0; i < A.Count-1; i++)

            {
                    int temp = A[i];
                    A[i ] = A[i + 1];
                    A[i + 1] = temp;
              
               i= i + 1;

            }


            return A;

        }

        #endregion

        #region Unique Element 
        #region Question
        /*Unique Elements
Problem Description

You are given an array A of N elements. You have to make all elements unique, to do so in one step you can increase any number by one.

Find the minimum number of steps.



Problem Constraints
1 <= N <= 105
1 <= A[i] <= 109



Input Format
The only argument given is an Array A, having N integers.



Output Format
Return the Minimum number of steps required to make all elements unique.



Example Input
Input 1:

 A = [1, 1, 3]
Input 2:

 A = [2, 4, 5]


Example Output
Output 1:

 1
Output 2:

 0


Example Explanation
Explanation 1:

 We can increase the value of 1st element by 1 in 1 step and will get all unique elements. i.e [2, 1, 3].
Explanation 2:

 All elements are distinct.*/
        #endregion
        public int UniqueEle(List<int> A)
        {
            int uniquestep = 0;
            A.Sort();
            for (int i = 0; i < A.Count-1; i++)
            {
                if(A[i]==A[i+1] )
                {
                    A[i + 1] = A[i + 1] + 1;
                    uniquestep++;
                }

            }

            return uniquestep;

        }
        #endregion
    }
}
