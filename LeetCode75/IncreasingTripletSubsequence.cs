using System;
using System.Reflection;

namespace LeetCode
{
	public class IncreasingTripletSubsequence
	{
		public IncreasingTripletSubsequence()
		{
		}

		public bool increasingTriplet(int[] nums)
		{
			int a, b, c;

			if (nums.Length < 2) return false;

			b = nums[1];
			a = nums[0];
			c = nums[nums.Length - 1];
			
			for(int i = 1; i < nums.Length - 1; i++)
			{
				b = nums[i];

				if (nums[i-1] < b) a = nums[i - 1];

				if (nums[i+1] > b && nums[i + 1] > c) c = nums[i + 1];

                if (a < b && b < c)
				{
                    Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
                    return true;
				}
            }

			Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
			return false;
		}
	}
}
