using System;
namespace LeetCode.TopInterviewEasy.Trees
{
	public class MaxDepth
	{
		public MaxDepth()
		{
		}

        public class Solution
        {
            public int maxDepth(TreeNode root)
            {
                //si root es null, devuelvo 0, porque significa que no hay
                //niveles para sumar
                if (root == null) return 0;

                int left = 1, right = 1;

                //voy a averiguar tanto por izquierda como por derecha
                //cuántos niveles puedo bajar hasta llegar a las hojas.
                //Cuando encuentre una hoja y tanto left como right sean null
                //va a terminar la recursividad, y desde cada hoja hasta la copa del árbol
                //van a sumarse los valores retornados por cada llamado a la función
                left += maxDepth(root.left);
                right += maxDepth(root.right);

                //Como son dos los valores, devuelvo el mayor, porque lo único que interesa
                //es saber cuál es la profundidad máxima, no importa si fue por izquierda o derecha
                return Math.Max(left, right);
            }
        }
    }
}

