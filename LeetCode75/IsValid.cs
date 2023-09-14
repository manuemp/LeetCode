using System;
namespace LeetCode
{
	public class IsValid
	{
		public IsValid()
		{
		}

		public bool isValid(string s)
		{
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[') stack.Push(s[i]);
                else
                {
                    if (stack.Count == 0) return false;

                    if (stack.Peek() == '(')
                    {
                        if (s[i] == ')') stack.Pop();
                        else return false;
                    }
                    else if (stack.Peek() == '{')
                    {
                        if (s[i] == '}') stack.Pop();
                        else return false;
                    }
                    else if (stack.Peek() == '[')
                    {
                        if (s[i] == ']') stack.Pop();
                        else return false;
                    }
                }
            }

            if (stack.Count == 0) return true;
            return false;
        }
	}
}

