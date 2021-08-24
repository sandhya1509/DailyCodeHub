using System;
using System.Collections.Generic;
namespace Basics_of_Maths


{


    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s;
            s = "AB";
            i = isPalindrome(12321);
            i = titleToNumber(s);
            List<int> a = new List<int>() { 1,0};
            arrange(a);

        }
/*
        Excel Column Number
Problem Description

Given a column title as appears in an Excel sheet, return its corresponding column number.



Problem Constraints
1 <= length of the column title <= 5



Input Format
Input a string which represents the column title in excel sheet.



Output Format
Return a single integer which represents the corresponding column number.



Example Input
Input 1:

 AB
Input 2:

 ABCD


Example Output
Output 1:

 28
Output 2:

 19010


Example Explanation
Explanation 1:

 A -> 1
 B -> 2
 C -> 3
 ...
 Z -> 26
 AA -> 27
 AB -> 28*/

        public static int titleToNumber(string A)
        {
            int titletonum = 0;
            Dictionary<char, int> dic_alphanum = new Dictionary<char, int>();
            for(int i=0;i<26;i++)
            {
                dic_alphanum.Add(Convert.ToChar(65+i), i+1);

            }

            List<char> numlist = new List<char>();
            numlist.AddRange(A);
            numlist.Reverse();
            for (int i = 0; i < numlist.Count; i++)
            {
                titletonum += Convert.ToInt32(Math.Pow(26,i))*dic_alphanum[numlist[i]];
            }


                return titletonum;
        }
        /*Rearrange Array
Rearrange a given array so that Arr[i] becomes Arr[Arr[i]] with O(1) extra space.

Example:

Input : [1, 0]
Return : [0, 1]
 Lets say N = size of the array. Then, following holds true :
All elements in the array are in the range [0, N-1]
N * N does not overflow for a signed integer*/
        public static void arrange(List<int> a)
        {
            int temp=0;
            for (int i=0;i<a.Count;i++)
            {
                if(a[i]<a.Count)
                a[i] = a[a[i]];

            }

        }


        public static int isPalindrome(int A)
        {
            int palindrome = 0;
            int count = (int)Math.Ceiling(Math.Log10(A));
            int j = count - 1;
            int reverseA = 0;
            int reminderA = 0;

            //for (int i = 0; i <= count/2; i++)
            //{
            //    if(!(
            //        Math.Floor(A/Math.Pow(10,j)) ==

            //        Math.Floor(A % Math.Pow(10, i))* Math.Pow(10, i )+ Math.Floor(A / Math.Pow(10, i ))

            //        ))
            //    {
            //        palindrome = 0;
            //    }
            //    j--;
            j = A;
            while (j > 0)
            {
                reminderA = j % 10;
                reverseA = reverseA*10 + reminderA;
                j = j / 10;

            }

            if (A == reverseA)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
            }
           // return palindrome;
        }


