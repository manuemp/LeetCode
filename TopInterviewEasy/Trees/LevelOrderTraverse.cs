using System;
namespace LeetCode.TopInterviewEasy.Trees
{
	public class LevelOrderTraverse
	{
		public LevelOrderTraverse()
		{
		}

        //Hay que dividir en listas los niveles del árbol y mostrar los valores
        //de sus nodos tanto por la rama izquierda como derecha. El resultado se guarda
        //en una lista de listas.

        public IList<IList<int>> levelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if (root == null) return res;

            //Agrego el nodo raíz a la fila para poder empezar el bucle
            queue.Enqueue(root);

            //Hasta que la fila no esté vacía, o sea, mientras que hayan nodos
            //por visitar, el bucle continúa.
            while (queue.Count > 0)
            {
                //Creo una lista para guardar a los nodos de cada nivel
                List<int> subList = new List<int>();
                //Mantener la longitud como una variable calculada por fuera del bucle,
                //para que no haga vueltas de más si agrego elementos a la fila
                int len = queue.Count;
                for (int i = 0; i < len; i++)
                {
                    //Saco el primer nodo de la fila y busco sus hijos. Si tiene,
                    //los agrego a la fila para la vuelta del próximo nivel
                    TreeNode aux = queue.Dequeue();
                    if (aux != null)
                    {
                        subList.Add(aux.val);
                        queue.Enqueue(aux.left);
                        queue.Enqueue(aux.right);
                    }
                }
                //No agregar listas vacías al resultado...
                if (subList.Count > 0) res.Add(subList);
            }

            return res;
        }
    }
}

