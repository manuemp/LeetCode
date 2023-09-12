using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class ReverseString
	{
		public ReverseString()
		{
		}

        public void reverseString(char[] s)
        {
            int len = s.Length;
            char aux;

            for (int i = 0; i < len / 2; i++)
            {
                aux = s[i];
                s[i] = s[len - 1 - i];
                s[len - 1 - i] = aux;
            }
        }
    }
}

