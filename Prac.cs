using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class Solution1
    {
        public static void StartPatternIndex(string str, string pattern)
        {
            int len = str.Length, flag = 1, k = 0;
            ArrayList lst = new ArrayList();
            for(int i = 0; i < len-1; i++)
            {
                flag = 1;
                for(int j =0; j < pattern.Length -1; j++)
                {
                    if (str[i+j] != str[j])
                    {
                        flag = 0;   
                        break;
                    }
                }
                if (flag == 1)
                {
                    lst.Add(i);
                }
            }
            foreach (int i in lst)
                Console.WriteLine(i);
        }
        public static int ThirdHighestArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2 && arr[i] != max1)
                {
                    max3 = max2;
                    max2 = arr[i];
                }
                else if (arr[i] > max3 && arr[i] != max2)
                {
                    max3 = arr[i];
                }
            }
            return max3;
        }
        public static int SecondHighestArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if(arr[i] > max2 && arr[i] != max1)
                {
                    max2 = arr[i];
                }
            }
            return max2;
        }
        //public static string RemoveDuplicateChar(string str)
        //{
        //    string newStr = string.Empty;
        //    for(int i = 0; i <= str.Length-1; i++)
        //    {
        //        if(newStr.)
        //    }
        //    return "";
        //}
        public static void OccuranceCharString(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach(var ch in str)
            {
                if(ch != ' ')
                {
                    if (!freq.ContainsKey(ch))
                        freq.Add(ch, 1);
                    else
                        freq[ch]++;
                }
            }
            foreach(var dic in freq)
            {
                Console.WriteLine($"{dic.Key}:{dic.Value}");
            }
        }
        public static string RevEachWordString(string str)
        {
            int current = 0, len = str.Length, last = 0;
            StringBuilder revWord = new StringBuilder();
            while (current < len)
            {
                if(str[current] == ' ' || current == len - 1)
                {
                    int Start = current == len - 1 ? current : current - 1;
                    while (Start >= last)
                    {
                        revWord.Append(str[Start]);
                        Start--;
                    }
                    revWord.Append(' ');
                    last = current + 1;
                }
                current++;
            }
            return revWord.ToString();
        }
        public static string revOrderString(string str)
        {
            int current = str.Length - 1, last = str.Length - 1, first = str.Length - 1;
            StringBuilder revStr = new StringBuilder();

            while(current >= 0)
            {
                if(str[current] == ' ' || current == 0)
                {
                    first = current == 0 ? current : current + 1;
                    while (first <= last)
                    {
                        revStr.Append(str[first]);
                        first++;
                    }
                    revStr.Append(' ');
                    last = current - 1;
                }
                current--;
            }
            return revStr.ToString();
        }
        public static string isPalindrome(string str)
        {
            string isPalindrome = "Palindrome";
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    isPalindrome = "Not Palindrome";
                    break;
                }
            }
            return isPalindrome;
        }
        public static string ReverseString(string str)
        {
            char[] ch = str.ToCharArray();
            for(int i = 0, j = str.Length-1; i<j; i++, j--)
            {
                ch[i] = str[j];
                ch[j] = str[i];
            }
            return new string(ch);
        }

        // Driver program to test above function
        public static void Main(string[] args)
        {
            StartPatternIndex("GeeksforGeeks", "Geeks");
            //Console.WriteLine(ThirdHighestArray(new int[] { 3, 2, 1, 5, 4 }));
            //Console.WriteLine(SecondHighestArray(new int[] { 3,4,2,1,5,4 }));
            //Console.WriteLine(RemoveDuplicateChar("csharpcorner"));
            //OccuranceCharString("hello world");
            //Console.WriteLine(RevEachWordString("Welcome to Csharp corner"));
            //Console.WriteLine(revOrderString("Welcome to Csharp corner"));
            //Console.WriteLine(isPalindrome("book "));
            //Console.WriteLine(ReverseString("hello"));
        }
    }

}
