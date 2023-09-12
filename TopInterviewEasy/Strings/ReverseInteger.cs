using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class ReverseInteger
	{
		public ReverseInteger()
		{
		}

        public int reverseInteger(int x)
        {
            char[] num = x.ToString().ToCharArray();
            int len = num.Length, start = 0;
            bool validate;
            char aux;

            if (x < 0) start++;

            for (int i = 0; i < len / 2; i++, start++)
            {
                aux = num[start];
                num[start] = num[len - 1 - i];
                num[len - 1 - i] = aux;
            }

            validate = int.TryParse(num, out x);
            if (!validate) return 0;
            return x;
        }
    }
}

