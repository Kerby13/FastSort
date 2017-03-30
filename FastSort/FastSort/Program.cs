using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace FastSort
{
    class Program
    {

        static void Main(string[] args)
        {

            int size;
            Console.WriteLine("Введите размер массива: ");
            size = Convert.ToInt32(Console.ReadLine());            
            Random rng = new Random();            
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = rng.Next(0, Int32.MaxValue);
            }

            Stopwatch swsin = new Stopwatch();
            Stopwatch swmul = new Stopwatch();

            swsin.Start();
            QuickSort.singlequickSort(a, 0, a.Length - 1);
            swsin.Stop();

            swmul.Start();
            QuickSort.quickSort(a, 0, a.Length - 1);
            swmul.Stop();


            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("Время работы с потоками: {0}, без потоков: {1}", swmul.ElapsedMilliseconds, swsin.ElapsedMilliseconds));
            Console.ReadLine();
        }
    }
}
