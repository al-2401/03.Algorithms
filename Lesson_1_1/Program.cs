using System;

namespace Lesson_1_1
{
    class Program
    {
        public class TestCase
        {
            public int Id { get; set; }
            public int N { get; set; }
            public bool Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void TestCheckPrimeNumber(int n, bool expected, Exception expectedException)
        {
            var testCase = new TestCase();
            testCase.N = n;
            testCase.Expected = expected;
            testCase.ExpectedException = expectedException;

            try
            {
                var actual = CheckPrimeNumber(testCase.N);
                Console.Write($"На вход подаем {testCase.N} ожидаем {testCase.Expected}");
                if (actual == testCase.Expected)
                {
                    Console.WriteLine(" - VALID TEST");
                }
                else
                {
                    Console.WriteLine(" - INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //помогите разобраться
                    //какой тип исключения указать в функции CheckPrimeNumber
                    //чтобы обработать в этом тесте
                    //TODO add type exception tests;
                    Console.WriteLine($" - VALID TEST {testCase.ExpectedException}");
                }
                else
                {
                    Console.WriteLine(" - INVALID TEST");
                }
            }
        }

        static bool CheckPrimeNumber(int n)
        {
            try
            {
                //n = n > 0 ? n : n * -1;
                n = Math.Abs(n);
                if (n == 0 || n == 1) return false;
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
            catch
            {
                throw new ArgumentException("\"n\" ошибка при нахождении простого числа");
            }
        }
        static void Main(string[] args)
        {
            var n = 0;
            if (CheckPrimeNumber(n))
                Console.WriteLine($"Число {n} простое");
            else
                Console.WriteLine($"Число {n} не является простым\n");

            TestCheckPrimeNumber(1, false, null);
            TestCheckPrimeNumber(2, true, null);
            TestCheckPrimeNumber(4, false, null);
            TestCheckPrimeNumber(-5, false, null);// указываем неправильное ожидание, для INVALID TEST
            TestCheckPrimeNumber(-6, true, null); // указываем неправильное ожидание, для INVALID TEST
        }
    }
}
