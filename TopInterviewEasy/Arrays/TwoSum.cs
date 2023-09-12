using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class TwoSum
	{
		public TwoSum()
		{
		}

        public int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int diff;

            for (int i = 0; i < nums.Length; i++)
            {
                //Por cada número voy a calcular su diferencia con
                //target. Esa diferencia será el número que necesito
                //que esté en el diccionario. Si no está, agrego al
                //diccionario el número (no la diferencia).
                diff = target - nums[i];
                if (dic.ContainsKey(diff))
                {
                    return new int[] { dic[diff], i };
                }
                //No lo agrego con Add porque no permite agregar claves
                //iguales. Si la clave existe la sobreescribe, sino
                //lo agrega
                dic[nums[i]] = i;
            }

            //Si no encuentra nada devuelve null. Aunque la idea del ejercicio
            //es que siempre encuentre.
            return null;
        }
    }
}

//int[] solution = new int[2];
//bool found = false;
//int sum;

//for (int i = 0; i < nums.Length; i++)
//{
//    sum = target - nums[i];
//    for (int j = i + 1; j < nums.Length; j++)
//    {
//        if (nums[j] == sum)
//        {
//            solution[0] = i;
//            solution[1] = j;
//            found = true;
//            break;
//        }
//    }
//    if (found) break;
//}

//return solution;