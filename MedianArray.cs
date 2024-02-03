using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class Median
    {
        public static double medianArray(int[] arr1,int[] arr2)
        {
            //Sorted arrays
            double sum = 0; 
            int len1 = arr1.Length, len2 = arr2.Length;
            double med;
            for (int i = 0; i < len1; i++)
                sum += arr1[i];
            for (int j = 0; j < len2; j++)
                sum += arr2[j];
            //Console.WriteLine(len1 + len2);
            med = sum / (len1 + len2);
            return med;
        }
    }
}
