using System;
namespace LeetCode.TopInterviewEasy.LinkedLists
{
	public class MergeTwoLinkedLists
	{
		public MergeTwoLinkedLists()
		{
		}

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode(-1);
            ListNode pointer = result;

            //Inicializo result en un nodo con valor -1, que va a ser auxiliar
            //simplemente para inicializar.
            //Pointer es igual a result, y es el puntero que se va a ir moviendo
            //a lo largo de la iteración para establecer los valores del resultado.
            //Esto es para guardar la primer posición de result y no perderla, ya que es lo
            //que hay que retornar.

            while (list1 != null && list2 != null)
            {
                //Si el nodo que corresponde agregar es de list1, lo agrego y
                //lo desvinculo de la lista, haciendo que la lista empiece ahora
                //en el nodo que antes era el segundo. 
                if (list1.val < list2.val)
                {
                    pointer.next = list1;
                    list1 = list1.next;
                }
                //Lo mismo para list2
                else
                {
                    pointer.next = list2;
                    list2 = list2.next;
                }
                //Avanza el puntero
                pointer = pointer.next;
            }

            //Si list1 no es null a esta altura, significa que terminé con list2
            //pero me quedó uno o más nodos pendientes de la list1. Entonces, lo que
            //siga va a ser todo lo que queda de list1. Caso contrario, lo mismo con list2
            if (list1 != null) pointer.next = list1;
            else if (list2 != null) pointer.next = list2;

            //Devuelvo result.next, ya que result empezaba con el nodo auxiliar con el que
            //se inicializó. 
            return result.next;
        }
    }
}

