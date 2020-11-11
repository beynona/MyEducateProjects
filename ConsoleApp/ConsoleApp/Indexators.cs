using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Indexators
    {
        void PrintUsers()
        {
            Users tom = new Users();
            tom["name"] = "Tom";
            Console.WriteLine(tom["name"]);
        } //Использование индексатора по выбранному свойству
        void PrintPeople()
        {
            People people = new People();
            people[1] = new Person { Name = "Tim" };
            Person tom = people[1];
            Console.WriteLine(tom?.Name);
        } //Использование индексатора для создания нового пользователя
        void OverloadPrint() 
        {
            People people = new People();
            people[0] = new Person { Name = "Tum" };
            people[1] = new Person { Name = "Bob" };
            Console.WriteLine(people[0].Name);
            Console.WriteLine(people["Bob"].Name);
        } //Перегрузка индексатора
    }
    class Users
    {
        string name;
        string email;
        string phone;
        //Индексатор объявляется по конструкции this[prop]
        public string this[string prop]
        {
            get
            {
                switch (prop)
                {
                    case "name":
                        return name;
                    case "email":
                        return email;
                    case "phone":
                        return phone;
                    default: return null;
                }
            }
            //Установка значений
            set
            {
                switch (prop)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }
    } //Реализация индексатора по выбранному свойству
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    } //Хранение имён и возраста пользователей
    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        //Перегрузка индексатора по числу
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        //Перегрузка индексатора по строке
        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    { person = p; break; }
                }
                return person;
            }
        }
    } //Реализация индексатора по созданию новых пользователей
}
