using System;

namespace _1342._Number_of_Steps_to_Reduce_a_Number_to_Zero__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSteps(123));
        }

        public static int NumberOfSteps(int num)
        {
            int result = 0;

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                } else
                {
                    num -= 1;
                }
                result++;
            }

            return result;
        }
    }
}
