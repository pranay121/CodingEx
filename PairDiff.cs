using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class Solution
    {
        public static int solve(List<int> A, int B)
        {
            int len = A.Count, i = 0, j = 1, f = 0;
            A.Sort();
            A.ForEach(Console.WriteLine);
            for (int k = 0; k < len - 1; k++)
            {
                if (A[j] - A[i] == B) 
                {
                    Console.WriteLine($"Difference equal = {A[j] - A[i]} {i} {j}");
                    f = 1;                  
                }
                if(A[j] - A[i] > 0)
                {
                    if (A[j] - A[i] < B)
                    {
                        Console.WriteLine("Difference less than {0} {1} {2}", A[j] - A[i], i, j);
                        if (A[j] - A[i] > 0)
                            j++;
                        else
                            i++;
                    }
                    if (A[j] - A[i] > B)
                    {
                        Console.WriteLine($"Difference greater {A[j] - A[i]} {i} {j}");
                        //j = i;
                        if (A[j] - A[i] > 0)
                            i++;
                        else
                            j++;
                    }
                }
                }
            return f;
        }

        //// Driver program to test above function
        //public static void Main(string[] args)
        //{
        //    List<int> A = new List<int> { -259, -825, 459, 825, 221, 870, 626, 934, 205, 783, 850, 398 };
        //    int n = -42;
        //    Console.Write(solve(A, n));
        //}
    }

}
