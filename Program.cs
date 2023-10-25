// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using LeetCode.Pruebas;
using LeetCode.TopInterviewEasy.Strings;
using LeetCode.TopInterviewEasy.LinkedLists;

namespace LeetCode
{

    class Program
    {

        static void Main(string[] args)
        {
            //1, 2, 3, 0, 0, 0
            //2, 5, 6

            //4, 5, 6, 0, 0, 0
            //1, 2, 3


            //int[] nums1 = { 1, 2, 3, 0, 0, 0};
            //int[] nums2 = { 2, 5, 6 };

            //Merge(nums1, 3, nums2, 3);

            //foreach (int num in nums1) Console.Write(num + " ");

            Console.WriteLine(true || false);
            Console.ReadKey();

        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len = nums1.Length - 1;
            int zeroes = n;

            while (zeroes > 0)
            {
                if(m > 0)
                {
                    if (nums1[m - 1] < nums2[n - 1])
                    {
                        nums1[len] = nums2[n - 1];
                        n--;
                        zeroes--;
                    }
                    else
                    {
                        nums1[len] = nums1[m-1];
                        nums1[m-1] = 0;
                        m--;
                    }
                    len--;
                }
                else
                {
                    nums1[len] = nums2[n - 1];
                    n--;
                    zeroes--;
                    len--;
                }
            }
        }
    }

}


//public class Solution
//{
//    public TreeNode SortedArrayToBST(int[] nums)
//    {
//        if (nums.Length == 0) return null;
//        if (nums.Length == 1) return new TreeNode(nums[0], null, null);
//        var mid = nums.Length / 2;
//        return new TreeNode(
//            nums[mid],
//            SortedArrayToBST(nums.Take(mid).ToArray()),
//            SortedArrayToBST(nums.Skip(mid + 1).ToArray())
//        );
//    }
//}







