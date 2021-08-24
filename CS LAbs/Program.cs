using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_LAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          //  int maxval = Maxfrag("9950552");
            string columnExcel = ExcelColm(3354);
        }
        #region
        /*Given a string consisting of digits find the biggest two-digit value that is a consistent fragment of the given string :Input : 50552
Output : 55
consistent fragments of this input string. are 50, 05, 55, 52*/
        #endregion
        public static int Maxfrag(string input)
        {
            int max = 0;
            List<char> inputlis = new List<char>();
            inputlis.AddRange(input.ToCharArray());

            for (int i = 0; i < inputlis.Count - 1; i++)
            {

                max = Math.Max(max, (Convert.ToInt32((inputlis[i].ToString() + (inputlis[i + 1].ToString())))));

            }

            return max;

        }

        public static string ExcelColm(int input)
        {
            String column = "";
            bool perfrcdiv = false;

            Dictionary<int, char> columndefi = new Dictionary<int, char>();
            
            //string A=

            for (int i = 0; i < 26; i++)
            {
                columndefi.Add(i+1, Convert.ToChar(65+i));

             }
            if ((input % 26 == 0))
            {
                input = input - 1;
                perfrcdiv = true;
            }
           
             while (input > 26)
                {
                    column = column.Insert(0, columndefi[input % 26].ToString());

                    input = input / 26;

                }
            
            if(input<26)
            {
               
                column = column.Insert(0, columndefi[input % 26].ToString());
            }

            if (perfrcdiv)
            {
                string columndb = column;
               
                column.ToCharArray();
                char lastchar=column[column.Length-1];
                char replavechar = Convert.ToChar(Convert.ToInt16(lastchar) + 1);
                column= columndb.Replace(lastchar, replavechar);
            }

          




            return column;
        }
    }
}
