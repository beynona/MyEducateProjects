using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    //Метод GetHashCode позволяет возвратить некоторое числовое значение, которое будет соответствовать данному объекту или его хэш-код.
    //Метод GetType позволяет получить тип данного объекта
    //Метод Equals позволяет сравнить два объекта на равенство
    //Для проверки строки на пустоту применяется метод String.IsNullOrEmpty().
    //Метод ToString служит для получения строкового представления данного объекта. Для базовых типов просто будет выводиться их строковое значение
    class SystemObject
    {
        void Print()
        {
            //base
            Personz person = new Personz { Name = "Tom" };
            Console.WriteLine(person);
            //ToString class
            Clockz clock = new Clockz { Hours = 19, Minutes = 45, Seconds = 32 };
            Console.WriteLine(clock.ToString());
            //ToString
            int i = 5;
            double b = 3.2;
            Console.WriteLine($"i={i.ToString()}");
            Console.WriteLine($"b={b.ToString()}");

            Personz person1 = new Personz { Name = "Tom" };
            Personz person2 = new Personz { Name = "Bob" };
            Personz person3 = new Personz { Name = "Tom" };
            bool p1Ep2 = person1.Equals(person2);   // false
            bool p1Ep3 = person1.Equals(person3);   // true

            Personz person4 = new Personz { Name = "Tom" };
            Console.WriteLine(person4.GetType());    // Person
        }
    } //Класс System.Object и его методы
    class Personz
    {
        public string Name { get; set; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return base.ToString();
            return Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Personz person = (Personz)obj;
            return (this.Name == person.Name);
        }
    }
    class Clockz
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
}
