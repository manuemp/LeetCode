using System;
namespace LeetCode
{
	public class MaximumAverageSubarray
	{
		public MaximumAverageSubarray()
		{
		}

        // Los algoritmos de ventana móvil permiten trabajar con
        // grupos dentro de un array de forma eficiente,
        // sin usar loops anidados

		public double maximumAverageSubarray(int[] nums, int k)
		{
            double avg, sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            // Obtengo el primer promedio sumando los primeros k numeros
            avg = sum / k;

            for (int i = k; i < nums.Length; i++)
            {
                // Por cada número que avanzo, sumo ese número y
                // elimino el que era el primero de la vuelta anterior,
                // así formo la "ventana" con los últimos k números
                sum = sum + nums[i] - nums[i - k];

                // Corroboro que este nuevo promedio sea el máximo
                if (sum / k > avg)
                {
                    avg = sum / k;
                }
            }
            return avg;
        }
	}
}

