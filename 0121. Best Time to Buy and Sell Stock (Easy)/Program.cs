using System;

namespace _0121._Best_Time_to_Buy_and_Sell_Stock__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] prices = new int[] { 7, 6, 3, 1, 4};
            Console.WriteLine(MaxProfit(prices));

        }
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0 || prices == null)
                return 0;

            int min = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                } else
                {
                    if (prices[i] - min > profit)
                    {
                        profit = prices[i] - min;
                    }
                }
            }

            return profit;
        }
    }
}
