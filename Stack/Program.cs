using System;
using System.Collections.Generic;



namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region stack dsigncall
            /*
            Stack myStack = new Stack();//19 P 10 P 9 g P 8 g P 7 g P 6 g p g p g p g p g p g
             myStack.push(19);
             Console.WriteLine("My top is {0}", myStack.top());
             myStack.push(10);
             Console.WriteLine("My top is {0}", myStack.top());
             myStack.push(9);
             Console.WriteLine("My top is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min {0}", myStack.getMin());
             myStack.push(8);
             Console.WriteLine("My top is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.push(7);
             Console.WriteLine("My top is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.push(6);
             Console.WriteLine("My top is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.pop();
             Console.WriteLine("My min is min is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.pop();
             Console.WriteLine("My min is min is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.pop();
             Console.WriteLine("My min is min is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.pop();
             Console.WriteLine("My min is min is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.pop();
             Console.WriteLine("My min is min is {0}", myStack.top());
             myStack.getMin();
             Console.WriteLine("My min is min is {0}", myStack.getMin());
             myStack.top();
             Console.WriteLine("My top is{0}", myStack.top());
             Console.ReadLine();
            */
            #endregion
         //   passongGame game = new passongGame();
            List<int> A = new List<int> { 86, 63, 60, 0, 47, 0, 99, 9, 0, 0 };
           // int i=game.solve(10,23,A);

           SortStackUsingAnotherStack s = new SortStackUsingAnotherStack();
           A = s.solve(A);
           // Stack s1 = new Stack();

            Maximum_Frequency_stack feq = new Maximum_Frequency_stack();
            List<List<int>> feqlst = new List<List<int>> 
            {new List<int>() {1, 5},
             new List<int>() {1, 7},
             new List<int>() {1, 5},
             new List<int>() {1, 7},
             new List<int>() {1, 4},
             new List<int>() {1, 5},
             new List<int>() {2, 0},
             new List<int>() {2, 0},
             new List<int>() {2, 0},
             new List<int>() {2, 0},
 };
           
            A=feq.solve(feqlst);

        }
       

        #region MIn
        /*Min Stack
         * 19 P 10 P 9 g P 8 g P 7 g P 6 g p g p g p g p g p g
Problem Description

Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.
NOTE:

All the operations have to be constant time operations.
getMin() should return -1 if the stack is empty.
pop() should return nothing if the stack is empty.
top() should return -1 if the stack is empty.


Problem Constraints
1 <= Number of Function calls <= 107



Input Format
Functions will be called by the checker code automatically.



Output Format
Each function should return the values as defined by the problem statement.



Example Input
Input 1:

push(1)
push(2)
push(-2)
getMin()
pop()
getMin()
top()
Input 2:

getMin()
pop()
top()


Example Output
Output 1:

 -2 1 2
Output 2:

 -1 -1


Example Explanation
Explanation 1:

Let the initial stack be : []
1) push(1) : [1]
2) push(2) : [1, 2]
3) push(-2) : [1, 2, -2]
4) getMin() : Returns -2 as the minimum element in the stack is -2.
5) pop() : Return -2 as -2 is the topmost element in the stack.
6) getMin() : Returns 1 as the minimum element in stack is 1.
7) top() : Return 2 as 2 is the topmost element in the stack.
Explanation 2:

Let the initial stack be : []
1) getMin() : Returns -1 as the stack is empty.
2) pop() :  Returns nothing as the stack is empty.
3) top() : Returns -1 as the stack is empty.*/
        #endregion
        #region test pass
        /*using System;
 using System.Collections.Generic;
 public class Solution
    {
      
        List<int> myStack;
        List<int> minStack;
        public int Ntop;
       public Solution()
        {
            myStack = new List<int>();
            minStack = new List<int>();
            Ntop = -1;
        }


        public void push(int x)
        {
            ++Ntop;
            myStack.Add( x);
            minStack.Add( (Ntop == 0 ? x: Math.Min(minStack[Ntop-1], x)));

        }   

        public void pop()
        {
            if (Ntop == -1)
                return;
            
            myStack.RemoveAt(Ntop);
            minStack.RemoveAt(Ntop);
            Ntop--;

        }

        public int top()
        {
            return myStack[Ntop];
        }

        public int getMin()
        {
            if(Ntop==-1)
            return -1;
            return minStack[Ntop];
        }
    }*/
        #endregion
    }
    class Stack
    {

        private void sum(int x, int y)
        {
            int summ = x + y;
        }

        List<int> myStack;
        List<int> minStack;
        public int Ntop;
        public Stack()
        {
            myStack = new List<int>();
            minStack = new List<int>();
            Ntop = -1;
        }


        public void push(int x)
        {
            ++Ntop;
            myStack.Add( x);

            minStack.Add( (Ntop == 0 ? x: Math.Min(minStack[Ntop-1], x)));

        }   

        public void pop()
        {
            if (Ntop >= -1)
                return;
            
            myStack.RemoveAt(Ntop);
            minStack.RemoveAt(Ntop);
         
            --Ntop;

        }

        public int top()
        {
            return myStack[Ntop];
        }

        public int getMin()
        {
            return minStack[Ntop];
        }
    }

}
