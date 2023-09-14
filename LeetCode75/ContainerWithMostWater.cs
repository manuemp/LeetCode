using System;
namespace LeetCode
{
	public class ContainerWithMostWater
	{
		public ContainerWithMostWater()
		{
		}

		public int MaxArea(int[] height)
		{
            int maxArea = 0, area;
            int i = 0, j = height.Length - 1;

            while (i != j)
            {
                area = Math.Min(height[i], height[j]) * (j - i);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[i] < height[j])
                {
                    i++;
                    continue;
                }
                else if (height[j] < height[i])
                {
                    j--;
                    continue;
                }
                else
                {
                    i++;
                    continue;
                }
            }
            return maxArea;
		}
	}
}

