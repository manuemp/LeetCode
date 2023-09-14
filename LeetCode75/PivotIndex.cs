using System;
namespace LeetCode
{
	public class PivotIndex
	{
		public PivotIndex()
		{
		}

		public int pivotIndex(int[] nums)
		{
            int sum = 0, left = 0;

            for (int i = 0; i < nums.Length; i++) sum += nums[i];

            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
                if (left == sum) return i;
                left += nums[i];
            }

            return -1;
        }
	}
}

