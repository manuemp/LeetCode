using System;
namespace LeetCode.Trees
{
	public class PathSum
	{
		public PathSum()
		{
		}

        //Desde arriba hacia abajo, por cada nodo, voy a verificar que existan caminos
        //en los cuales se llegue a la suma indicada.
        //Si root == null significa que me pasé, o sea, que ningún nodo en ese camino
        //generó la suma que estoy buscando.
        //Si llego a una hoja y la resta entre el valor buscado y el valor de mi nodo es 0
        //significa que se encontró un camino posible, y retorno true.
        //Caso contrario, no estoy en una hoja y tengo que buscar, para ese nodo, tanto
        //por izquierda como por derecha si existe un camino.

        //Ese return llama dos veces a la función, con un operador ||. Esto es porque
        // true || false devuelve siempre true, entonces si el camino al que llegué
        //es el buscado, en caso de que el del otro nodo me de falso no va a superponer
        //el resultado, y todos los resultados de la pila de funciones de ahí en adelante
        //van a ser true.

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null && targetSum - root.val == 0)
                return true;

            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }


 
    }
}

