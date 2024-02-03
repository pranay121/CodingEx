using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class Solution1
    {
        public static bool isAnagram(string a, string b)
        {
            bool flag = true;
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            foreach (char c in a)
            {
                if (!dict1.ContainsKey(c))
                    dict1.Add(c, 1);
                else
                    dict1[c]++;
            }
            foreach (char c in b)
            {
                if (!dict2.ContainsKey(c))
                    dict2.Add(c, 1);
                else
                    dict2[c]++;
            }
            foreach (var key in dict1.Keys)
            {
                if (!dict2.ContainsKey(key) || dict1[key] != dict2[key])
                {
                    flag = false;
                }
            }
            return false;
            //Your code here
        }
        //InterviewBit - 1
        public static int PickBothsides(int[] arr, int b)
        {
            int last = arr.Length - 1, start = 0, maxsum = 0;
            while(start < b)
            {
                maxsum += arr[start];  
                start++;
            }
            return 0;
        }
        //IB - 2
        public static string RemoveConsChar(string str)
        {
            int len = str.Length;
            string newStr = "";
            for(int i =0;i<len;i++)
            {
                if(i < len - 1 && str[i] == str[i + 1])
                    continue;
                else
                    newStr = newStr + str[i];
            }
            return newStr;
        }
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

        //Function to find a continuous sub-array which adds up to a given number.
        public static List<int> subarraySum(int[] arr, int n, int s)
        {
            int start = 0, curr = 0, sum = 0, end = n - 1;
            List<int> pos = new List<int>();
            while (curr <= end)
            {
                sum += arr[curr];
                if (sum == s)
                {
                    end = curr;
                    pos.Add(start);
                    pos.Add(end);
                    break;
                }
                if (sum < s)
                    curr++;
                else if (sum > s)
                {
                    sum = 0;
                    start++;
                    curr = start;
                }
            }
            Console.WriteLine(sum);
            return pos;
            //code here
        }

        public static void countWords(string sentence)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            StringBuilder st = new StringBuilder();
            foreach (char ch in sentence)
            {
                if (ch != ' ')
                    st.Append(ch);
                else
                {
                    if (!wordCount.ContainsKey(st.ToString()))
                    {
                        wordCount.Add(st.ToString(), 1);
                        st.Clear();
                    }
                    else
                    {
                        wordCount[st.ToString()]++;
                        st.Clear();
                    }
                }
            }
            foreach (var dict in wordCount)
                Console.WriteLine(dict.Key + ":" + dict.Value);
        }

        public static void getProjects(IEnumerable<dynamic> obj)
        {
            Dictionary<string, List<string>> finalOutput = new Dictionary<string, List<string>>();
            foreach(var o in obj)
            {
                if (!finalOutput.ContainsKey(o.Name))
                {
                    finalOutput.Add(o.Name, new List<string> { o.Project });
                }
                    
                else
                {
                    List<string> lst = finalOutput[o.Name];
                    lst.Add(o.Project);
                    finalOutput[o.Name] = lst;                    
                }
            }
            foreach (var data in finalOutput)
                Console.WriteLine(data.Key + ":" + string.Join(",",data.Value));
        }
        public static string GoaTripPossibility(int n, int s, int c, int h, int l, int t)
        {
            return "";

        }

        // Driver program to test above function
        public static void Main(string[] args)
        {
            //getProjects(new[] { new { Name = "Pranay", Project = "A" }, 
            //    new { Name = "Pranay", Project = "B" }, 
            //    new { Name = "Prakash", Project = "A" },
            //    new { Name = "Girish", Project = "S" }});
            //countWords("Hello my name is Pranay and Hello ");
            Console.WriteLine(subarraySum(new int[] { 142, 112, 54, 69, 148, 45, 63, 158, 38, 60, 124, 142, 130, 179, 117, 36, 191, 43, 89, 107, 41, 143, 65,
                49, 47, 6, 91, 130, 171, 151, 7, 102, 194, 149, 30, 24, 85, 155, 157, 41, 167, 177, 132, 109, 145, 40, 27, 124, 138, 139, 119, 83, 130, 142,
                34, 116, 40, 59, 105, 131, 178, 107, 74, 187, 22, 146, 125, 73, 71, 30, 178, 174, 98, 113 }, 74, 665));
            //Console.WriteLine(Median.medianArray(new int[] { 1, 3, 5}, new int[] { 2, 4, 6 }));
            //Console.WriteLine(isAnagram("geeksforgeeks", "forgeeksgeeks"));
            //Console.WriteLine(RemoveConsChar("aaaabbdcccg"));
            //Console.WriteLine(PickBothsides(new int[] { 3, 2, 1, 5, 4 },3));
            //StartPatternIndex("GeeksforGeeks", "Geeks");
            //Console.WriteLine(ThirdHighestArray(new int[] { 3, 2, 1, 5, 4 }));
            //Console.WriteLine(SecondHighestArray(new int[] { 3,4,2,1,5,4 }));
            //Console.WriteLine(RemoveDuplicateChar("csharpcorner"));
            //OccuranceCharString("hello world");
            //Console.WriteLine(RevEachWordString("Welcome to Csharp corner"));
            //Console.WriteLine(revOrderString("Welcome to Csharp corner"));
            //Console.WriteLine(isPalindrome("book "));
            //Console.WriteLine(ReverseString("hello"));
            //Console.WriteLine(GoaTripPossibility(1, 1, 1, 1, 1, 1));
        }
    }

}
