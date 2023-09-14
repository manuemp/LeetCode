using System;
namespace LeetCode
{
	public class RemoveStars
	{
		public RemoveStars()
		{
		}

		public string removeStars(string s)
		{
            //Usando Stack el algoritmo es mucho más eficiente
            Stack<char> charStack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '*') charStack.Pop();
                else charStack.Push(c);
            }

            // Como la pila pone primero al último elemento agregado, el string
            // va a estar al revés. Hay que crear un array de chars para poder
            // colocar cada caracter de la pila en el índice más a la derecha del array
            char[] ans = new char[charStack.Count()];

            // Por cada vuelta del loop hago un Pop(), lo que achica el Count
            // hasta que sea 0.
            while (charStack.Count() > 0)
            {
                ans[charStack.Count() - 1] = charStack.Pop();
            }
            s = new string(ans);

            return s;
        }

	}
}


//Sin usar Stack. Funciona, pero es muy lento y demanda mucha memoria
//string ans = "";
//int starCounter = 0;

//for (int i = s.Length - 1; i >= 0; i--)
//{
//    if (s[i] == '*') starCounter++;
//    else
//    {
//        if (starCounter > 0)
//        {
//            starCounter--;
//            continue;
//        }
//        ans += s[i];
//    }
//}

//s = "";

//for (int i = ans.Length - 1; i >= 0; i--)
//    s += ans[i];

//return s;

