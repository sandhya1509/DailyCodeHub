using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Maximum_Frequency_stack
    {
        #region Maximum Frequency stack
        /*
         Maximum Frequency stack
        Problem Description

        You are given a matrix A which represent operations of size N x 2. Assume initially you have a stack-like data structure you have to perform operations on it.

        Operations are of two types:

        1 x: push an integer x onto the stack and return -1

        2 0: remove and return the most frequent element in the stack.

        If there is a tie for the most frequent element, the element closest to the top of the stack is removed and returned.

        A[i][0] describes the type of operation to be performed. A[i][1] describe the element x or 0 corresponding to the operation performed.



        Problem Constraints
        1 <= N <= 100000

        1 <= A[i][0] <= 2

        0 <= A[i][1] <= 109



        Input Format
        The only argument given is the integer array A.



        Output Format
        Return the array of integers denoting answer to each operation.



        Example Input
        Input 1:

        A = [
                    [1, 5]
                    [1, 7]
                    [1, 5]
                    [1, 7]
                    [1, 4]
                    [1, 5]
                    [2, 0]
                    [2, 0]
                    [2, 0]
                    [2, 0]  ]
        Input 2:

         A =  [   
                [1, 5]
                [2 0]
                [1 4]   ]


        Example Output
        Output 1:

         [-1, -1, -1, -1, -1, -1, 5, 7, 5, 4]
        Output 2:

         [-1, 5, -1]


        Example Explanation
        Explanation 1:

         Just simulate given operations
        Explanation 2:

         Just simulate given operations
         
         */
        #endregion

        public List<int> solve(List<List<int>> A)
        {
            List<int> ot = new List<int>();
            Dictionary<int, int> output = new Dictionary<int, int>();
            Stack<int> freq = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {

                if (A[i][0] == 1)
                {
                    freq.Push(-1);

                    if(output.ContainsKey(A[i][1])  )
                        { output[A[i][1]] = output[A[i][1]] + 1; }
                    else { output.Add(A[i][1], 1); }
        }                
                    if(A[i][0]==2)
                    {
                   // output.OrderByDescending(key => key.Value);
                    int maxval = output.Values.Max();
                    int key = output.FirstOrDefault(t=>t.Value==maxval).Key;
                   
                    freq.Push(key);
                    output[key] = output[key] - 1;

                }

                
            }

            return ot;
        }
    }
}
