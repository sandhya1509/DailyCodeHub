using System;
using System.Collections.Generic;
namespace MoreProblemOnHashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> equal = new List<int>() { 3, 4, 7, 1, 2, 9, 8 };
            equal = Equal(equal);
        }

        /*Equal
        Problem Description
        Given an array A of N integers, find the index of values that satisfy P + Q = R + S, where P,Q,R & S are integers values in the array
        Expected time complexity O(N2)
        NOTE:

        1) Return the indices `A1 B1 C1 D1`, so that 
          A[A1] + A[B1] = A[C1] + A[D1]
          A1 < B1, C1 < D1
          A1 < C1, B1 != D1, B1 != C1 

        2) If there are more than one solutions, 

           then return the tuple of values which are lexicographical smallest. 

        Assume we have two solutions
        S1 : A1 B1 C1 D1 ( these are values of indices in the array )  
        S2 : A2 B2 C2 D2

        S1 is lexicographically smaller than S2 if:
          A1 < A2 OR
          A1 = A2 AND B1 < B2 OR
          A1 = A2 AND B1 = B2 AND C1 < C2 OR 
          A1 = A2 AND B1 = B2 AND C1 = C2 AND D1 < D2
        If no solution is possible, return an empty list.
        Problem Constraints
        1 <= N <= 1000

        0 <= A[i] <= 1000
        Input Format
        Single argument which is an integer array A of size N.
        Output Format
        Return an array of size 4 which indexes of values P,Q,R and S.

        Example Input
        Input 1:
         A = [3, 4, 7, 1, 2, 9, 8]
        Input 2:
         A = [2, 5, 1, 6]
        Example Output
        Output 1:
         [0, 2, 3, 5]
        Output 2:

         [0, 1, 2, 3]
        Example Explanation
        Explanation 1:

         A[0] + A[2] = A[3] + A[5]
         Note: indexes returned should be 0-based.
        Explanation 2:

         A[0] + A[1] = A[2] + A[3]*/
        public static List<int> Equal(List<int> A)
        {
           
          
            Dictionary<int, List<int>> D = new Dictionary<int, List<int>>();
            for (int i=0;i<A.Count;i++)
            {
                for (int j = i+1; j < A.Count; j++)
                {
                    List<int> li = new List<int>();
                    int sum = A[i] + A[j];
                    li.Add(i);
                    li.Add(j);
                    if (D.ContainsKey(sum))
                    {
                        if (D.ContainsValue(li))
                        {
                            
                            D[sum].AddRange(li);
                        }
                        else
                        { D[sum].AddRange(li); }
                    }

                    else
                        D.Add(sum, li);
                }
                
            }
            foreach (var item in D)
            {
                if (item.Value.Count < 4)
                {
                    D.Remove(item.Key);

                }
                else if ((item.Value.Count > 4))
                {
                    item.Value.Sort();
                    item.Value.RemoveRange(4, item.Value.Count -4 );
                }
                else
                { 
                    item.Value.Sort();
            }
                
                A.AddRange(item.Value);

              

            }
            


            

            return A;
        }
    }
}
