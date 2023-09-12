using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class PlusOne
	{
		public PlusOne()
		{
		}

        public int[] plusOne(int[] digits)
        {
            int len = digits.Length;
            bool nines = true;

            //Me paro en el último.
            //Si es 9 lo convierto en 0 y hago lo mismo con todos
            //hasta que llegue a uno que no sea 9. A ese le sumo 1.

            //Caso especial
            //Si todos los números del array son 9, devuelvo un array con
            //una longitud +1. Le cambio solo el primero por 1.

            foreach (int num in digits)
            {
                if (num != 9)
                {
                    nines = false;
                    break;
                }
            }

            if (!nines)
            {
                for (int i = len - 1; i >= 0; i--)
                {
                    if (digits[i] == 9) digits[i] = 0;
                    else
                    {
                        digits[i]++;
                        break;
                    }
                }
            }
            else
            {
                digits = new int[len + 1];
                digits[0] = 1;
            }

            return digits;
        }
    }
}

