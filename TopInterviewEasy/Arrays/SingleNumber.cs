using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class SingleNumber
	{
		public SingleNumber()
		{
		}

        public int singleNumber(int[] nums)
        {
            int len = nums.Length;
            Array.Sort(nums);

            // Si en el array solamente hay un elemento,
            // o si en el array ordenado el primer numero es diferente al segundo
            // retorno el primer número
            if (len == 1 || nums[0] != nums[1]) return nums[0];

            for (int i = 1; i < len - 1; i++)
            {
                if (nums[i - 1] != nums[i] && nums[i + 1] != nums[i])
                    return nums[i];
            }

            // Si la condición anterior no cumplió para ningún número
            // el único número posible es el último, ya que siempre
            // tiene que haber un único número que no se repita.
            return nums[len - 1];
        }

    }
}

