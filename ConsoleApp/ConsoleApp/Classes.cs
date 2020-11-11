using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Classes
    {
        void Print()
        {
            //Создание экземпляра дополнительного класса с передачей параметров 
            Persona bob = new Persona() { };
            Persona tom = new Persona() { name = "Tom" };
            Persona helli = new Persona() { name = "helli", age = 22 };
            //Вызов методов класса Persona
            tom.Show();
            bob.Show();
            helli.Show();
        }
    } //Главный класс
    class Persona
    {
        public string name;
        public int age;
        //Перегрузка конструктора
        public Persona() : this("Нет") { } // При отсутствии параметров будет выведено "Нет"
        public Persona(string name) : this(name, 18) { } // по умолчанию age = 18
        public Persona(string name, int age) { this.name = name; this.age = age; }
        //Метод класса
        public void Show()
        {
            Console.WriteLine($"Name = {name}; age = {age}");
        }

    } //Дополнительный класс
    class StaticAccount
    {
        //Статические поля, методы, свойства относятся ко всему классу и для обращения к подобным членам класса необязательно создавать экземпляр класса. 
        public StaticAccount(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Недопустимая сумма!");
            Sum = sum; Rate = rate;
        }
        private static decimal minSum = 100; // минимальная допустимая сумма для всех счетов
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }    // сумма на счете
        public decimal Rate { get; private set; }   // процентная ставка
        // подсчет суммы на счете через определенный период по определенной ставке
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    } //Статический класс
}
