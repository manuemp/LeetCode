using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class MoveZeroes2
	{
		public MoveZeroes2()
		{
		}

        public void moveZeroes(int[] nums)
        {
            int zero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[zero], nums[i]) = (nums[i], nums[zero]);
                    zero++;
                }
            }
        }
    }
}

