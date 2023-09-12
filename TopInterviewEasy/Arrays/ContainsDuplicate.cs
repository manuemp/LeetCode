using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class ContainsDuplicate
	{
		public ContainsDuplicate()
		{
		}

		public bool containsDuplicate(int[] nums)
		{
			Array.Sort(nums);
			for (int i = 0; i < nums.Length - 1; i++)
			{
				if (nums[i + 1] == nums[i]) return true;
			}
			return false;
        }
	}
}

