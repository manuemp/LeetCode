using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class Rotate
	{
		public Rotate()
		{
		}

        public static void rotate(int[] nums, int k)
        {
            int len = nums.Length, count = 0;
            int num = nums[len - 1];
            int[] aux = new int[len];

            int pos = len - 1;

            // Ubico primero el lugar donde se debería ubicar el
            // último número del array original, que va a ser el "numero clave"
            // que divida en dos nuevas partes al array resultante.
            // El loop se hace porque hay tests en los que k > nums.Length
            // entonces da más de una vuelta sobre el mismo array hasta parar
            while (k > 0)
            {
                pos++;
                if (pos == len) pos = 0;

                k--;
            }

            // Una vez que tengo la posición
            // pongo el número "clave" en el array auxiliar
            aux[pos] = num;

            // Recorro el array desde el número clave hasta el último índice
            // Y luego desde el primer índice hasta el número clave
            while (count < len)
            {
                pos++;
                if (pos == len) pos = 0;

                aux[pos] = nums[count];
                count++;
            }

            Array.Copy(aux, nums, len);
        }
    }
}


//Solución de LeetCode, mucho mejor y más concisa...

//public void rotate(int[] nums, int k)
//{
//    k = k % nums.Length;
//    reverse(nums, 0, nums.Length - 1);
//    reverse(nums, 0, k - 1);
//    reverse(nums, k, nums.Length - 1);
//}

//public void reverse(int[] nums, int start, int end)
//{
//    while (start < end)
//    {
//        (nums[start], nums[end]) = (nums[end], nums[start]);
//        start++;
//        end--;
//    }
//}
