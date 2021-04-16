using System;

namespace Lesson_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числа Фибоначчи то 0 до 1000 методом цикла");
            GetFibonacciNumbersFor(1000);
            Console.WriteLine("\nЧисла Фибоначчи то 0 до 1000 методом рекурсии");
            GetFibonacciNumbersRec(1000);
        }

        /// <summary>
        /// Числа Фибоначчи то 0 до n методом цикла
        /// </summary>
        static void GetFibonacciNumbersFor(int n)
        {
            var prev1 = 1;
            var prev2 = 0;
            var fib = 0;
            while (true)
            {
                fib = prev1 + prev2;
                prev2 = prev1;
                prev1 = fib;
                if (fib <= n)
                    Console.WriteLine(fib);
                else
                    break;
            }
        }

        /// <summary>
        /// Числа Фибоначчи то 0 до n методом рекурсии
        /// </summary>
        static void GetFibonacciNumbersRec(int n, int fib = 0, int prev1 = 1, int prev2 = 0)
        {
            fib = prev1 + prev2;
            prev2 = prev1;
            prev1 = fib;
            if (fib <= n)
            {
                Console.WriteLine(fib);
                GetFibonacciNumbersRec(n, fib, prev1, prev2);
            }
        }
    }
}
