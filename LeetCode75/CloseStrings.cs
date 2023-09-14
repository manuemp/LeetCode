using System;
namespace LeetCode
{
	public class CloseStrings
	{
		public CloseStrings()
		{
		}

		public bool closeStrings(string word1, string word2)
		{
			//Primero se hace un array de 26 enteros, todos ceros.
			//Con este array voy a anotar la repetición de cada letra reperesentada
			//en un índice. Este array después sirve para ver si las repeticiones
			//de las letras son iguales para que funcione el algoritmo.

			int[] arr1 = new int[26];
            int[] arr2 = new int[26];

			foreach(char c in word1)
			{
				//Las letras se pueden restar, y así obtengo el índice
				//que corresponde al caracter de la palabra
				arr1[c - 'a']++;
			}

			foreach(char c in word2)
			{
				arr2[c - 'a']++;
			}

			//Ahora corroboro que las letras que tengan repeticiones
			//sean las mismas en ambos arrays, o sea, que ambos strings
			//estén compuestos por las mismas letras, sin importar
			//las repeticiones de cada una en específico.
			for(int i = 0; i < 26; i++)
			{
				if (arr1[i] == 0 && arr2[i] > 0 ||
					arr2[i] == 0 && arr1[i] > 0)
				{
					return false;
				}
			}

			//Ahora los arrays se ordenan porque se prioriza la cantidad de repeticiones
			//En este caso los índices dejan de representar las letras porque se altera el orden
			//Pero para que la función sea verdadera, tiene que haber la misma cantidad de
			//repeticiones por letra en ambos arrays (no importa que sean la misma o diferente letra) 
			Array.Sort(arr1);
			Array.Sort(arr2);

			for(int i = 0; i < 26; i++)
			{
				if (arr1[i] != arr2[i]) return false;
			}

			return true;
        }
    }
}


//LENTO, CONSUME MEMORIA

//Dictionary<char, int> word1Dict = new Dictionary<char, int>();
//Dictionary<char, int> word2Dict = new Dictionary<char, int>();
//string keys1 = "", keys2 = "", count1 = "", count2 = "";

//if (word1.Length != word2.Length) return false;

//foreach (char c in word1)
//{
//    if (!word1Dict.ContainsKey(c))
//    {
//        word1Dict.Add(c, word1.Where(x => x == c).Count());
//    }
//}

//foreach (char c in word1)
//{
//    if (!word2Dict.ContainsKey(c))
//    {
//        word2Dict.Add(c, word2.Where(x => x == c).Count());
//    }
//}

//foreach (KeyValuePair<char, int> x in word1Dict)
//{
//    keys1 += x.Key;
//    count1 += x.Value;
//}

//foreach (KeyValuePair<char, int> x in word2Dict)
//{
//    keys2 += x.Key;
//    count2 += x.Value;
//}

//keys1 = string.Concat(keys1.OrderBy(c => c));
//keys2 = string.Concat(keys2.OrderBy(c => c));
//count1 = string.Concat(count1.OrderBy(c => c));
//count2 = string.Concat(count2.OrderBy(c => c));

//if (keys1 == keys2 && count1 == count2) return true;

//return false;