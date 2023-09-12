using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class RotateImage
	{
		public RotateImage()
		{
		}

        public void Rotate(int[][] matrix)
        {
            Stack<int> stack = new Stack<int>();
            int len = matrix[0].Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                    stack.Push(matrix[i][j]);
            }

            for (int i = 0; i < len; i++)
            {
                //De abajo hacia arriba, de izquiera a derecha
                //coloco en el array los elementos al tope de la
                //pila al mismo tiempo que los elimino de la misma
                for (int j = len - 1; j >= 0; j--)
                    matrix[j][i] = stack.Pop();
            }

        }
    }
}

// SIN USAR STACK (LeetCode)

//public void Rotate(int[][] matrix)
//{

//    Array.Reverse(matrix);
//    int len = matrix.Length;

//    El hecho de revertir el array me permite que en vez de tener que hacer
//    rotar 3 números por vuelta, tenga que rotar 2. Por cada vuelta, roto
//    el número de una intersección fila-columna por la misma intersección invertida (columna-fila)
//    Por cada vuelta, el número de fila y columna van a aumentar y hago el swapping.

//    1 - 2 - 3                       7  - *8  - 9      7  -  4  -  1      7 - 4 - 1
//    4 - 5 - 6  -> Array.Reverse ->  *4 -  5  - 6  ->  8  -  5  - *6  ->  8 - 5 - 2  FIN
//    7 - 8 - 9                       1  -  2  - 3      9  - *2  -  3      9 - 6 - 3

//    for (int row = 0; row < len - 1; row++)
//    {
//        for (int col = row + 1; col < len; col++)
//        {
//            //swapping
//            (matrix[row][col], matrix[col][row]) = (matrix[col][row], matrix[row][col]);
//        }
//    }
//}

