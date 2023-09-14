using System;
using LeetCode;

namespace LeetCode
{
	public class OddEvenLinkedList
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

        public OddEvenLinkedList()
		{

		}

        public ListNode OddEvenList(ListNode head)
        {
            //Si no hay ningún o solo un registro devuelvo la cabecera de lista
            if (head == null || head.next == null) return head;

            ListNode odd = head;
            ListNode even = head.next;
            ListNode p = even.next;
            ListNode evenHead = head.next;
            bool isOdd = true;


            while (p != null)
            {
                if (isOdd)
                {
                    //El nodo siguiente del último impar va a ser la ubicación actual del puntero
                    //que justamente es el último impar encontrado que todavía no se agregó
                    odd.next = p;
                    //Una vez agregado, el impar pasa a ser el puntero para poder cambiar el
                    //nodo next una vez que tenga al puntero nuevamente ubicado en un nodo impar
                    odd = p;
                }
                else
                {
                    //La misma lógica que arriba pero con pares
                    even.next = p;
                    even = p;
                }

                //Avanza el puntero
                p = p.next;
                //El valor del booleano es su negación por cada vuelta, lo que quiere decir
                //que una vuelta será par y la próxima impar, y así sucesivamente
                isOdd = !isOdd;
            }

            //El último impar apuntará al primer par
            odd.next = evenHead;
            //El último par apunta a null para cerrar la lista
            even.next = null;
            return head;
        }
    }
}





//MI SOLUCION (FUNCIONA)

//if (head == null || head.next == null) return head;

//ListNode odd = head;
//ListNode p = head;
//ListNode even = head.next;
//ListNode evenHead = head.next;
//int count = 0;

//while (p != null)
//{
//    if (count < 2)
//    {
//        count++;
//        p = p.next;
//        continue;
//    }
//    if (count % 2 == 0)
//    {
//        odd.next = p;
//        odd = p;
//    }
//    else
//    {
//        even.next = p;
//        even = p;
//    }

//    p = p.next;
//    count++;
//}

//odd.next = evenHead;
//even.next = null;
//return head;