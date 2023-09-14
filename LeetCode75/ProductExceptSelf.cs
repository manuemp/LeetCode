using System;
namespace LeetCode
{
	public class ProductExceptSelf
	{
		public ProductExceptSelf()
		{
		}

		public int[] productExceptSelf(int[] nums)
		{
            int[] prodLeft = new int[nums.Length];
            int[] prodRight = new int[nums.Length];
            int[] result = new int[nums.Length];

            prodLeft[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                prodLeft[i] = prodLeft[i - 1] * nums[i - 1];
            }

            prodRight[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                prodRight[i] = prodRight[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prodLeft[i] * prodRight[i];
            }

            return result;
        }
	}
}

