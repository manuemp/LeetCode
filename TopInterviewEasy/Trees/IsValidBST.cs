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

    //Si el nodo es null, o sea, llego a una rama del árbol, se devuelve true porque
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





