using System;

namespace Lesson_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrangeSum(new int[] { 1, 2, 3, 4, 5 }));
        }
        // Cложность функции
        // подсчитываем простые операции 
        // 1 + n*n*n*(1+1+1+5) = 1 + 8 * n^3 
        // n - это размер входа, отбрасываем константы
        // сложность функции f от n = f(n^3)
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;                                            // + 1

            for (int i = 0; i < inputArray.Length; i++)             // * n
            {
                for (int j = 0; j < inputArray.Length; j++)         // * n
                {
                    for (int k = 0; k < inputArray.Length; k++)     // * n
                    {
                        int y = 0;                                  // + 1

                        if (j != 0)                                 // + 1
                        {
                            y = k / j;                              // + 1
                        }

                        sum += inputArray[i] + i + k + j + y;       // + 5
                    }
                }
            }

            return sum;
        }
    }
}
