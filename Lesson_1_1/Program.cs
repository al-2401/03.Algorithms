﻿using System;

namespace Lesson_1_1
{
    class Program
    {
        public class TestCase
        {
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
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
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
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        static bool CheckPrimeNumber(int n)
        {
            try
            {
                //n = n > 0 ? n : n * -1;
                n = Math.Abs(n);
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
                throw new ArgumentException("\"n\" не является целым числом");
            }
        }
        static void Main(string[] args)
        {
            var n = 6;
            if (CheckPrimeNumber(n))
                Console.WriteLine($"Число {n} простое");
            else
                Console.WriteLine($"Число {n} не является простым\n");

            var testCase1 = new TestCase();
            testCase1.N = 5;
            testCase1.Expected = true;
            testCase1.ExpectedException = null;

            var testCase2 = new TestCase();
            testCase2.N = 6;
            testCase2.Expected = false;
            testCase2.ExpectedException = null;

            TestCheckPrimeNumber(testCase1);
            TestCheckPrimeNumber(testCase2);


        }
    }
}
