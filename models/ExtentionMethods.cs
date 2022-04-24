using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkd1114.models
{
    static class ExtentionMethods
    {
         static bool Iseven( this int a ) 
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public static int[] GetValueIndexes(int num) 
        {
            int[] arr = { 5 , 15 , 78 , 99 };

            int[] arr2 = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    Array.Resize(ref arr2,arr2.Length+1);
                    arr2[arr2.Length - 1] = i;
                }
            }
            return arr2;
        }
        static bool IsOdd(this int a) 
        {
            if (a % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        static bool IsContainsDigit( this string Fullname) 
        {
            foreach (char item in  Fullname)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static int[] GetValueIndex(char car) 
        {
            string word = "Hello World";
            int[] arr = { };
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==car)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }
    }
}
