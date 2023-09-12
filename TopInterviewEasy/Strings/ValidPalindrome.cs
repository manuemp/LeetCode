using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class ValidPalindrome
	{
		public ValidPalindrome()
		{
		}

        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if ((char.IsLetter(s[i]) || char.IsDigit(s[i])) &&
                   (char.IsLetter(s[j]) || char.IsDigit(s[j])))
                {
                    if (char.ToLower(s[i]) != char.ToLower(s[j]))
                        return false;

                    i++;
                    j--;
                }
                else
                {
                    if (!char.IsLetter(s[i]) && !char.IsDigit(s[i]))
                        i++;
                    if (!char.IsLetter(s[j]) && !char.IsDigit(s[j]))
                        j--;
                }
            }

            return true;
        }
    }
}

