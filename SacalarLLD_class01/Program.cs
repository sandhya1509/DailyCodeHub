using System;
using System.Collections.Generic;
using System.Linq;

namespace SacalarLLD_class01
{
    class Program
    {/*
      Smaller and Greater
        You are given an Array A of size N.

        Find for how many elements, there is a strictly smaller element and a strictly greater element.



        Input Format

        Given only argument A an Array of Integers.
        Output Format

        Return an Integer X, i.e number of elements.
        Constraints

        1 <= N <= 1e5
        1 <= A[i] <= 1e6
        For Example

        Example Input:
            A = [1, 2, 3]

        Example Output:
            1

        Explanation:
            only 2 have a strictly smaller and strictly greater element, 1 and 3 respectively.
      */
        static void Main(string[] args)
        {
            int result;
             Console.WriteLine("Hello World!");
            List<int> C = new List<int>()
           // { 3,4,6,0,5,0,3,5,6};
            { 471, 201, 361, 973, 715, 875, 365, 77, 480, 71, 507, 886, 350, 708, 176, 751, 574, 447, 220, 252, 896, 570, 945, 962, 637, 168, 602, 594, 770, 136, 77, 614, 843, 653 };
            //C.Add(3);
            //C.Add(4);
            //C.Add(6);
            //C.Add(0);
            //C.Add(5);
            //C.Add(0);
            //C.Add(3);
            //C.Add(5);
            //C.Add(6);

            //C.Add(6);
            //C.Add(6);
            //C.Add(6);
            //C.Add(6);
            //C.Add(6);
            //C.Add(6);
            //C.Add(6);
            //C.Add(5);
            //C.Add(6);

            //  timecomplex(4);
            printPattern1(1);
            even(C);
            result = minmax(C);
            List<int> result1 = Solve_max2(C);
            result = Solve(C);
        

             int[,] k = printPattern(3);
        }


        public static int Solve(List<int> A)
        {
            int i;
            A.Sort();
            int min = A.Min();
            int max = A.Max();
            A.RemoveAll(j => j == min);
            A.RemoveAll(j => j == max);
            i = A.Count;
            return i;
        }

        //-----------------------------------------------------------------//
        public static int[,] printPattern(int num)
        {
            int[,] i=new int[num,num];

            //int[] j = new int[num];

            for(int k=0;k<num; k++)

            {
               
               for (int j=0;j<=k;j++)
                {
                    i[k, j] = j+1 ;
                    Console.Write(i[k, j] +" ");

                }

                Console.Write("\n");
            }

            return i;
        }

        public static List<List<int>> printPattern1(int A)
        {
            int[,] i = new int[A, A];

            
            List<List<int>> arrPartern = new List<List<int>>();

            for (int k = 0; k < A; k++)

            {
                List<int> pattern = new List<int>();

                for (int j = 0; j <= k; j++)
                {
                    i[k, j] = j + 1;
                    pattern.Add(j + 1);


                }

                arrPartern.Insert(k, pattern);

                foreach (var ptt in arrPartern)
                {
                    Console.Write("[");
                    foreach (var pt in ptt)
                    {

                        Console.Write(pt);    
                    }
                    Console.Write("]");
                }
            }
          


            return arrPartern;
        }

        public static List<int> Solve_max2(List<int> A)
        {

            List<int> temp = new List<int>() ;
            temp = A.ToList();
            temp.Sort();
            int max = temp[temp.Count-1];
            int max1 = temp[temp.Count - 2];
            A.Remove(max1);
            A.Remove(max);
            return A;
        }

        public static int minmax(List<int> A)
        {

            List<int> tempeve = new List<int>();
            List<int> tempodd = new List<int>();

            foreach (int i in A)
            { if (i % 2 == 0)
                tempeve.Add(i);
                       
                else
                    tempodd.Add(i);
            
            }

            
            return tempeve.Max()-tempodd.Min();
        }
        public static int even(List<int> A)
        {
            int k;

            k = 0;
            foreach (int i in A)
            {
                if ((i&1) == 0)
                    Console.WriteLine(i);
                k = i;
                
                
            }
            return k;


        }
public static void  timecomplex(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("i<n "+i.ToString());
            }

            Console.WriteLine("---------------------------------------------------------");


            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("i<=n "+i.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(" i=1 i<n " + i.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("i=1 i<=n " + i.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("i " + i.ToString() + " j =" + j.ToString());
                }
            }


        }


    }
}