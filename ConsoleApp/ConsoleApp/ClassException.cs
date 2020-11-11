using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ClassException
    {
        void Print()
        {
            try
            {
                Personh p = new Personh() { Name = "Tom", Age = 13 };

            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
        }
    } //Класс исключений 
    class PersonException : ArgumentException
    {
        public int Value { get; set; }
        public PersonException(string message, int val) : base(message) // : base(message) для отображения сообщений
        {
            Value = val;
        }
    } //Создание собственного класса ошибок при помощи насследования от ArgumentException
    class Personh
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    throw new PersonException("Нельзя", value); //Отлов собственных ошибок с параметрами
                }
                else
                {
                    age = value;
                }
            }
        }
    } // throw new - отлов собственных исключений
}
