using System;
namespace LeetCode.TopInterviewEasy.LinkedLists
{
	public class DeleteNode
	{
		public DeleteNode()
		{
		}

        public void deleteNode(ListNode node)
        {
            //En el ejercicio me aseguran que el nodo que hay que eliminar no va a ser
            //el último, pero también me dicen que no me van a dar el head de la lista
            //sino que solamente me dan el nodo a eliminar.

            //La forma de eliminar el nodo indicado es que este tome el valor del
            //nodo siguiente, y que el siguiente sea desvinculado de la lista para evitar
            //un nodo repetido.

            //node ahora toma el valor del siguiente, y en vez de apuntar a este, apunta
            //al de más adelante, al 'siguiente del siguiente'. De esta forma se desvincula
            //al nodo siguiente del original, y el valor del original no existe más.

            node.val = node.next.val;
            node.next = node.next.next;
        }

    }
}

