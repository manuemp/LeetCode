using System;
namespace LeetCode
{
	public class LongestSubarray
	{
		public LongestSubarray()
		{
		}

		public int longestSubarray(int[] nums)
		{
			int prev = 0, curr = 0, maxLarge = 0;

			for(int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 1)
				{
					curr++;
				}
				else
				{
					if (prev + curr > maxLarge) maxLarge = prev + curr;
					prev = curr;
					curr = 0;
				}
			}

            if (prev + curr > maxLarge) maxLarge = prev + curr;
			if (maxLarge == nums.Length) return maxLarge - 1;

			return maxLarge;

        }
	}
}


//MIO

//int l = 0;
//int maxLarge = 0, zeroCount = 0;

//if (!nums.Contains(0)) return nums.Length - 1;
//if (!nums.Contains(1)) return 0;

//for (int r = 0; r < nums.Length; r++)
//{
//    if (nums[r] == 0) zeroCount++;

//    maxLarge = Math.Max(r - l - 1, maxLarge);

//    if (zeroCount > 1)
//    {
//        while (nums[l] != 0) l++;
//        zeroCount--;
//        l++;
//    }
//}

//if (nums.Length - l - 1 > maxLarge) return nums.Length - l - 1;
//return maxLarge;


