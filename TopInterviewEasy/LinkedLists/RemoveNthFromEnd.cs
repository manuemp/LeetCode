using System;
namespace LeetCode.TopInterviewEasy.LinkedLists
{
	public class RemoveNthFromEnd
	{
		public RemoveNthFromEnd()
		{
		}

        public ListNode removeNthFromEnd(ListNode head, int n)
        {
            ListNode p = head, prev = head;
            int len = 0, count = 0, target;

            //len me va a dar la longitud total de la lista
            while (p != null)
            {
                p = p.next;
                len++;
            }

            //target me va a dar la posición del nodo a eliminar
            //si target es 0, significa que el nodo que hay que eliminar
            //es el primero, entonces retorno el siguiente a head.
            target = len - n;
            if (target == 0) return head.next;

            //si hay que eliminar un nodo que no sea el primero, reinicio p (no se si es una buena práctica)
            //mientras que count -0- sea menor que target, p avanza.
            //una vez que termina el while, llegué con p al nodo a eliminar.
            //prev ahora no apunta más a p, sino que al siguiente de p, o sea, lo desliga de la lista

            p = head;
            while (count < target)
            {
                prev = p;
                p = p.next;
                count++;
            }
            prev.next = prev.next.next;

            //devuelvo la lista sin el nodo indicado
            return head;
        }
    }
}

//Solucion de LEETCODE

//public class Solution
//{
//    public ListNode RemoveNthFromEnd(ListNode head, int n)
//    {
        //var first = head;
        //var second = head;

        //for (int i = 0; i < n; i++)
        //{
        //    first = first.next;
        //}

        //if (first == null)
        //{
        //    return head.next;
        //}

        //while (first.next != null)
        //{
        //    first = first.next;
        //    second = second.next;
        //}

        //second.next = second.next.next;

        //return head;
//    }
//}