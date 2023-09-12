using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class FirstUniqueCharacter
	{
		public FirstUniqueCharacter()
		{
		}

        public int firstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!dict.ContainsKey(c)) dict.Add(c, 1);
                else dict[c]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1) return i;
            }
            return -1;
        }
    }
}

//LEET CODE

//[1] Usando LastIndexOf. Si el último índice de una letra es igual al primero
//    indica que hay solamente una repetición de ese caracter
//    A la primera que se encuentre uno que cumpla esa condición, se devuelve su índice

//public int firstUniqChar(string s)
//{
//    Dictionary<char, int> dict = new Dictionary<char, int>();

//    if (s.Length == 1) return 0;

//    for(int i = 0; i < s.Length; i++)
//    {
//        if (s.LastIndexOf(s[i]) == s.IndexOf(s[i]))
//            return i;
//    }
//    return -1;
//}

// [2] Usando array alfabético

// Es igual al caso anterior, solamente que se guarda el índice de
// cada aparición en un array ordenado alfabéticamente.
// La resta de cada caracter con la letra 'a', que es la primera del
// alfabeto, me da su posición en el array. De esta forma, recorro
// el string y me fijo el primer caracter que tenga valor 1 en el array.

//public int firstUniqChar(string s)
//{
//    int[] count = new int[26];
//    foreach (char c in s)
//        count[c - 'a']++;

//    int index = 0;
//    foreach(char c in s)
//    {
//        if (count[c - 'a'] == 1)
//            return index;
//        index++;
//    }

//    return -1;
//}