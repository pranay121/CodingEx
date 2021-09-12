using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class maxCount
    {
        public static void maxCountString(string str)
        {
            Dictionary<char, int> dictcount = new Dictionary<char, int>();
            int count = 0,max=0;
            foreach(char ch in str)
            {
                if(!dictcount.ContainsKey(ch))
                {
                    dictcount.Add(ch,1);
                }
                else
                {
                    dictcount[ch]++;
                }
            }

        }
    }
}
