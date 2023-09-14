using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
	public class DecodeString
	{
		public DecodeString()
		{
        }

        //string s = "10[leetcode]";
        //"3[a]2[bc]"
        //"3[a2[c]]"
        //"2[abc]3[cd]ef"
        //"abc3[cd]xyz"
        //"3[z]2[2[y]pq4[2[jk]e1[f]]]ef"

        //NO PASA TODOS LOS TESTS...

        public string decodeString(string s)
		{
            Stack<char> partial = new Stack<char>();
            Stack<string> response = new Stack<string>();
            Stack<int> nums = new Stack<int>();
            string aux = "";
            int count = 0, brackets = 0;
            bool flag = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i])) aux += s[i];
                else
                {
                    if (aux.Length > 0) nums.Push(int.Parse(aux));
                    aux = "";
                }
            }

            aux = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '[' || s[i] == ']')
                {
                    brackets++;
                    flag = true;
                    continue;
                }

                if (char.IsDigit(s[i]))
                {
                    i -= nums.Peek().ToString().Length - 1;
                    count = nums.Pop();
                    if (brackets % 2 == 0)
                    {
                        while (count > 0)
                        {
                            foreach (char c in partial) aux += c;
                            count--;
                        }
                        response.Push(aux);
                        partial.Clear();
                        aux = "";
                        flag = false;
                    }
                    else
                    {
                        while (count > 0)
                        {
                            foreach (char c in partial) aux += c;
                            count--;
                        }
                        partial.Clear();
                        foreach (char c in aux) partial.Push(c);
                        aux = "";
                    }
                }
                else
                {
                    if (flag) partial.Push(s[i]);
                    if (!flag && brackets % 2 == 0) response.Push(s[i].ToString());
                }
            }

            aux = "";
            foreach (string str in response) aux += str;
            return aux;
        }
	}
}




//Stack<char> partial = new Stack<char>();
//Stack<string> response = new Stack<string>();


//string aux = "";
//int count = 0, brackets = 0;
//bool flag = false;

//for (int i = s.Length - 1; i >= 0; i--)
//{
//    if (s[i] == '[' || s[i] == ']')
//    {
//        brackets++;
//        flag = true;
//        continue;
//    }

//    if (char.IsDigit(s[i]))
//    {
//        count = s[i] - '0';
//        if (brackets % 2 == 0)
//        {
//            while (count > 0)
//            {
//                foreach (char c in partial) aux += c;
//                count--;
//            }
//            response.Push(aux);
//            partial.Clear();
//            aux = "";
//            flag = false;
//        }
//        else
//        {
//            while (count > 0)
//            {
//                foreach (char c in partial) aux += c;
//                count--;
//            }
//            partial.Clear();
//            foreach (char c in aux) partial.Push(c);
//            aux = "";
//        }
//    }
//    else
//    {
//        if (flag) partial.Push(s[i]);
//        if (!flag && brackets % 2 == 0) response.Push(s[i].ToString());
//    }
//}

//aux = "";
//foreach (string str in response) aux += str;
//return aux;

