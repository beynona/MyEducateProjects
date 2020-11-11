using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    //После модификаторов public static идет ключевое слово 
    //explicit (если преобразование явное, то есть нужна операция приведения типов) 
    //или implicit (если преобразование неявное). 
    //Затем идет ключевое слово operator и далее возвращаемый тип, в который надо преобразовать объект. 
    //В скобках в качестве параметра передается объект, который надо преобразовать.

    class OverloadTransformTypes
    {
        void Print()
        {
            Counter counter = new Counter { Second = 115 };

            Timer timer = counter; //1:55
            Counter counter3 = (Counter)timer; //115
            Console.WriteLine($"H={timer.Hours},M={timer.Minutes},S={timer.Seconds},counter3={counter3.Second}");

            int x = (int)counter; //Явное преобразование
            Counter counter2 = x; //Неявое преобразование

            byte y = (byte)x; //Явное преобразование
            int z = y; //Неявное преобразование
            Console.WriteLine($"x={x},y={y},z={z}");
        }
    } //Перегрузка операций преобразования типов
    class Counter
    {
        public int Second { get; set; }
        public static implicit operator Counter(int x)
        {
            return new Counter { Second = x };
        }
        public static explicit operator int(Counter counter)
        {
            return counter.Second;
        }
        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Second = h + m + timer.Seconds };
        }
        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Second / 3600;
            int m = (counter.Second - h * 3600) / 60;
            int s = counter.Second - h * 3600 - m * 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }
    }
    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

    } //Свойства таймера
    
}
