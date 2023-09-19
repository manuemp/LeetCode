using System;
namespace LeetCode.TopInterviewEasy.Trees
{
	public class SortedArrayToBST
	{
		public SortedArrayToBST()
		{
		}

        //Para crear un árbol de búsqueda binaria a partir de un array ordenado
        //el root siempre va a ser el número del medio del array. Los que estén
        //a su derecha serán los nodos del subárbol derecho (mayores que root en valor)
        //y los que estén a la izquierda, los del subárbol izquierdo.

        //La forma de crear un árbol a partir de un array es mediante recursividad.
        //Por cada nodo que cree, el hijo izquierdo y derecho se calcularán llamando
        //nuevamente a la función para que determine si hay que crear un nodo, o si
        //ya no es posible (devolviendo null).

        //La función consta de dos parámetros: left y right. Left hace referencia
        //al índice donde comenzará el subarray correspondiente, y left el índice donde terminará.

        //La creación de un nuevo nodo no será posible cuando left > right, porque
        //indica que el índice donde comienza la partición del array excede al índice
        //donde tiene que terminar, por lo que ya no es posible buscar un nodo intermedio.
        //Esto indica que el root era una hoja y terminó el árbol.

        //La variable 'mid' hace referencia al índice intermedio entre left y right,
        //que será el root de los próximos nodos en las siguientes llamadas a función.

        //Cuando vaya por izquierda, left siempre será 0 y right un nodo antes del medio
        //del array original.
        //Cuando vaya por la derecha, right siempre es el último índice y left un nodo
        //mayor a la mitad original del array.
        //En ambos casos, mid calcula con precisión la el índice intermedio de ese subarray.

        public TreeNode sortedArrayToBST(int[] nums)
        {
            return makeTree(0, nums.Length - 1);

            //makeTree se declara como una función anidada para poder usar
            //el array nums sin necesidad de colocar un parámetro adicional.
            TreeNode makeTree(int left, int right)
            {

                if (left > right) return null;

                int mid = (left + right) / 2;

                return new TreeNode(nums[mid],
                                    makeTree(left, mid - 1),
                                    makeTree(mid + 1, right));
            }
        }
    }
}

