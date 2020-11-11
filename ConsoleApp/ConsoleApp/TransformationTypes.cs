using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class TransformationTypes
    {
        void Print()
        {
            Personi person1 = new Employe("Jenua", "BNTU");
            Personi person2 = new Clienti("Valik", "Bank-429");
            string bank = ((Clienti)person2).Bank;

            //1 способ преобразования
            Clienti client = person1 as Clienti; //если преобразование успешно, то ссылка, если нет, то null
            if (client != null)
            {
                string name1 = client.Name; //так как person1 содержит ссылку на Employee, а не Client
                Console.WriteLine(name1);
            }
            else
            {
                Console.WriteLine("Преобразование типов не удалось");
            }
            //2 способ преобразования
            try
            {
                Clienti clien = (Clienti)person1; //ошибка, так как Client - person2, а не person1
                string name2 = client.Name;
                Console.WriteLine(name2);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Преобразование ошибки не удалось");
            }
            //3 способ преобразования

            Personi person = new Personi("Tom");
            if (person is Employe)
            {
                Employe emp = (Employe)person;
                Console.WriteLine(emp.Company);
            }
            else
            {
                Console.WriteLine("Преобразование is не удалось");
            }
        }
    } //Преобразование типов при наследовании классов

    class Personi
    {
        public string Name { get; set; }
        public Personi(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employe : Personi
    {
        public string Company { get; set; }
        public Employe(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    class Clienti : Personi
    {
        public string Bank { get; set; }
        public Clienti(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
}

