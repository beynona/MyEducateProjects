using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class СonditionalСonstructions 
    {
        void СonditionalIf()
        {
            Console.WriteLine("\tУсловные конструкции - if.");

            //Исходные данные
            int num1 = 8;
            int num2 = 10;
            //Условие сравнения
            if (num1 < num2)
            {
                Console.WriteLine("num1 < num2");
            }
            else
            {
                Console.WriteLine("num1 > num2");
            }
            // Условие - если истина
            if (true)
            {
                Console.WriteLine("True");
            }
        }
        void СonditionalSwitchCase()
        {
            Console.WriteLine("\tУсловные конструкции - switch case.");

            //В зависимости от введенного символа
            string select = Console.ReadLine();
            switch (select)
            {
                case "A":
                    Console.WriteLine("A");
                    break;
                case "B":
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("Breake");
                    break;
            }
            //В зависимости от входного числа
            int num3 = 1;
            switch (num3)
            {
                case 1:
                    Console.WriteLine("1 case");
                    goto case 5;
                case 5:
                    Console.WriteLine("5 case");
                    break;
                default:
                    break;
            }
        }
        void СonditionalFor()
        {
            Console.WriteLine("\tЦиклы - for.");

            //Выполнять цикл от 0 до 9
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{i} ");
            }
            //Выход из цикла - ключевое слово break
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{i} ");
                if (i == 5) break;
            }
        }
        void СonditionalWhile()
        {
            Console.WriteLine("\tЦиклы - while.");

            int j = 0;
            while (j < 9)
            {
                Console.Write($"{j} ");
                j++;
            }
        }
        void СonditionalDoWhile()
        {
            Console.WriteLine("\tЦиклы - do while.");

            int k = 0;

            do
            {
                Console.Write($"{k} ");
                k++;
            }
            while (k < 9);
        }
    } //Условные конструкции
}
