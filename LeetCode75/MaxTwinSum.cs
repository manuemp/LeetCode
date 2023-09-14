using System;
namespace LeetCode
{
	public class MaxTwinSum
	{
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public MaxTwinSum()
		{
		}

        public int PairSum(ListNode head)
        {
            int sum = 0, maxSum = 0, count = 0;
            ListNode p = head;
            List<int> nums = new List<int>();

            if (head == null) return 0;

            while (p != null)
            {
                nums.Add(p.val);
                p = p.next;
            }

            int len = nums.Count() - 1;

            while (len > count)
            {
                sum = nums[count] + nums[len];
                if (sum > maxSum) maxSum = sum;
                count++;
                len--;
            }
            return maxSum;
        }
    }
}

