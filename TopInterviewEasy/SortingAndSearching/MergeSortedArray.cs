using System;
namespace LeetCode.TopInterviewEasy.SortingAndSearching
{
	public class MergeSortedArray
	{
		public MergeSortedArray()
		{
		}

        //Se necesita unir dos arrays ordenados en uno solo.
        //No se puede crear un nuevo array, sino que todo tiene que ubicarse en nums1.

        //nums1 termina con 'n' cantidad de 0s al final del array, que es el espacio
        //necesario para insertar los números que componen a nums2.
        //'m' es la cantidad de números de nums1 que no son 0.

        //En este caso, lo mejor es hacer el ordenamiento eliminando ceros, desde el último
        //al primero, por lo que en ambos arrays tengo que pararme en el último número (que no sea 0)
        //ver cuál de ambos es mayor, y ubicar al mayor en el último 0 disponible.

        //Ejemplo: nums1 = {1, 2, 3, 0, 0, 0}, m = 3
        //         nums2 = {2, 5, 6}, n = 3
        //         nums1 = {1, 2, 2, 3, 5, 6} <- resultado

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int len = nums1.Length - 1;
            //Al iniciar los 0s van a corresponder a la cantidad de numeros en nums2
            int zeroes = n;

            //mientras que queden números en m (nums1) para evaluar, comparo
            while (zeroes > 0 && m > 0)
            {
                //comparo el último número -diferente de 0- en nums1 y nums2
                if (nums1[m - 1] < nums2[n - 1])
                {
                    nums1[len] = nums2[n - 1];
                    n--;
                    //resto el contador
                    zeroes--;
                }
                else
                {
                    //En caso de que el mayor sea de nums1, lo corro de posición
                    //y agrego un 0 donde estaba el número antes, porque no coloqué
                    //un número nuevo en el array, solo lo acomodé
                    nums1[len] = nums1[m - 1];
                    nums1[m - 1] = 0;
                    m--;
                }
                //decremento len, que indica la posición en la que se colocará
                //el siguiente número
                len--;
            }

            //cuando no queden números en nums1, coloco en los 0 que quedan
            //lo que reste de nums2 para terminar la unión
            while (zeroes > 0 && n > 0)
            {
                nums1[len] = nums2[n - 1];
                n--;
                zeroes--;
                len--;
            }
        }
    }
}

