using System;
namespace LeetCode
{
	public class AsteroidCollision
	{
		public AsteroidCollision()
		{
		}

		public int[] asteroidCollision(int[] asteroids)
		{
            Stack<int> stack = new Stack<int>();
            int count = 0;
            int[] ans;

            //Si el que entra es un positivo, fijarme si el anterior es negativo

            for (int i = asteroids.Length - 1; i >= 0; i--)
            {
                while (true)
                {
                    if (stack.Count() == 0)
                    {
                        stack.Push(asteroids[i]);
                        break;
                    }

                    if (stack.Peek() < 0 && asteroids[i] > 0)
                    {
                        if (stack.Peek() + asteroids[i] == 0)
                        {
                            stack.Pop();
                            break;
                        }
                        if (stack.Peek() + asteroids[i] > 0)
                        {
                            stack.Pop();
                            continue;
                        }
                        else break;
                    }
                    else
                    {
                        stack.Push(asteroids[i]);
                        break;
                    }
                }
            }

            ans = new int[stack.Count()];

            foreach (int n in stack)
            {
                ans[count] = n;
                count++;
            }
            return ans;
		}
	}
}



//if (stack.Peek() < 0)
//{
//    if (asteroids[i] > 0)
//    {
//        if (stack.Peek() + asteroids[i] > 0)
//        {
//            stack.Pop();
//            stack.Push(asteroids[i]);
//        }
//    }
//    else
//    {
//        stack.Push(asteroids[i]);
//    }
//}
//else stack.Push(asteroids[i]);