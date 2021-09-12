using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    class GoodBadString
    {
        public static int isGoodorBad(string str)
        {
            int isvowel = 0,iscons = 0;
            foreach (char c in str)
            {
                if (isVowel(c))
                {
                    isvowel++;
                    iscons = iscons<=3 ? 0:iscons;
                }
                else if(c!='?')
                {
                    iscons++;
                    isvowel = isvowel<=5 ? 0:isvowel;
                }
                if (isvowel >= 3 && c == '?')
                    isvowel++;
                else if (iscons >= 1 && c == '?')
                    iscons++;
            }
            if (isvowel > 5 || iscons > 3)
                return 0;//bad String
            else
                return 1;// Good String
        }
        public static bool isVowel(char c)
        {
            if(c=='a' || c== 'e' || c=='i' ||c=='o' || c== 'u')
                return true;
            else
                return false;
        }
    }
}
