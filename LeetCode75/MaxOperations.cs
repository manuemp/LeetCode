using System;
namespace LeetCode
{
	public class MaxOperations
	{
		public MaxOperations()
		{
		}

		public int maxOperations(int[] nums, int k)
		{
            int count = 0, i = 0, j = nums.Length - 1, sum;

            Array.Sort(nums);
            Array.Reverse(nums);

            while (i < j)
            {
                if (nums[i] >= k)
                {
                    i++;
                    continue;
                }

                sum = nums[i] + nums[j];

                if (sum == k)
                {
                    i++;
                    j--;
                    count++;
                    continue;
                }

                if (sum < k)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
	}
}


//int count = 0, i = 0;
//int lastIndex = nums.Length - 1;
//int j = lastIndex;

//while (i < lastIndex)
//{
//    if (nums[i] >= k || i == j)
//    {
//        i++;
//        j = lastIndex;
//        continue;
//    }

//    if (nums[lastIndex] >= k)
//    {
//        lastIndex--;
//        j = lastIndex;
//        continue;
//    }

//    if (nums[i] + nums[j] != k)
//    {
//        j--;
//        continue;
//    }

//    if (nums[i] + nums[j] == k)
//    {
//        (nums[i + 1], nums[j]) = (nums[j], nums[i + 1]);
//        count++;
//        i += 2;
//        j = nums.Length - 1;
//    }
//}
//return count;