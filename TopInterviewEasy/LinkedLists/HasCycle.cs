using System;
namespace LeetCode.TopInterviewEasy.LinkedLists
{
	public class HasCycle
	{
		public HasCycle()
		{
		}

        public bool hasCycle(ListNode head)
        {
            //Una lista enlazada es cíclica cuando el último nodo
            //apunta a un nodo dentro de la misma lista, en vez de apuntar a null

            if (head == null) return false;
            //Se usan dos punteros, slow, que avanza de a un nodo, y fast que avanza de a dos
            ListNode slow = head, fast = head.next;

            //Si fast o el nodo que sigue a fast es nulo, significa que la lista termina
            //que no es cíclica
            while (fast != null && fast.next != null)
            {
                //Como fast avanza más rápido que slow, si la lista es cíclica
                //en algún momento se van a encontrar
                if (fast == slow) return true;

                fast = fast.next.next;
                slow = slow.next;
            }

            return false;
        }
    }
}

