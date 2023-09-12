using System;
namespace LeetCode.TopInterviewEasy.Strings
{
	public class LongestCommonPrefix
	{
		public LongestCommonPrefix()
		{
		}

        public string longestCommonPrefix(string[] strs)
        {
            //Busco primero la menor longitud entre los strings para no
            //irme de rango en la búsqueda del prefijo.
            int len = strs.Min(s => s.Length);
            string pref = "";

            for (int i = 0; i < len; i++)
            {
                char aux = strs[0][i];
                foreach (string s in strs)
                    if (s[i] != aux) return pref;

                pref += aux;
            }
            return pref;
        }
    }
}

