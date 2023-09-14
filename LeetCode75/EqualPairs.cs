using System;
namespace LeetCode
{
	public class EqualPairs
	{
		public EqualPairs()
		{
		}

		public int equalPairs(int[][] grid)
		{
            int len = grid.Length;
            int[,] cols = new int[len, len];
            int count = 0, ans = 0;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++) cols[i, j] = grid[j][i];
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    count = 0;
                    for (int k = 0; k < len; k++)
                    {
                        if (grid[i][k] == cols[j, k]) count++;
                    }
                    if (count == len) ans++;
                }
            }

            return ans;
        }
	}
}

//De LEETCODE. Es mucho más rápido, aunque mucho menos eficiente en el uso de memoria
//public int equalPairs(int[][] grid)
//{
//    int len = grid.Length;
//    int count = 0;
//    int[][] cols = new int[len][];

//    for (int i = 0; i < len; i++) cols[i] = new int[len];

//    for (int i = 0; i < len; i++)
//    {
//        for (int j = 0; j < len; j++) cols[i][j] = grid[j][i];
//    }

//    for (int i = 0; i < len; i++)
//    {
//        for (int j = 0; j < len; j++)
//        {
//            if (Enumerable.SequenceEqual(grid[i], cols[j])) count++;
//        }
//    }

//    return count;
//}
