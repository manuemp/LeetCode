using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class ValidAnagram
	{
		public ValidAnagram()
		{
		}

        public bool IsAnagram(string s, string t)
        {
            int[] chars1 = new int[26], chars2 = new int[26];
            int len1 = s.Length, len2 = t.Length;

            bool valid = false;

            if (len1 != len2) return false;
            if (len1 == 1 && len2 == 1 && s[0] == t[0]) return true;

            for (int i = 0; i < len1; i++)
            {
                if (s[i] != t[i]) valid = true;
                chars1[s[i] - 'a']++;
                chars2[t[i] - 'a']++;
            }

            if (!valid) return false;

            for (int i = 0; i < 26; i++)
            {
                if (chars1[i] != chars2[i]) return false;
            }

            return true;
        }
    }
}

