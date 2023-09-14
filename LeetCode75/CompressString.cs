using System;
using System.Runtime.InteropServices;

namespace LeetCode
{
	public class CompressString
	{
		public CompressString()
		{
		}

		public int compress(char[] chars)
		{
            string s = "";
            int len = chars.Length;
            int repetition = 1;
            char c = chars[0];

            if (len == 0) return 0;

            for (int i = 1; i <= len; i++)
            {
                if(i < len && chars[i - 1] == chars[i] )
                {
                    repetition++;
                }
                else
                {
                    s += c;

                    if(repetition > 1)
                    {
                        s += repetition;
                    }

                    if(i < len)
                    {
                        c = chars[i];
                    }
                    repetition = 1;
                }
            }

            for(int i = 0; i < s.Length; i++)
            {
                chars[i] = s[i];
            }

            Console.WriteLine(s);

            return s.Length;
		}
	}
}


//ANTERIOR

//string s = "";
//int repetition = 0;

//if (chars.Length < 2)
//{
//    for (int i = 0; i < chars.Length; i++)
//    {
//        s += chars[i];
//    }
//    return s.Length;
//}

//for (int i = 1; i < chars.Length; i++)
//{
//    if (chars[i - 1] == chars[i])
//    {
//        repetition++;
//    }
//    else
//    {
//        s += chars[i - 1];
//        if (repetition > 0)
//        {
//            s += (repetition + 1).ToString();
//            repetition = 0;
//        }
//    }
//    if (i == chars.Length - 1)
//    {
//        s += chars[i];
//        if (repetition > 0)
//        {
//            s += (repetition + 1).ToString();
//        }
//    }
//}

//for (int i = 0; i < s.Length; i++)
//{
//    chars[i] = s[i];
//}
//return s.Length;