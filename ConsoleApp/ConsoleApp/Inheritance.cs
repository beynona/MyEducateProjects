using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Inheritance
    {
        void Print()
        {
            Persons p = new Persons("Jenua", "Shinkevich");
            Employee emp = new Employee("Shunkevich", "Jenua", "BNTU");
            p.Display();
            emp.Display();
        }
    }  //Вывод на экран
    class Employee : Persons //Person - базовый класс
    {
        private string _company;
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        public Employee(string name, string surname, string company) : base(name, surname)
        {
            Company = company;

        }
    }    //Наследование от класса Persons    
    class Persons 
    {
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public Persons(string name, string surname)
        {
            _firstName = name;
            _lastName = surname;
        }
    }     //sealed class Person - запрещает наследование от данного класса
}
