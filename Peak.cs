using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class Peak
    {
        //O(nlogn) 1,2,3 ------------1,2,3
        public static void Peakelement(int []arr)
        {
            int length = arr.Length;
            getPeakelement(arr, 0, length - 1);
        }
        public static void getPeakelement(int []arr,int ub,int lb)
        {
            int peakIndex = 0;
            int length = arr.Length;
            int mid = (ub + lb) / 2;
            if (length > 1)
            {

            }

        }
    }
}
