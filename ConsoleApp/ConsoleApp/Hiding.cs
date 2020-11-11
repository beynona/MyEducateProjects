using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    //Cокрытие представляет определение в классе-наследнике метода или свойства, 
    //которые соответствует по имени и набору параметров методу или свойству базового класса. 
    //Для сокрытия членов класса применяется ключевое слово new. 
    //При этом если мы хотим обратиться именно к реализации свойства или метода в базовом классе, 
    //то опять же мы можем использовать ключевое слово base и через него обращаться к функциональности базового класса.
    //Более того мы даже можем применять сокрытие к переменным и константам, также используя ключевое слово new

    class Hiding
	{
		void Print()
		{
			Personw person = new Personw("Jenua", "Shunkevich");
			person.Display();
			Employeew employee = new Employeew("Valik", "Pere", "BNTU");
			employee.Display();
		}
	} //Сокрытие. Ключевое слово new
	class Personw
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Personw(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public void Display()
		{
			Console.WriteLine($"{FirstName} {LastName}");
		}
		//Переопределение свойств
		protected string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
	class Employeew : Personw
	{
		public string Company { get; set; }
		public Employeew(string firstName, string lastName, string company)
				: base(firstName, lastName)
		{
			Company = company;
		}
		public new void Display()
		{
			Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
		}
		//Переопределение свойств
		public new string Name
		{
			get { return "Employee " + base.Name; }
			set { name = value; }
		}
	}
   
}
