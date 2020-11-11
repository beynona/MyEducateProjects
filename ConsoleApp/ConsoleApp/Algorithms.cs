using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Algorithms
    {
        void Print()
        {
            Console.WriteLine("\tРекурсивные функции");

            Console.WriteLine("Факториал - " + Factorial(4));
            Console.WriteLine("Фибоначи - " + Fibonachi(4));
        }
        //Факториал числа: n! = 1 * 2 * … * n
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        //Последовательность Фибоначчи выглядит так 0 (0-й член), 1 (1-й член), 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ..
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    } //Фибоначчи, факториал
}
