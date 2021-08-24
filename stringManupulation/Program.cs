using System;
using System.Collections.Generic;
using System.Linq;


namespace stringManupulation
{
    class Program
    {
        public static string reversestrng;
        static void Main(string[] args)
        {
            string s = getLargest1("psafelqnoe_eflqypyqecbrvxyoagogravxvlmrirxitihomztvjmenihqvfu");//"ittmcsvmoa_jktvvblefw"/twnwdluhxf_l
            s = getLargest("ittmcsvmoa_jktvvblefw");
            List<string> lagrgestcommonprefx = new List<string>() { "abcd" };// "abcdefgh", "aefghijk", "abcefgh" };
            string loncompr = longestCommonPrefix(lagrgestcommonprefx);

            List<char> A = new List<char>() { 'S', 'c', 'A', 'L', 'E', 'r', 'A', '%', 'c', 'a', 'D', 'e', 'm', 'y' };
            int alphanumeric_ = alphanumeric(A);
            int alph = alpha(A);
            A = to_upper(A);
            string _rotattetoN = rotatetoN("bue", 78);
            string reverse = reverseString("Abcdef");
            reversestrng = reverseSentancearr("qxkpvo  f   w vdg t wqxy ln mbqmtwwbaegx   mskgtlenfnipsl bddjk znhksoewu zwh bd fqecoskmo");// ("qxkpvo  f   w vdg t wqxy ln mbqmtwwbaegx   mskgtlenfnipsl bddjk znhksoewu zwh bd fqecoskmo");
        }
        public static string reverseSentance(string A)
        {
            List<string> sen = new List<string>();
            //sen = A.Split(" ").ToList();

            sen.Reverse();
            reversestrng = string.Join(" ", sen.ToArray());

            return reversestrng;
        }
        public static string reverseSentancearr(string A)
        {
            string[] sen;
            sen = A.Split(' ');

            int lisindex = sen.Length - 1;

            for (int ind = 0; ind < sen.Length / 2; ind++)
            {
                string temp;
                temp = sen[ind];
                sen[ind] = string.IsNullOrEmpty(sen[lisindex]) ? " " : sen[lisindex];
                sen[lisindex] = string.IsNullOrEmpty(temp) ? " " : temp;
                lisindex--;

            }

            for (int j = 0; j < sen.Length; j++)
            {
                if (!string.IsNullOrEmpty(sen[j]))
                    reversestrng = reversestrng + sen[j] + " ";
            }

            return reversestrng.Trim();
        }
        public static string reverseString(string A)
        {

            List<char> c = new List<char>();
            c.AddRange(A.Reverse());
            //for(int i=0;i<c.Count()/2;i++)
            //{
            //  swap (last and first elemet)
            //}
            string rev = new string(c.ToArray());
            return rev;


        }

        public static string rotatetoN(string A, int B)
        {
            //char[] Roaten;
            //Roaten = A.ToArray();
            //string Aq = new string(A.ToArray());
            //for (int i = 0; i < B; i++)
            //{

            //}
            if (B > A.Length)
                B = B % A.Length;

            A = A.Substring(A.Length - B) + A.Remove(A.Length - B, B);
            return A;
        }
        public static List<char> to_upper(List<char> A)
        {
            List<char> upper = new List<char>();
            for (int i = 0; i < A.Count; i++)
            {
                upper.Add(char.ToUpper(A[i]));
            }
            return upper;
        }
        public static List<char> to_lower(List<char> A)
        {
            List<char> lower = new List<char>();
            for (int i = 0; i < A.Count; i++)
            {
                lower.Add(char.ToLower(A[i]));
            }
            return lower;
        }
        public static int alphanumeric(List<char> A)
        {

            for (int i = 0; i < A.Count; i++)
            {
                if (!char.IsLetterOrDigit(A[i]))
                    return 0;
            }
            return 1;
        }
        public static int alpha(List<char> A)
        {

            for (int i = 0; i < A.Count; i++)
            {
                if (!char.IsLetter(A[i]))
                    return 0;
            }
            return 1;
        }

        public static string longestCommonPrefix(List<string> A)
        {
            string loncompre = "";
            string temp = "";
            A.Sort();

            for (int i = 0; i < A[0].Length+1; i++)
            {
                temp = loncompre;
                loncompre = A[0].Substring(0, i);
               bool loncompreb = Longcompare(loncompre, A, i);
                if (!loncompreb)
                    return temp;

            }
            return loncompre;
        }

        private static bool Longcompare(string loncompre, List<string> a, int i)
        {
            foreach (string s in a)
            {
                if (!(loncompre == s.Substring(0, i)))
                    return false;  
            }

            return true;
        }
        public static string getLargest(string A)
        {
            List<string> larst = new List<string>();
            larst.AddRange(A.Split('_'));
            string s=A;
            List<char> rplace = new List<char>();
            rplace.AddRange(larst[1]);
            rplace.Sort();
            rplace.Reverse();
            List<char> c = new List<char>();
            c.AddRange(larst[0]);
            for(int i=0;i<c.Count;i++)
            {
                //for(int j=0;j<rplace.Count;j++)
                if (!(rplace.Count > i))
                {
                    break;
                }
                  else  if (rplace[i] > c[i])
                    {
                        c[i] = rplace[i];
                        s = new string(c.ToArray());
                        //     break;
                    }
                
               
            }

            return (s);



        }
/*secound attempt failed first
         
         Unhandled Exception:
System.ArgumentOutOfRangeException: Argument is out of range.
Parameter name: index
  at Solution.getLargest (System.String A) [0x00000] in :0 
  at MAIN.Main (System.String[] args) [0x00000] in :0 
[ERROR] FATAL UNHANDLED EXCEPTION: System.ArgumentOutOfRangeException: Argument is out of range.
Parameter name: index
  at Solution.getLargest (System.String A) [0x00000] in :0 
  at MAIN.Main (System.String[] args) [0x00000] in :0 
Your submission encountered runtime error for the following input:
A : "psafelqnoe_eflqypyqecbrvxyoagogravxvlmrirxitihomztvjmenihqvfu"
The expected output for this testcase is:
zyyyxxxvvv
*/
        public static string getLargest1(string A)
        {
            List<string> larst = new List<string>();
            larst.AddRange(A.Split('_'));
            string s = new string(larst[0].ToArray());//failing cos i didi s=A
            List<char> rplace = new List<char>();
            rplace.AddRange(larst[1]);
            rplace.Sort();
            rplace.Reverse();
            List<char> c = new List<char>();
            c.AddRange(larst[0]);
            int count = c.Count;
            for (int i = 0; i <count; i++)
            {
                
                if (rplace[0] > c[i])
                {
                    c[i] = rplace[0];
                    s = new string(c.ToArray());
                    rplace.RemoveAt(0);
                    if (rplace.Count == 0)
                        break;
                }


            }

            return (s);



        }

    }
}

