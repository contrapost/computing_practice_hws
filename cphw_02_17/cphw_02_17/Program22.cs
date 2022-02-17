using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives_Console16._02
{
    class Program
    {
        //Массив - аналог "списков" в Python. Представляет собой совокупность однотипных величин
        static void Notmain(string[] args)
        {
            //Все типы делятся на ссылочные и значимые. Главное отличие - в механизме хранения их в памяти.
            //Массив - относится к значимым типах данных.
            Random rand_values; //объявление
            Random rand_values2;
            List<object> n = new List<object>();
            int dimension; 
            int[] test_mass1;
            int[,] test_mass2;
            int[] a;
            int[] b = new int[10];
            //Массивы одного типа можно присваивать друг другу
            //a = b;
            //int sum; //объявление переменной
            //sum = 0; //инициализация, создание, занесение значений
            //int diff = 0;
            ////Console.WriteLine("Введите размерность");
            ////dimension = Convert.ToInt32(Console.ReadLine());
            ////test_mass1 = new int[dimension];
            //rand_values = new Random(); //инициализация, создание, занесение значений
            //////for
            //Console.WriteLine("Введите минимальное значение");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите максимальное значение");
            //int max = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("Массив:");
            //////Нумерация массива начинается с 0
            ////for (int i = 0; i < test_mass1.Length; i++)
            ////{
            ////    test_mass1[i] = rand_values.Next(min,max);
            ////    //a[i] = r.Next(1, 100);
            ////    Console.WriteLine(test_mass1[i]);
            ////    //Console.WriteLine("Сумма элементов:");
            ////    sum += test_mass1[i];
            ////    diff -= test_mass1[i];
            ////}
            ////Console.WriteLine($"Сумма элементов:{sum}");
            ////Console.WriteLine($"Разность элементов:{diff}");
            //test_mass2 = new int[10, 10];
            //rand_values2 = new Random();
            //for (int i = 0;i<test_mass2.GetLength(0);i++)
            //{
            //    for(int j = 0;j< test_mass2.GetLength(1);j++)
            //    {
            //        test_mass2[i,j] = rand_values2.Next(min, max);
            //        Console.Write(test_mass2[i,j] + "\t");
            //    }
            //        Console.Write("\n");
            //}

            //foreach 
            int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[5]; 
            //numbers2[0] = 1; 
            //numbers2[1] = 9;
            //numbers2[2] = 7;
            Console.WriteLine(numbers1.Length + "Length");
            int[] test = new int[5];
            { test[0] = 1; test[1] = 1; test[2] = 6; }

            foreach (int j in numbers1)
            {
                Console.WriteLine(j * 4 + "\t");
            }
            //while
            int[] ad = new int[100];
            Random random = new Random();
            int k = -1;
            while (k++ < 99)
            {
                ad[k] = random.Next(100);
                Console.WriteLine(ad[k]);
            }
            Console.ReadKey();
        }
    }
}
