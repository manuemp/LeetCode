using System;
namespace LeetCode
{
	public class LongestOnes
	{
		public LongestOnes()
		{                                          
		}

		public int longestOnes(int[] nums, int k)
		{
            int r = 0, l = 0, count = 0, large = 0, maxLarge = 0;

            while (r <= nums.Length - 1)
            {
                if (nums[r] == 0) count++;

                if (count <= k) r++;
                else
                {
                    while (count > k)
                    {
                        if (nums[l] == 0)
                        {
                            count--;
                            l++;
                        }
                        else l++;
                    }
                    r++;
                }
                large = r - l;
                if (large > maxLarge) maxLarge = large;
            }
            return maxLarge;
        }
	}
}

