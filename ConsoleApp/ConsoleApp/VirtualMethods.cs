using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class VirtualMethods
    {
        void Print()
        {
            Personq person = new Personq("Jene");
            Employeeq employee = new Employeeq("Jane", "BNTU");
            person.Display();
            employee.Display();
        }
    } //Виртуальные методы и свойства (Полиморфизм)
    class Personq
    {
        public virtual string Name { get; set; }
        public Personq(string name)
        {
            Name = name;
        }
        public virtual void Display() // virtual позволяет переопределять данный метод или свойство в классах наследниках
        {
            Console.WriteLine(Name);
        }
    } //ключевое слово virtual делает объект полиморфным
    class Employeeq : Personq
    {
        private string name;
        public string Company { get; set; }
        public Employeeq(string name, string company) : base(name)
        {
            Company = company;

        }
        public override void Display() // override позволяет перезаписать данный метод или свойство в классах наследниках
        {
            base.Display();
            Console.Write("work in " + Company);
        }
        public override sealed string Name //Ключевое слово sealed запрещает переопределение методов и свойств
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "Jene")
                {
                    name = value;
                }
            }
        }
    } //override переопределяет полиморвный объект
}
