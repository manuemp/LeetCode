using System;
namespace LeetCode.Trees_General
{
	public class MinDepth
	{
		public MinDepth()
		{
		}

        //BFS. Caso de Level Order Traversal.
        //Para saber la profundidad mínima de un árbol una opción podría
        //ser visitar cada nivel del árbol y ver si existe un nodo que sea una hoja.
        //Para eso uso una fila, que se va a encargar de almacenar en orden todos los
        //nodos de cada nivel, y con un loop verifico si alguno de los nodos de ese
        //nivel es una hoja. La primer hoja encontrada indicará la profundidad mínima del árbol

        public int minDepth(TreeNode root)
        {
            //Si el nodo raíz es nulo, devuelvo 0
            if (root == null) return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            int level = 1;

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int len = queue.Count;
                //Hago un loop que itere por cada nodo del nivel
                for (int i = 0; i < len; i++)
                {
                    TreeNode aux = queue.Dequeue();
                    if (aux != null)
                    {
                        //Si el nodo es una hoja termino la función y devuelvo level
                        if (aux.left == null && aux.right == null) return level;
                        //Sino agrego a la fila los hijos del nodo para el siguiente nivel
                        queue.Enqueue(aux.left);
                        queue.Enqueue(aux.right);
                    }
                }
                level++;
            }
            return level;
        }
    }
}

