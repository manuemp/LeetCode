using System;
namespace LeetCode
{
	public class UniqueOccurrences
	{
		public UniqueOccurrences()
		{
		}

		public bool uniqueOccurrences(int[] arr)
		{
            Dictionary<int, int> arrDic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arrDic.ContainsKey(arr[i]))
                    arrDic.Add(arr[i], arr.Where(x => x == arr[i]).Count());
            }

            foreach (KeyValuePair<int, int> k in arrDic)
            {
                int counter = arrDic.Where(x => x.Value == k.Value).Count();
                if (counter > 1) return false;
            }

            return true;
		}
	}
}

