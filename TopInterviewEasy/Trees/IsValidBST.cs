using System;
namespace LeetCode.TopInterviewEasy.Trees
{

    //Un árbol binario es válido cuando todos los subárboles por la izquierda
    //de cada nodo contienen valores menores al valor de dicho nodo, y todos
    //los subárboles por la derecha de cada nodo contienen valores mayores a su valor

    //Para este caso lo que se hace es una función recursiva que guarda el valor del
    //último a la derecha visitado y el último a la izquierda, y los compara con el valor
    //del nodo actual.

    //La parte más importante es el último return, en el que se entra en recursión y
    //se compara con el operador lógico 'and' (&&) los resultados de cada vuelta.
    //La importancia que tiene es que si una función devuelve false, siempre que se haga
    //la comparación con and voy a obtener false, entonces se guarda el resultado en
    //caso de que haya un nodo que no cumpla con la premisa de un árbol válido.

    //Si el nodo es null (llego al final del árbol), se devuelve true porque
    //al llegar al un nodo nulo no tengo con qué compararlo, y como a priori no sé si el
    //árbol es válido o no, devuelvo true que no me va a afectar en la comparación &&.

    //Si el valor del nodo no es al mismo tiempo mayor que el de la izquierda y menor que
    //el de la derecha, el árbol no es valido y retorno false.

	public class IsValidBST
	{
		public IsValidBST()
		{
		}

		public bool isValidBST(TreeNode root)
		{
		    return valid(root, long.MinValue, long.MaxValue);
		}
		
		public bool valid(TreeNode node, long left, long right)
		{
		    if (node == null) return true;
		
		    if (!(node.val < right && node.val > left)) return false;
		
		    return (valid(node.left, left, node.val) &&
			   valid(node.right, node.val, right));
		}
    }
}

//Si la lógica del algoritmo InOrder es visitar los nodos de un BinarySearch Tree
//en forma ordenada, otra solución podría ser agregar a una lista cada valor de los nodos
//visitados mediante el algoritmo InOrder. En caso de que la lista no esté ordenada
//de menor a mayor, entonces el árbol no es válido.
//La solución es correcta, es razonablemente rápida, pero usa más memoria que la anterior

//public bool IsValidBST(TreeNode root)
//{
//    List<int> list = new List<int>();

//    inOrder(root, list);

//    for (int i = 0; i < list.Count - 1; i++)
//        if (list[i] >= list[i + 1]) return false;

//    return true;
//}

//public void inOrder(TreeNode root, List<int> list)
//{
//    if (root == null) return;

//    inOrder(root.left, list);
//    list.Add(root.val);
//    inOrder(root.right, list);

//}




//SOLUCION DE LEETCODE CON STACK

//public class Solution
//{
//    public bool IsValidBST(TreeNode root)
//    {
//        if (root == null)
//        {
//            return true;
//        }

//        TreeNode current = root;
//        Stack<TreeNode> stack = new Stack<TreeNode>();
//        int? prev = null;
//        while (current != null || stack.Count > 0)
//        {
//            while (current != null)
//            {
//                stack.Push(current);
//                current = current.left;
//            }

//            current = stack.Pop();
//            if (prev != null && prev >= current.val)
//            {
//                return false;
//            }

//            prev = current.val;
//            current = current.right;
//        }

//        return true;
//    }
//}




