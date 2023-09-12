using System;
namespace LeetCode.BinaryTreeDFS
{
	public class GoodNodes
	{
		public GoodNodes()
		{
		}

		public int goodNodes(TreeNode root)
		{
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();

            goodNode(root, list, stack);
            return list.Count();
        }

        public void goodNode(TreeNode root, List<int> list, Stack<int> stack)
        {
            if (root == null) return;
            if (list.Count == 0 || root.val >= stack.Peek())
            {
                list.Add(root.val);
                stack.Push(root.val);
            }

            goodNode(root.left, list, stack);
            goodNode(root.right, list, stack);
            if (root.val == stack.Peek()) stack.Pop();
        }

        //Se dice que un nodo es "bueno" si en su camino hacia el root no hay nodos con valor mayor
        //La lista va a agregar los nodos buenos, y al mismo tiempo, un stack va a marcar cada recorrido
        //Cada vez que un nodo se quede sin poder ir a la izquierda o a la derecha se llega al último "if",
        //que chequea si ese nodo que estoy abandonando (porque voy a retornar al nodo del que vine recursivamente y no vuelvo más a este)
        //forma parte del stack. En ese caso, lo saco del stack pero lo dejo en la lista, para que el stack siempre mantenga un seguimiento
        //de los nodos que componen el camino actual.
        //Cuando se termine por completo la parte izquierda del árbol (desde el left del root hasta abajo), siguiendo este razonamiento,
        //se van a haber borrado todos los nodos del stack menos el último, que es el root y siempre está presente porque forma
        //parte del camino de cualquier otro nodo, porque es el destino de todos los nodos.
        //De esta forma, al terminar la recursión, voy a tener la lista con todos los nodos buenos sin que se interpongan unos con otros
        //cuando no pertenezcan al mismo recorrido.
        //Lo que devuelvo es entonces la cantidad de elementos que componen esa lista.

    }
}

