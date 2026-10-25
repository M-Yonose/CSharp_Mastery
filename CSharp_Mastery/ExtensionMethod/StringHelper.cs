using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExtensionMethod
{
    public static class StringHelper
    {
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        public static string GetMiddle(this string str, int skip)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            int length = str.Length;
            int start = skip;
            int end = length - skip;
            if (start >= end)
                return string.Empty;
            return str.Substring(start, end - skip);
        }
    }
}

