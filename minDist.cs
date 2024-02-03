using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class minDist
    {
        public static void minDistance(int[] arr,int x,int y)
        {
            int pos1=-1,pos2 = -1;
            for(int i = 0;i<arr.Length;i++)
            {
                if((arr[i]==x||arr[i]==y) && pos1==-1)
                 {
                    pos1 = i;
                    continue;
                 }
                else if((arr[i] == x || arr[i] == y))
                {
                    pos2 = i;
                    break;
                }
            }
            Console.WriteLine(pos2-pos1);

        }
    }
}
