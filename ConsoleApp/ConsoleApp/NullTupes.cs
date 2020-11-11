using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class NullTupes
    {
        void Print()
        {
            // ?. проверяет не равняется ли значение null
            // ?? выдаёт значение, если получен null
            User user = new User();
            string CompanyName = user?.Phone?.Company?.Name ?? "не найдено значение";
            Console.WriteLine(CompanyName);
            string str = null;
            string oba = str ?? "значение новое";
        }
    }
    class User
    {
        public Phone Phone { get; set; }
    }
    class Phone
    {
        public Company Company { get; set; }
    }
    class Company
    {
        public string Name { get; set; }
    }
}
