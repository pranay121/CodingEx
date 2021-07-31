using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class maxSubArray
    {
        public static void SubArray(int[] arr)
        {
            int size = arr.Length;
            int sum = 0, end = 0, maxsum = 0;
            int flag = 0, fstart = 0, ffstart = 0, fflag = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > 0)
                {
                    if (flag == 0)
                        fstart = i;
                    flag = 1;
                    sum = sum + arr[i];
                }
                if(arr[i] < 0 || i==size-1)
                {
                    flag = 0;
                    if ((sum > maxsum && fflag != 0) && arr[i]<0)
                    {
                        maxsum = sum;
                        end = i - 1;
                        ffstart = fstart;
                        sum = 0;
                    }
                    else if(i==size-1 && arr[i]>0)
                    {
                        end = i;
                        ffstart = fstart;
                    }

                    else if (fflag == 0)
                    {
                        maxsum = sum;
                        sum = 0;
                        end = i - 1;
                        fflag = 1;
                    }
                }

            }

            for (int i = ffstart; i <= end; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
