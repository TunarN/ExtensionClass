using System;
using System.Collections.Generic;
using System.Text;

namespace extencion_class.models
{
   static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            
            if (num%2==1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num%2==0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (item>47&&item<58)
                {
                    return true;
                    
                }
               
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            StringBuilder s = new StringBuilder();
            s.Append(Char.ToUpper(str[0]));
            s.Append(str.Substring(1).ToLower());
            return s.ToString();
        }
        public static int[] GetValueIndexes(this string str, char ch)
        {
            int[] Arr = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Array.Resize<int>(ref Arr, Arr.Length + 1);
                    Arr[Arr.Length - 1] = i;
                }
            }

            return Arr;
        }

    }
}
