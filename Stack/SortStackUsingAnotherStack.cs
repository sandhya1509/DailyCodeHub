using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class SortStackUsingAnotherStack
    {
        #region Sort stack using another stack
        /*
        Problem Description

        Given a stack of integers A, sort it using another stack.

        Return the array of integers after sorting the stack using another stack.



        Problem Constraints
        1 <= |A| <= 5000

        0 <= A[i] <= 1000000000



        Input Format
        The only argument given is the integer array A.



        Output Format
        Return the array of integers after sorting the stack using another stack.



        Example Input
        Input 1:

         A = [5, 4, 3, 2, 1]
            Input 2:

         A = [5, 17, 100, 11]


            Example Output
        Output 1:

         [1, 2, 3, 4, 5]
            Output 2:

         [5, 11, 17, 100]


            Example Explanation
        Explanation 1:

         Just sort the given numbers.
        Explanation 2:

         Just sort the given numbers.*/
        #endregion
        public List<int> solve(List<int> A)
        {
            Stack<int> sort = new Stack<int>();
            Stack<int> sortMax = new Stack<int>();
            List<int> sortFinal = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (sort.Count == 0|| (sort.Peek() < A[i]))
                {
                    sort.Push(A[i]);
                }
                
                else
                {
                    if (sort.Count >= 1)



                    {

                        if (sort.Peek() > A[i])

                        {
                            if (sortMax.Count > 1 && sortMax.Peek() < A[i])
                            {
                                sortMax.Push(sort.Peek());
                                sort.Pop();
                                sort.Push(A[i]);
                            }
                            else
                            {
                                sort.Push(A[i]);
                            }

                        }
                        else
                        {
                            sort.Push(sortMax.Peek());
                            sortMax.Pop();
                        }



                    }
                       

                    
                   
                }

            }

            sortFinal.AddRange(sort);

            return sortFinal;
        }
    }
}
