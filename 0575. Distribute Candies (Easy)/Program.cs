using System;

namespace _0575._Distribute_Candies__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candies = new int[] { 1, 1, 2, 3 };
            Console.WriteLine(DistributeCandies(candies));
        }

        public static int DistributeCandies(int[] candies)
        {
            int categories = 0;

            //因為糖果的種類範圍為-100,000~100,000
            int[] temp = new int[200001];

            foreach (var item in candies)
            {
                if (++temp[item + 100000] == 1)
                {
                    categories++;
                }
            }

            //不同種類的糖果數量如果超過所有糖果數量/2，則回傳兩人平均後的糖果數量。
            //否則回傳將不同種類的糖果都放在某人那邊的結果。
            return categories >= candies.Length / 2 ? candies.Length / 2 : categories;
        }
    }
}
