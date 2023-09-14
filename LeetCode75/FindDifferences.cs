using System;
namespace LeetCode
{
	public class FindDifferences
	{
		public FindDifferences()
		{
		}

        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<IList<int>> answer = new List<IList<int>>();
            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!nums2.Contains(nums1[i]) && !n1.Contains(nums1[i])) n1.Add(nums1[i]);
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (!nums1.Contains(nums2[i]) && !n2.Contains(nums2[i])) n2.Add(nums2[i]);
            }

            answer.Add(n1);
            answer.Add(n2);

            return answer;

        }
    }
}

