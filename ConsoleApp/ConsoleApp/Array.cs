using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Array
    {
        void noticeArray()
        {
            //Варианты объявления массива
            int[] num = new int[4] { 1, 5, 3, 4 };
            int[] num2 = new int[] { 1, 2, 3, 4 };
            int[] num3 = new[] { 1, 2, 3, 4 };
            int[] num4 = { 1, 2, 3, 4 };
            int[] num5 = new int[4];
            //Объявление значений элементов массива
            num5[0] = 1;
            num5[1] = 2;
            num5[2] = 3;
            num5[3] = 4;
            //Перебор массива осуществляется при помощи foreach
            foreach (int i in num)
            {
                Console.Write(i);
            }
            //Перебор массива осуществляется при помощи for
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }
        } //Виды одномерных массивов и цикл foreach
        void MultidimensionalArray()
        {
            //Двумерный массив
            int[,] num = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
            //Ступенчатый массив
            int[][] numer = new int[3][];
            numer[0] = new int[2] { 1, 2 };
            numer[1] = new int[3] { 1, 2, 3 };
            numer[2] = new int[5] { 1, 2, 3, 4, 5 };
        } //Многомерные массивы
        void InversionArray()
        {
            //объявление массива
            int[] num = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //получаем длину массива
            int n = num.Length;
            //получаем середину массива
            int k = n / 2;
            int temp;

            //Инверсия массива
            for (int i = 0; i < k; i++)
            {
                temp = num[i];
                num[i] = num[n - i - 1];
                num[n - i - 1] = temp;
            }
            //Вывод результата на экран
            foreach (int Nu in num)
            {
                Console.WriteLine(Nu);
            }
        } //Инверсия массива
        void SortArray()
        {
            //объявление массива
            int[] num = new int[7];
            //Задание значений элементам массива
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                num[i] = Int32.Parse(Console.ReadLine());

            }
            //Сортировка массива
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            //Вывод результата на экран
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        } //Сортировка массива
    } //Операции с массивами
    class ArrayParams
    {
        void MainArray()
        {
            Console.WriteLine("\tМассив параметров и ключевое слово \"Params\"");
            
            //Объявление массива
            int[] massiv_in_Main = new int[] { 2, 4, 6, 8 };
            //Выхов метода с разным количеством параметров
            Addition();
            Addition(1, 2, 3, 4);
            Addition(massiv_in_Main);
        }
        //Используя ключевое слово params, мы можем передавать неопределенное количество параметров
        static void Addition(params int[] mas)
        {
            int Sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                Sum += mas[i];
            }
            Console.WriteLine($"Сумма элементов массива = {Sum}");
        }
    } //Ключевое слово params
}
