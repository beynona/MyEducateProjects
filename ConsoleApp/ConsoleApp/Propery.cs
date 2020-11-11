using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Propery
    {
        void Print()
        {
            //Создание экземпляра класса
            Personal Jenua = new Personal();
            Jenua.Age = 21;
            Jenua.Name = "Jenua";
            Console.WriteLine(Jenua.Fulla);
        }
    } //Главный класс
    class Personal
    {
        //Инкапсуляция свойств
        private string name;
        private int age;
        public string Name
        {
            //Получить значение
            get
            {
                return name;
            }
            //Установить значение
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Fulla
        {
            //Получить значение свойства
            get
            {
                return $"{name}{age}";
            }
        }
    } //Класс свойств
}
