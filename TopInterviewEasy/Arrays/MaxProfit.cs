using System;
namespace LeetCode.TopInterviewEasy.Arrays
{
	public class MaxProfit
	{
		public MaxProfit()
		{
		}

        public int maxProfit(int[] prices)
        {
            int sum = 0, buy = prices[0], sell = prices[0];
            int len = prices.Length;
            bool transaction = false, flag = true;

            for (int i = 1; i < len; i++)
            {
                if (prices[i] < prices[i - 1])
                {
                    //transaction se encarga de 'avisar' que por lo menos una vez
                    //hubo una bajada de precio, la tendencia no fue constante
                    transaction = true;
                    sell = prices[i - 1];
                    sum += sell - buy;
                    buy = prices[i];

                    //flag se encarga de indicar si quedó un cálculo pendiente
                    //Esto es porque puede terminar el loop y faltó hacer el
                    //último cálculo de sum (si viniera en alza y terminó el loop)
                    flag = false;
                }
                else
                    flag = true;
            }

            //Si flag es falso no hay cálculos extra por hacer fuera del loop

            //Si no hubo transacción, o si hubo pero flag es verdadero, significa
            //que queda una cuenta pendiente por calcular.
            //En el primer caso es porque jamás se calculó nada, o sea, siempre
            //fue en alza. En el segundo es porque el loop terminó en alza y no se
            //pudo calcular sum una última vez.
            if (!transaction || transaction && flag)
                sum += prices[len - 1] - buy;

            return sum;
        }
    }
}

//Respuesta de LeetCode (Excelente)

//public int maxProfit(int[] prices)
//{
//    //Sin complicaciones... Este código calcula las diferencias entre
//    //el precio de un día y otro. Si la diferencia es negativa, no se suma
//    //ya que significa que bajó el precio. Si la suma es positiva,
//    //hay ganancia y se actualiza la suma.
//    //Siempre va a dar el mismo resultado que mi código, porque al final del
//    //loop obtengo la misma suma que si calculara los mejores días para comprar
//    //y vender. Con ambos algoritmos se busca la suma óptima.
//    //Este lo hace sin vueltas ni variables innecesarias.
//
//    int len = prices.Length;
//    int sum = 0;
//
//    for(int i = 1; i < len; i++)
//    {
//        int diff = prices[i] - prices[i - 1];
//        if (diff > 0)
//            sum += diff;
//    }
//    return sum;
//}
