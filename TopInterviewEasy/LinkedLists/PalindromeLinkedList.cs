using System;
namespace LeetCode.TopInterviewEasy.LinkedLists
{
	public class PalindromeLinkedList
	{
		public PalindromeLinkedList()
		{
		}

        public bool IsPalindrome(ListNode head)
        {
            ListNode end = head, middle = head, start = head;
            int count = 1;

            //Averiguo cuál es el final de la lista para saber cuántos elementos tiene
            while (end != null)
            {
                end = end.next;
                count++;
            }

            //Ir hasta la mitad de la lista
            for (int i = 0; i < count / 2; i++)
                middle = middle.next;

            //Revertir la lista desde la mitad hacia adelante
            middle = reverseList(middle);

            //Si la lista es un palíndromo, al revertirla desde la mitad
            //del inicio a la mitad y de la mitad al final tiene que ser igual
            //sino no es un palíndromo.
            while (middle != null)
            {
                if (middle.val != start.val) return false;
                middle = middle.next;
                start = start.next;
            }

            return true;
        }

        public ListNode reverseList(ListNode head)
        {
            ListNode curr = head, next = null, prev = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}

