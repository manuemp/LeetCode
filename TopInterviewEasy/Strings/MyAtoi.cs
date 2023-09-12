using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class MyAtoi
	{
		public MyAtoi()
		{
		}

        public int myAtoi(string s)
        {
            string n = "";
            int num;
            bool flag = false;

            //Elimino espacios al principio
            s = s.Trim();
            foreach (char c in s)
            {
                //La primera iteración puede ser un número o un signo
                if (!flag)
                {
                    if (c == '-' || c == '+' || char.IsDigit(c))
                    {
                        n += c;
                        flag = true;
                        continue;
                    }
                    else break;
                }

                //Pasada la primera iteración, solamente aceptar números
                if (!char.IsDigit(c)) break;
                n += c;
            }

            //Si solamente se pasó la primera iteración (o ninguna)
            if (n == "" || n == "+" || n == "-") return 0;

            if (!int.TryParse(n, out num))
            {
                if (n[0] == '-') return int.MinValue;
                else return int.MaxValue;
            }

            return num;
        }
    }
}

