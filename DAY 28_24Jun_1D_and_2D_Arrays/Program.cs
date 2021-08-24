using System;
using System.Collections.Generic;
namespace DAY_28_24Jun_1D_and_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> A = new List<int>() { -123, -6 };// 56, -451, -222, 80, -57, -85, -304, -108, 95, -377, -282, -260, -497, -471, -97, -350, -147, 62, -447, -229, 78, -165, -333, -427, -59, -338, 60, -207, -247, -431, -54, -240, -426, -123, -209, 57, -74, -287, -70, -292, 45, -278, -408, -129, -35, 65, -77, -230, -426, 20, -402, -375, -449, -280, -125, -15, -21, -327, -366, 64, -211, -414, -307 };// - 2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxsubarry = maxSubArray(A);

        }
        #region Max Sum Contiguous Subarray
        /*    Problem Description

            Find the contiguous subarray within an array, A of length N which has the largest sum.

            Problem Constraints
            1 <= N <= 1e6
            -1000 <= A[i] <= 1000
            Input Format
            The first and the only argument contains an integer array, A.

            Output Format
            Return an integer representing the maximum possible sum of the contiguous subarray.

            Example Input
            Input 1:

             A = [1, 2, 3, 4, -10]
            Input 2:

             A = [-2, 1, -3, 4, -1, 2, 1, -5, 4]


            Example Output
            Output 1:

             10 
            Output 2:

             6 


            Example Explanation
            Explanation 1:

             The subarray [1, 2, 3, 4] has the maximum possible sum of 10. 
            Explanation 2:

             The subarray [4,-1,2,1] has the maximum possible sum of 6. 
        */
        #endregion
        public static int maxSubArray(List<int> A)
        {
            int max= int.MinValue;
            int innersum = 0;

             if (A.Count == 1)
            {
                max = A[0];
            }

            else if (A.Count == 2 && (A[0] < 0 && A[1] < 0))
            {
                max = Math.Max(A[0], A[1]);
            }
            
            else
            {
                for (int len = 0; len < A.Count; len++)
                {
                    innersum = A[len];
                    for (int innerlen = len + 1; innerlen < A.Count; innerlen++)
                    {
                        #region scalar
                           /*class Solution {
                            public int maxSubArray(List<int> A) {
                                int n = A.Count;
                                int max = int.MinValue;
                                int curr = 0;
                                for(int i = 0; i < n; i++)
                                {
                                    curr = curr + A[i];
                                    max = Math.Max(curr, max);
                                    curr = Math.Max(curr, 0);
                                }
                                return max;
                            }
                        }*/
                        #endregion
                        innersum = innersum + A[innerlen];
                        max = Math.Max(max, innersum);
                        innersum = Math.Max(innersum, 0);
                    }


                }
            }
            return max;
        }
    }
}
