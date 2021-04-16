using System;

namespace Lesson_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 6;
            if (CheckPrimeNumber(n))
                Console.WriteLine($"Число {n} простое");
            else
                Console.WriteLine($"Число {n} не является простым");
        }

        static bool CheckPrimeNumber(int n)
        {
            var d = 0;
            for (var i = 2; i < n; i++)
            {
                if (n % i == 0)
                    d++;
            }
            switch (d)
            {
                case 0:
                    return true;

                default:
                    return false;
            }
        }
    }
}
