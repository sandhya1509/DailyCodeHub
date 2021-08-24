using System;
using System.Collections.Generic ;
using System.Text;

namespace Introduction_to_Sorting
{
   public class ICompareCLASS:IComparer<int>
    {
        public Int32 Compare(int x, int y)
        {
            if (x == null || y == null)
                return 0;
            int i = y /  Convert.ToInt32(Math.Pow(10, Math.Log10(y)));
            i = i/ y;
             return x.CompareTo(i);
          


        }

       
    }

    public class ICompareCLASSchar : IComparer<char>
    {
        public int Compare(char x, char y)
        {
            if (x == null || y == null)
                return 0;
            return x.CompareTo(y);

        }


    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> A = new List<int>() {5,9,98,02,15,45 };
            //int i=arethmatic_progression(A);
           // string s = largestNumber(A);
            string s = largestNumber_new(A);
            //  A = Sort_by_Color(A);//{1,2,0,1,0,2 }
        }
        #region AP
        #region arethmatic progression 
        /*Arithmetic Progression?
Problem Description

Given an integer array A of size N. Return 1 if the array can be rearranged to form an arithmetic progression, otherwise, return 0.

A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.



Problem Constraints
2 <= N <= 105

-109 <= A[i] <= 109



Input Format
First and only argument is an integer array A of size N.



Output Format
Return 1 if the array can be rearranged to form an arithmetic progression, otherwise, return 0



Example Input
Input 1:

 A = [3, 5, 1]
Input 2:

 A = [2, 4, 1]


Example Output
Output 1:

 1
Output 2:

 0


Example Explanation
Explanation 1:

 We can reorder the elements as [1,3,5] or [5,3,1] with differences 2 and -2 respectively, between each consecutive elements.
Explanation 2:

 There is no way to reorder the elements to obtain an arithmetic progression.*/
        #endregion
        //an=a1+(n-1)d
        //d is common difference

        public static int arethmatic_progression(List<int> A)
        {
                       A.Sort();
          
            if(
                (
                ((A[A.Count-1])-A[0])
                /(A[1]-A[0]))+1
                ==A.Count)
            {
                return 1;
            }
            else            
                return 0;
        }
        #endregion
        #region largentnumber by sorting
        /*Largest Number
        Problem Description

        Given a array A of non negative integers, arrange them such that they form the largest number.

        Note: The result may be very large, so you need to return a string instead of an integer.



        Problem Constraints
        1 <= len(A) <= 100000
        0 <= A[i] <= 2*109



        Input Format
        First argument is an array of integers
        Output Format
        Return a string representing the largest number.
        Example Input
        Input 1:
         A = [3, 30, 34, 5, 9]
        Input 2:
         A = [2, 3, 9, 0]


        Example Output
        Output 1:

         "9534330"
        Output 2:

         "9320"


        Example Explanation
        Explanation 1:

         A = [3, 30, 34, 5, 9]
         Reorder the numbers to [9, 5, 34, 3, 30] to form the largest number.
        Explanation 2:

         Reorder the numbers to [9, 3, 2, 0] to form the largest number 9320. */
        #region old

        public static string largestNumber(List<int> A)
        {
            string s1="";
            List<List<char>> numlist = new List<List<char>>();
            ICompareCLASS comparer = new ICompareCLASS();
           
           // A.Sort(0, A.Count, comparer);

            Dictionary<int,List<int>> D = new Dictionary<int, List<int>>();

            foreach(int i in A)
            {

                int k= i / Convert.ToInt32(Math.Pow(10, Convert.ToInt32(Math.Log10(i))));
              //  if (!D.ContainsKey(k))
                  //  D.Add(k, i);
              //  D[k].Add(i);
                
            }


            ICompareCLASSchar charcomp = new ICompareCLASSchar();
            foreach (int i in A)
            {
                List<char> numlistmi = new List<char>();
                string s = i.ToString();
                numlistmi.AddRange(s.ToCharArray());

                numlist.Add(numlistmi);
            }
            //foreach (List<char> l in numlist)
            {
                //numlist.Sort(0, numlist.Count, charcomp);
            }

            return s1;


        }
        #endregion

        public static string largestNumber_new(List<int> A)
        {
            #region my sol
            /*
            String Largestnum ="";
            #region dic method

           

            Dictionary<int, List<int>> D = new Dictionary<int, List<int>>();

                    foreach(int i in A)
                    {
                        int key;
                        if (i == 0)
                            key = 0;
                        else
                                 key = i / Convert.ToInt32(Math.Pow(10, Math.Truncate(Math.Log10(i))));

                                if (D.ContainsKey(key))
                                    D[key].Add(i);
                                else
                                {
                                    List<int> newList = new List<int>() {i};

                                    D.Add(key, newList);
                                   
                                 }
                    }


            SortedDictionary<int, List<int>> SortKeyValue = new SortedDictionary<int, List<int>>(D);

            List<int> final=new List<int>();
                    for (int i=9;i>=0;i--)
                    {
                        if (SortKeyValue.ContainsKey(i))
                        {
                            List<int> li = SortKeyValue[i];
                            li.Sort();
                    li.Reverse();
                    if (li.Count > 0)
                            {
                        for (int ki = 0; ki < li.Count; ki++)
                        {
                            for (int j = 0; j < li.Count - 1; j++)
                            {
                                if (Convert.ToInt64(li[j].ToString() + li[ki].ToString()) < Convert.ToInt64(li[ki].ToString() + li[j].ToString()))
                                {
                                    int temp = li[ki];
                                    li[ki] = li[j];
                                    li[j] = temp;
                                }
                            }
                        }
                        final.AddRange(li);
                            }
                        }

            }
            #endregion


            #region sort methd
            /*
                for (int i=0;i<A.Count;i++)
            {
                for(int j=0;j< A.Count-1; j++)
                {
                    if (Convert.ToInt64(A[j].ToString() + A[j + 1].ToString()) < int.Parse(A[j + 1].ToString() + A[j].ToString()))
                    {
                        int temp = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
              */
            /*
            for (int i = 0; i < final.Count; i++)
            {
                Largestnum = Largestnum + final[i].ToString();
            }
          
            #endregion
            if (Convert.ToDouble(Largestnum) == 0)
                Largestnum = "0";

                return Largestnum.ToString(); 
            */
            #endregion

       

            #region scalar
            A.Sort((int a, int b) => {
                string s1 = a.ToString() + b.ToString();
                string s2 = b.ToString() + a.ToString();
                return -s1.CompareTo(s2);
            });
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < A.Count; i++)
                str.Append(A[i].ToString());//998545215

            for (int i = 0; i < str.Length; i++)
                if (str[i] != '0')
                    return str.ToString(i, str.Length - i);
            return "0";
            #endregion
        }
        #endregion
        #region Sort by Color
        /*Sort by Color
          Problem Description
          Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.
          Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

          Note: Using library sort function is not allowed.
          Problem Constraints
          1 <= N <= 1000000
          0 <= A[i] <= 2

          Input Format
          First and only argument of input contains an integer array A.

          Output Format
          Return an integer array in asked order

          Example Input
          Input 1 :
              A = [0 1 2 0 1 2]
          Input 2:
              A = [0]

          Example Output
          Output 1:
              [0 0 1 1 2 2]
          Output 2:
              [0]
          Example Explanation
          Explanation 1:
          [0 0 1 1 2 2] is the required order.*/
        #endregion
        public static List<int> Sort_by_Color(List<int> A)
        {
            List<int> B = new List<int>();
            int temp = 0;
            for(int i=0;i<A.Count;i++)
            {
                for(int j=i+1;j<A.Count;j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;

                    
                    }
                }
             
            }

            return A;


        }
    }
}
