using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace уауауауауауауа
{

    class Program
    {
        //     //метод для обмена элементов
        //     static void Swap(ref int a, ref int b)
        //     {
        //         var t = a;
        //         a = b;
        //         b = t;
        //     }

        //     static int[] ShellSort(int[] array)
        //     {
        //         //расстояние между элементами, которые сравниваются
        //         var d = array.Length / 2;
        //         while (d >= 1)
        //         {
        //             for (var i = d; i < array.Length; i++)
        //             {
        //                 var j = i;
        //                 while ((j >= d) && (array[j - d] > array[j]))
        //                 {
        //                     Swap(ref array[j], ref array[j - d]);
        //                     j = j - d;
        //                 }
        //             }

        //             d = d / 2;
        //         }

        //         return array;
        //     }


        //     static void Main(string[] args)
        //     {
        //         Random random = new Random();
        //     int[] array1= new int[10000];
        //     for (int i = 0; i<10000; i++)
        //{
        //         array1[i] = random.Next(-1000,1000);
        //}
        // Console.WriteLine();
        //        Stopwatch stopwatch = new Stopwatch();
        //         int[] array2 = ShellSort(array1);
        //         stopwatch.Start();
        //         Console.WriteLine(stopwatch.ElapsedMilliseconds);
        //         Console.ReadLine();
        //     }

        //метод обмена элементов
        //static void Swap(ref int e1, ref int e2)
        //{
        //    var temp = e1;
        //    e1 = e2;
        //    e2 = temp;
        //}

        ////сортировка пузырьком
        //static int[] BubbleSort(int[] array)
        //{
        //    var len = array.Length;
        //    for (var i = 1; i < len; i++)
        //    {
        //        for (var j = 0; j < len - i; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                Swap(ref array[j], ref array[j + 1]);
        //            }
        //        }
        //    }

        //    return array;
        //}

        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка вставками
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array1 = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array1[i] = random.Next(-1000, 1000);
            }
            Console.WriteLine();
            Stopwatch stopwatch = new Stopwatch();
            int[] array2 = InsertionSort(array1);
            stopwatch.Start();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}