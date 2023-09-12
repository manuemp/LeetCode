using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class Intersect
	{
		public Intersect()
		{
		}

        //La intersección hace referencia a los números que comparten
        //ambos conjuntos de números, en este caso arrays.
        //Es la intersección de la teoría de conjuntos.

        public int[] intersect(int[] nums1, int[] nums2)
        {
            List<int> intersection = new List<int>();
            int i = 0, j = 0;

            Array.Sort(nums1);
            Array.Sort(nums2);

            while (i < nums1.Length && j < nums2.Length)
            {
                //Siempre tengo que buscar que el número apuntado por el puntero i
                //sea el mismo al apuntado por el puntero j. Si i apunta a un número
                //menor que j, entonces i tiene que avanzar y buscar otro. Lo mismo con j

                if (nums1[i] < nums2[j])
                {
                    i++;
                    continue;
                }
                else if (nums2[j] < nums1[i])
                {
                    j++;
                    continue;
                }

                //Una vez entontrado el número en el que ambos coinciden, se agrega a la lista
                if (nums1[i] == nums2[j])
                    intersection.Add(nums1[i]);

                i++;
                j++;
            }

            //Se retorna un array, no una lista
            return intersection.ToArray();
        }
    }
}

