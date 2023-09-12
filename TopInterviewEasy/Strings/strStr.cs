using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class strStr
	{
		public strStr()
		{
		}

        public int StrStr(string haystack, string needle)
        {
            int len1 = haystack.Length;
            int len2 = needle.Length;

            for (int i = 0; i <= len1 - len2; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (haystack.Substring(i, len2) == needle) return i;
                }
            }
            return -1;
        }
    }
}

