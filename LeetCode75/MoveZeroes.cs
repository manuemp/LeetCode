using System;
namespace LeetCode
{
	public class MoveZeroes
	{
		public MoveZeroes()
		{
		}

		public void moveZeroes(int[] nums)
		{
			int lastZero = 0;

			for(int i = 0; i < nums.Length; i++)
			{
				// LastZero no se va a aumentar cuando haya un cero, sino que
				// cuando no haya. Esto es así porque siempre me voy a mover un índice
				// adelante mientras el número nos sea cero. Si es cero, sigo, y
				// al siguiente número diferente de cero que encuentre lo coloco
				// en la posición que se guardó luego del último que no era cero.
				// Así entonces quedan primero los que no son cero en su orden inicial,
				// y al final los ceros
				if (nums[i] != 0)
				{
					(nums[lastZero], nums[i]) = (nums[i], nums[lastZero]);
					lastZero++;
				}
			}
		}
	}
}

