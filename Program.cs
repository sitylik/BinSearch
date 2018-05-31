using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)

        {
            if (array.Length > 0)
            {
                var left = 0;
                var right = array.Length - 1;
                while (left < right)
                {
                    var middle = (right + left) / 2;
                    if (value <= array[middle])
                        right = middle;
                    else left = middle + 1;
                }
                if (array[right] == value)
                    return right;
                return -1;
            }
            else
                return -1;

        }
        static void Main(string[] args)

        {
            TestOneNumbers();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatNumbers();
            TestEmptyNumbers();
            TestVastNumbers();
            Console.ReadKey();

        }
        private static void TestOneNumbers()
        {
            //Тестирование поиска одного элемент
            int[] oneNumber = { 1, 2, 3, 4, 5 };
            if (BinarySearch(oneNumber, 3) != 2)
                Console.WriteLine("! Поиск не нашел число 3 среди чисел {1, 2, 3, 4, 5}");
            else
                Console.WriteLine("Поиск одного элемента работает корректно");
        }
        private static void TestNegativeNumbers()

        {

            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");

        }

        private static void TestNonExistentElement()

        {

            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");

        }
        private static void TestRepeatNumbers()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз
            int[] repeatNumbers = { 1, 2, 3, 3, 4, 5 };
            var ind = BinarySearch(repeatNumbers, 3);
            if (repeatNumbers[ind] != 3)
                Console.WriteLine("! Поиск работает некорректно");
            else
                Console.WriteLine("Поиск среди элементов, повторяющихся несколько раз работает корректно");
        }
        private static void TestEmptyNumbers()
        {
            //Тестирование поиска элемента в пустом массиве 
            int[] emptyNumbers = { };
            if (BinarySearch(emptyNumbers, 5) != -1)
                Console.WriteLine("! Поиск нашёл число 5 среди чисел {}");
            else
                Console.WriteLine("Поиск элементов в пустом массиве работает корректно");
        }

        private static void TestVastNumbers()
        {
            //Тестирование поиска элемента в массиве из 1001 элемента 
            bool t = false;
            var vastNumbers = new int[100001];
            for (var i = 0; i < 100001; i++)
                vastNumbers[i] = i - 10;
            for (var i = 0; i < 100001; i++)
            {
                if (BinarySearch(vastNumbers, i) != -1)
                {
                    t = true;
                    break;
                }
            }
            if (t)
                Console.WriteLine("Поиск элементов в массиве из 100001 элемента работает корректно");
            else
                Console.WriteLine("! Поиск не нашёл число i среди 100001 элементов");
        }
    }
}
