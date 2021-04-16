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

        static void TestCheckPrimeNumber(TestCase testCase)
        {
            try
            {
                var actual = CheckPrimeNumber(testCase.N);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine($"Тест № {testCase.Id} - VALID TEST");
                }
                else
                {
                    Console.WriteLine($"Тест № {testCase.Id} - INVALID TEST Expected {testCase.Expected}");
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
                    Console.WriteLine($"Тест № {testCase.Id} - VALID TEST");
                }
                else
                {
                    Console.WriteLine($"Тест № {testCase.Id} - INVALID TEST");
                }
            }
        }

        static bool CheckPrimeNumber(int n)
        {
            try
            {
                //n = n > 0 ? n : n * -1;
                n = Math.Abs(n);
                if (n == 1) return false;
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
            var n = 4;
            if (CheckPrimeNumber(n))
                Console.WriteLine($"Число {n} простое");
            else
                Console.WriteLine($"Число {n} не является простым\n");

            var testCase1 = new TestCase();
            testCase1.Id = 1;
            testCase1.N = 1;
            testCase1.Expected = false;
            testCase1.ExpectedException = null;

            var testCase2 = new TestCase();
            testCase2.Id = 2;
            testCase2.N = 2;
            testCase2.Expected = true;
            testCase2.ExpectedException = null;

            var testCase3 = new TestCase();
            testCase3.Id = 3;
            testCase3.N = 4;
            testCase3.Expected = false;
            testCase3.ExpectedException = null;

            var testCase4 = new TestCase();
            testCase4.Id = 4;
            testCase4.N = -5;
            testCase4.Expected = true;
            testCase4.ExpectedException = null;

            var testCase5 = new TestCase();
            testCase5.Id = 5;
            testCase5.N = -6;
            testCase5.Expected = false;
            testCase5.ExpectedException = null;

            TestCheckPrimeNumber(testCase1);
            TestCheckPrimeNumber(testCase2);
            TestCheckPrimeNumber(testCase3);
            TestCheckPrimeNumber(testCase4);
            TestCheckPrimeNumber(testCase5);
        }
    }
}
