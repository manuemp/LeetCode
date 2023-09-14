using System;
namespace LeetCode
{
	public class MaxVowels
	{
		public MaxVowels()
		{
		}

		public int maxVowels(string s, int k)
		{
			char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
			int count = 0, maxCount = 0;

			foreach(char l in s.Substring(0, k))
			{
				if (vowels.Contains(l)) count++;
			}

			maxCount = count;

			for(int i = k; i < s.Length && count != k; i++)
			{
				if (vowels.Contains(s[i - k]))
				{
					if (!vowels.Contains(s[i]))
					{
						count--;
					}
				}
				else
				{
					if (vowels.Contains(s[i]))
					{
						count++;
					}
				}
				if (count > maxCount) maxCount = count;
			}
			return maxCount;
		}
	}
}


//char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
//int count = 0, maxCount = 0;

//for (int i = 0; i <= s.Length - k; i++)
//{
//    count = 0;
//    foreach (char l in s.Substring(i, k))
//    {
//        if (vowels.Contains(l))
//        {
//            count++;
//        }

//        if (count > maxCount)
//        {
//            maxCount = count;
//            if (maxCount == k)
//            {
//                return maxCount;
//            }
//        }
//    }
//}
//return maxCount;