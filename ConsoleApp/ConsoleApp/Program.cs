using System;

namespace ConsoleApp
{

    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("\tУрок 52:Ковариантность и контравариантность делегатов");

            

            /* 
          
             Console.WriteLine("\tУрок 51: Класс данных события AccountEventArgs");

            delegate void AccHend(object sender, AccountEventArguments e);
    class AccountEventArguments
        {
            public string Message { get; }
            public int Sum { get; }
            public AccountEventArguments(string mes, int sum)
            {
                Message = mes;
                Sum = sum;
            }
        }

        class Account
        {

            public event AccHend Notify;
            public int Sum { get; set; }
            public Account(int sum)
            {
                Sum = sum;
            }
            public void Put(int sum)
            {
                Sum += sum;
                Notify?.Invoke(this, new AccountEventArguments($"Сумма добавления :{sum}", sum));
            }
            public void Take(int sum)
            {
                if (Sum > sum)
                {
                    Sum -= sum;
                    Notify?.Invoke(this, new AccountEventArguments($"Сумма снятия :{sum}", sum));
                }
                else
                {
                    Notify?.Invoke(this, new AccountEventArguments($"Сумма на счёте недостаточна для перевода", sum));

                }

            }
        }

        private static void Display(object sender, AccountEventArguments e)
            {
                Console.WriteLine($"Сумма транзакции {e.Sum}");
                Console.WriteLine(e.Message);
            }


            Account account = new Account(500);
            
            account.Notify += Display;
            account.Put(100);
            account.Take(90);
            account.Take(520);

            Console.WriteLine("\tУрок 50: События");
            class Account
        {
            public delegate void AccountHandler(string message);
            public event AccountHandler Notify;              // 1.Определение события
            public Account(int sum)
            {
                Sum = sum;
            }
            public int Sum { get; private set; }
            public void Put(int sum)
            {
                Sum += sum;
                Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
            }
            public void Take(int sum)
            {
                if (Sum >= sum)
                {
                    Sum -= sum;
                    Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
                }
                else
                {
                    Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
                }
            }
        }
        private static void Message(string mes)
        {
            Console.WriteLine(mes);
        }
        
            Account account1 = new Account(40);

            //1 variant
            //account1.Notify += Message;

            //1 variant
            account1.Notify += delegate(string mes)
            {
                Console.WriteLine(mes);
            };

            //1 variant
            account1.Notify += mes => Console.WriteLine(mes);
            //realizatia
             Console.WriteLine($"Сумма на счёте:{account1.Sum}");
            account1.Put(10);
            Console.WriteLine($"Сумма на счёте:{account1.Sum}");
            account1.Take(30);
            Console.WriteLine($"Сумма на счёте:{account1.Sum}");
            account1.Take(30);
            Console.WriteLine($"Сумма на счёте:{account1.Sum}");

             Console.WriteLine("\tУрок 49: Лямбда выражения");
            //2
            delegate int Operation(int a, int b);
            //1
            delegate int Square(int a);
            //1
            delegate void Hello();
            //Metod
            delegate bool IsEqual(int n);
            static int SumMas(int[] numbers, IsEqual isEqual)
            {
                int results = 0;
                foreach (int n in numbers)
                {
                    if (isEqual(n))
                        results += n;
                }
                return results;
            }

            //2 параметра
            Operation operation = (x, y) => x + y;
            Console.WriteLine(operation(1,9));
            //1 параметр
            Square square = x => x * x;
            Console.WriteLine(square(5));
            //0 параметров
            Hello hello = () => Console.WriteLine("Hello, Jenua");
            hello();
            //Условные метод 
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int res = SumMas(number, n => n > 3); //Лямбда условие, считает сумму всех чисел >3
            Console.WriteLine(res);

            Console.WriteLine("\tУрок 48: Анонимные методы");
            delegate void MessageHandler(string mes);
            delegate int Operation(int a, int b);
            static void ShowMessage(string mes, MessageHandler messageHandler)
            {
                messageHandler(mes);
            }
            //text
            MessageHandler message = delegate (string mes)
            {
                Console.WriteLine(mes);
            };
            message("Hi");
            //Operation
            Operation operation = delegate (int a, int b)
            {
                return a + b;
            };
            int res = operation(5, 4);
            Console.WriteLine(res);
            //Metod
            ShowMessage("Hi Jenue", delegate (string mes)
            {
                Console.WriteLine(mes);
            });
            
            Console.WriteLine("\tУрок 47: Делегаты");
                delegate void AccountState(string mess);
            class Account
            {
                AccountState _accountState;
                public void RegHandler(AccountState accountState)
                {
                    _accountState = accountState;
                }
                public void SayHiP()
                {
                    _accountState("SayHello in Account");
                }
            }

            delegate void Message();
            delegate int Operation(int a, int b);
            static void DisMes(string mess)
            {
                Console.WriteLine(mess);
            }
            private static void SayHi()
            {
                Console.WriteLine("Hello World");
            }
            private static void SayBye()
            {
                Console.WriteLine("Bye World");
            }
            private static void Show_Message(Message message)
            {
                message?.Invoke();
            }
            public static int Sum(int a, int b)
            {
                return a + b;
            }
            public static int Sub(int a, int b)
            {
                return a - b;
            }
            Account account = new Account();
                account.RegHandler(DisMes);
                account.SayHiP();

                //Вывод пустого метода
                Message message;
                message = SayHi;
                message();
                message = SayBye;
                message();
                //Вывод с параметрами
                Operation operation = Sum;
                int result = operation(4, 5);
                Console.WriteLine(result);
                operation = Sub;
                int res = operation(5, 4);
                Console.WriteLine(res);
                // Обобщение делегатов
                Message messageFull;
                messageFull = SayHi;
                messageFull += SayBye;
                messageFull?.Invoke();
                //Параметры методов
                Show_Message(SayHi);
                        Console.WriteLine("\tУрок 46: Класс исключений");
                            class PersonException : ArgumentException
                    {
                        public int Value { get; set; }
                        public PersonException(string message, int val) : base(message)
                        {
                            Value = val;
                        }
                    }
                    class Person
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
                                    throw new PersonException("Нельзя", value);
                                }
                                else
                                {
                                    age = value;
                                }
                            }
                        }
                    }
                        try
                        {
                            Person p = new Person() { Name = "Tom", Age = 13 };

                }
                        catch (PersonException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine($"Некорректное значение: {ex.Value}");
                        }

            Console.WriteLine("\tУрок 45: Обработка исключений");
                        try
                        {
                            //Место где может быть ошибка

                            string mess = Console.ReadLine();
                            if (mess.Length > 6)
                            {
                                throw new Exception("Длина строки больше 6 символов");
                            }
                        }
                        catch(Exception ex)
                        {
                            //Обработка ошибки
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        finally
                        {
                            //Завершающая операция вне зависимости от возниконовения ошибки
                        }   

                    Console.WriteLine("\tУрок 44: Ограничения обобщений");

                    class Account
            {
                public int ID { get; set; }
                public int Sum { get; set; }
                public Account(int _id)
                {
                    ID = _id;
                }
            }
            class Transaction<T> where T : Account
            {
                public T FromAccount { get; set; }
                public T ToAccount { get; set; }
                public int Sum { get; set; }
                public void Execute()
                {
                    if (FromAccount.Sum > Sum)
                    {
                        FromAccount.Sum -= Sum;
                        ToAccount.Sum += Sum;
                        Console.WriteLine($"{FromAccount.ID}: {FromAccount.Sum}\n" +
                            $"{ToAccount.ID}: {ToAccount.Sum}");
                    }
                }
            }

            Account acc1 = new Account(23) { Sum = 4500 };
            Account acc2 = new Account(55) { Sum = 5000 };

            Transaction<Account> t1 = new Transaction<Account>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 500
            };
            t1.Execute();

                        Console.WriteLine("\tУрок 43: Обобщения");
                        class Bank<T>
            {
                public T ID { get; set; }
                public int Sum { get; set; }
            }
            class Transaction<U, V>
            {
                public U FromAccount { get; set; }
                public U ToAccount { get; set; }
                public V Code { get; set; }
            }
            public static void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }
            //Bank
            Bank<int> bank1 = new Bank<int>(); // ID = int
            Bank<string> bank2 = new Bank<string>(); // ID = string
            bank1.ID = 5128;
                        bank2.ID = "Jen28";
                        int id_int = bank1.ID;
            int id_int_new = bank1.ID + 52;
            string id_string = bank2.ID;

            //Swap
            Console.WriteLine($"Bank1={id_int}, Bank2={id_int_new}");
                        Swap<int>(ref id_int, ref id_int_new);
                        Console.WriteLine($"Bank1={id_int}, Bank2={id_int_new}");
                        //Transaction
                        Bank<int> bank3 = new Bank<int>();
            Transaction<Bank<int>, string> transaction = new Transaction<Bank<int>, string>()
            {
                FromAccount = bank1,
                ToAccount = bank3,
                Code = "123321"
            };

            Console.WriteLine("\tУрок 42: Класс System.Object и его методы");
                        class Person
            {
                public string Name { get; set; }
                public override string ToString()
                {
                    if (String.IsNullOrEmpty(Name))
                        return base.ToString();
                    return Name;
                }
            }

            class Clock
            {
                public int Hours { get; set; }
                public int Minutes { get; set; }
                public int Seconds { get; set; }
                public override string ToString()
                {
                    return $"{Hours}:{Minutes}:{Seconds}";
                }
            }

            class Persona
            {
                public string Name { get; set; }

                public override int GetHashCode()
                {
                    return Name.GetHashCode();
                }
            }
            class Personо
            {
                public string Name { get; set; }
                public override bool Equals(object obj)
                {
                    if (obj.GetType() != this.GetType()) return false;

                    Personо person = (Personо)obj;
                    return (this.Name == person.Name);
                }
            }
            //base
            Person tom = new Person();
            Console.WriteLine(tom.ToString());
                        Person jenua = new Person { Name = "Jenua" };
            Console.WriteLine(jenua.ToString());
                        //ToString class
                        Clock clock = new Clock { Hours = 19, Minutes = 45, Seconds = 32 };
            Console.WriteLine(clock.ToString());
                        //ToString
                        int i = 5;
            double b = 3.2;
            Console.WriteLine($"i={i.ToString()}");
                        Console.WriteLine($"b={b.ToString()}");

                        Personо person1 = new Personо { Name = "Tom" };
            Personо person2 = new Personо { Name = "Bob" };
            Personо person3 = new Personо { Name = "Tom" };
            bool p1Ep2 = person1.Equals(person2);   // false
            bool p1Ep3 = person1.Equals(person3);   // true

            Person person = new Person { Name = "Tom" };
            Console.WriteLine(person.GetType());    // Person


                        Console.WriteLine("\tУрок 41: Абстрактные классы");
                        // абстрактный класс фигуры
                abstract class Figure
            {
                // абстрактный метод для получения периметра
                public abstract float Perimeter();
                // абстрактный метод для получения площади
                public abstract float Area();
            }
            // производный класс прямоугольника
            class Rectangle : Figure
            {
                public float Width { get; set; }
                public float Height { get; set; }

                public Rectangle(float width, float height)
                {
                    this.Width = width;
                    this.Height = height;
                }
                // переопределение получения периметра
                public override float Perimeter()
                {
                    return Width * 2 + Height * 2;
                }
                // переопрелеление получения площади
                public override float Area()
                {
                    return Width * Height;
                }
            }


            abstract class Person
            {
                public abstract string Name { get; set; }
            }

            class Client : Person
            {
                private string name;

                public override string Name
                {
                    get { return "Mr/Ms. " + name; }
                    set { name = value; }
                }
            }

            class Employee : Person
            {
                public override string Name { get; set; }
            }
            Figura rectangle = new Rectangle(5, 4, 34);
            rectangle.Display();

                    Console.WriteLine("\tУрок 40: Сокрытие. Ключевое слово new");
                         class Person
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public Person(string firstName, string lastName)
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

            class Employee : Person
            {
                public string Company { get; set; }
                public Employee(string firstName, string lastName, string company)
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
            Person person = new Person("Jenua", "Shunkevich");
            person.Display();
                        Employee employee = new Employee("Valik", "Pere", "BNTU");
            employee.Display();

                        Console.WriteLine("\tУрок 39: Виртуальные методы и свойства (Полиморфизм)");
                        class Person
            {
                public virtual string Name { get; set; }
                public Person(string name)
                {
                    Name = name;
                }
                public virtual void Display() // virtual позволяет переопределять данный метод или свойство в классах наследниках
                {
                    Console.WriteLine(Name);
                }
            }
            class Employee : Person
            {
                private string name;
                public string Company { get; set; }
                public Employee(string name, string company) : base(name)
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
            }
            Person person = new Person("Jene");
            Employee employee = new Employee("Jane", "BNTU");
            person.Display();
                        employee.Display();

                      Console.WriteLine("\tУрок 38: Перегрузка операций преобразования типов");
                     class Counter
            {
                public int Second { get; set; }
                public static implicit operator Counter(int x)
                {
                    return new Counter { Second = x };
                }
                public static explicit operator int(Counter counter)
                {
                    return counter.Second;
                }
                public static explicit operator Counter(Timer timer)
                {
                    int h = timer.Hours * 3600;
                    int m = timer.Minutes * 60;
                    return new Counter { Second = h + m + timer.Seconds };
                }
                public static implicit operator Timer(Counter counter)
                {
                    int h = counter.Second / 3600;
                    int m = (counter.Second - h * 3600) / 60;
                    int s = counter.Second - h * 3600 - m * 60;
                    return new Timer { Hours = h, Minutes = m, Seconds = s };
                }
            }
            class Timer
            {
                public int Hours { get; set; }
                public int Minutes { get; set; }
                public int Seconds { get; set; }

            }
            Counter counter = new Counter { Second = 115 };

            Timer timer = counter; //1:55
            Counter counter3 = (Counter)timer; //115
            Console.WriteLine($"H={timer.Hours},M={timer.Minutes},S={timer.Seconds},counter3={counter3.Second}");

                        int x = (int)counter; //Явное преобразование
            Counter counter2 = x; //Неявое преобразование

            byte y = (byte)x; //Явное преобразование
            int z = y; //Неявное преобразование
            Console.WriteLine($"x={x},y={y},z={z}");

                        Console.WriteLine("\tУрок 37: Преобразование типов");
                                 class Person
            {
                public string Name { get; set; }
                public Person(string name)
                {
                    Name = name;
                }
                public void Display()
                {
                    Console.WriteLine($"Person {Name}");
                }
            }

            class Employee : Person
            {
                public string Company { get; set; }
                public Employee(string name, string company) : base(name)
                {
                    Company = company;
                }
            }

            class Client : Person
            {
                public string Bank { get; set; }
                public Client(string name, string bank) : base(name)
                {
                    Bank = bank;
                }
            }
            Person person1 = new Employee("Jenua", "BNTU");
            Person person2 = new Client("Valik", "Bank-429");

            string bank = ((Client)person2).Bank;

            //1 способ преобразования
            Client client = person1 as Client; //если преобразование успешно, то ссылка, если нет, то null
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
                            Client clien = (Client)person1; //ошибка, так как Client - person2, а не person1
            string name2 = client.Name;
            Console.WriteLine(name2);
                        }
                        catch (InvalidCastException)
                        {
                            Console.WriteLine("Преобразование ошибки не удалось");
                        }
                        //3 способ преобразования

                        Person person = new Person("Tom");
                        if (person is Employee)
                        {
                            Employee emp = (Employee)person;
            Console.WriteLine(emp.Company);
                        }
                        else
                        {
                            Console.WriteLine("Преобразование is не удалось");
                        }

                    Console.WriteLine("\tУрок 36: Наследование");
                    Person p = new Person("Jenua", "Shinkevich");
            Employee emp = new Employee("Shunkevich", "Jenua", "BNTU");
            p.Display();
                    emp.Display();          
                    class Employee : Person //Person - базовый класс
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
            }
            class Person // sealed class Person - запрещает наследование от данного класса
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
                public Person(string name, string surname)
                {
                    _firstName = name;
                    _lastName = surname;
                }
            }

            Console.WriteLine("\tУрок 35: Перегразка индексаторов ");
                    class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
            }
            class People
            {
                Person[] data;
                public People()
                {
                    data = new Person[5];
                }
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
            }
            People people = new People();
            people[0] = new Person { Name = "Tum" };
                        people[1] = new Person { Name = "Bob" };
                        Console.WriteLine(people[0].Name);
                        Console.WriteLine(people["Bob"].Name);


                        Console.WriteLine("\tУрок 34: Индексаторы ");
                        class User
            {
                string name;
                string email;
                string phone;
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

            }
            User tom = new User();
            tom["name"] = "Tom";
                            Console.WriteLine(tom["name"]);
                        class Person
            {
                public string Name { get; set; }
            }
            class People
            {
                Person[] data;
                public People()
                {
                    data = new Person[5];
                }
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
            }
            People people = new People();
            people[1] = new Person { Name = "Tim" };
                            Person tom = people[1];
            Console.WriteLine(tom?.Name);
                        Console.WriteLine("\tУрок 33: null ");
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
            User user = new User();
            string CompanyName = user?.Phone?.Company?.Name ?? "не найдено значение";
            Console.WriteLine(CompanyName);
                            string str = null;
            string oba = str ?? "значение новое";

            Console.WriteLine("\tУрок 32: Перегрузка операторов");
                              class Counter
            {
                public int Value { get; set; }
                public static Counter operator /(Counter c1, Counter c2)
                {
                    return new Counter { Value = c1.Value / c2.Value };
                }
                public static int operator +(Counter c1, int val)
                {
                    return c1.Value + val;
                }
                public static Counter operator ++(Counter c1)
                {
                    return new Counter { Value = c1.Value + 10 };
                }
                public static bool operator true(Counter c1)
                {
                    return c1.Value != 0;
                }
                public static bool operator false(Counter c1)
                {
                    return c1.Value == 0;
                }
            }

            Console.WriteLine("\tУрок 31: Константы");
                            const double PI = 3.14;
            public readonly double k = 23;

            Console.WriteLine("\tУрок 30: Статические члены и модификатор static");
                                class Account
            {
                public Account(decimal sum, decimal rate)
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
            }

            Console.WriteLine("\tУрок 29: Перегрузка методов");
                            public void Add(int a, int b) { }
            public void Add(int a, int b, int c) { }
            public void Add(double a, double b) { }

            Console.WriteLine("\tУрок 28: Свойства");
                            class Personal
            {
                private string name;
                private int age;
                public string Name
                {
                    get
                    {
                        return name;
                    }
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
                    get
                    {
                        return $"{name}{age}";
                    }
                }
            }
            Personal Jenua = new Personal();
            Jenua.Age = 21;
                            Jenua.Name = "Jenua";
                            Console.WriteLine(Jenua.Fulla);


                            Console.WriteLine("\tУрок 27: Модификаторы доступа");
                            public int a; //Доступен везде
            private int b; //Доступен только в данном классе
            protected int c; //Доступен только в данном классе и в наследниках
            internal int d; //Доступен только в данном пространстве имён
            protected internal int e; //Доступен только в данном пространстве имён и в классах наследниках

            Console.WriteLine("\tУрок 26: Пространство имён");
                             using Hello.Account;
                              namespace Hello
            {
                class Program
                {

                }
                namespace Account
                {
                    class Account
                    {

                    }
                }
            }

            Console.WriteLine("\tУрок 25: Псевдонимы");
                            using printer = System.Console;
                            printer.WriteLine();

                            Console.WriteLine("\tУрок 24: Структуры");
                            struct Usa

                            public string name;
            public int age;
            public void Display()
            {
                Console.WriteLine($"age = {age};name ={name}");
            }
            Usa tom;
            tom.name = "Toma";
                            tom.age = 21;
                            tom.Display();

                            Console.WriteLine("\tУрок 23: Классы");
                            class Persona
            {
                public string name;
                public int age;
                public Persona() : this("Нет") { }
                public Persona(string name) : this(name, 18) { }
                public Persona(string name, int age) { this.name = name; this.age = age; }
                public void Show()
                {
                    Console.WriteLine($"Name = {name}; age = {age}");
                }

            }

            Persona bob = new Persona() { };
            Persona tom = new Persona() { name = "Tom" };
            Persona helli = new Persona() { name = "helli", age = 22 };
            tom.Show();
                            bob.Show();
                            helli.Show();

                            Console.WriteLine("\tУрок 22: Кортежи");
                            private static (int, string) GetSecretsValue()
            {
                var SecretsValue = (23, "Zenua");
                return SecretsValue;
            }
            private static (int sum, int cout) GetNuf(int[] massiv)
            {
                var results = (sum: 0, cout: 0);
                for (int i = 0; i < massiv.Length; i++)
                {
                    results.sum += massiv[i];
                    results.cout++;
                }
                return results;
            }

            private static (string name, int age) GetAnotherAge((string n, int a) personaj, int fu)
            {
                var results = (name: personaj.n, age: personaj.a + fu);
                return results;
            }

            var Prostoj = (1, "Tom");
            var Slojnij = (id: 1, name: "Tom");
            (string, int, double) Personaj = ("riki", 12, 32.2);
            var(namee, agee) = ("Tom", 23);

                            var(sum, cout) = GetNuf(new int[] { 1, 2, 3, 4, 5 });
                            Console.WriteLine("Summ=" + sum);
                            Console.WriteLine("Cout=" + cout);

                            var(name, age) = GetAnotherAge(("Jenua", 23), 32);
                            Console.WriteLine("Name=" + name);
                            Console.WriteLine("Age=" + age);


                        Console.WriteLine("\tУрок 21: Перечисление enum");
                        enum Operation
            {
                Add,
                Sub,
                Milti,
                Div
            }

            static void matSum(double x, double y, Operation op)
            {
                double res = 0;
                switch (op)
                {
                    case Operation.Add:
                        res = x + y; break;
                    case Operation.Div:
                        res = x - y; break;
                    case Operation.Milti:
                        res = x * y; break;
                    case Operation.Sub:
                        res = x / y; break;
                }
                Console.WriteLine(res);
            }

            matSum(2, 4, Operation.Add);
            matSum(2, 4, Operation.Div);
            matSum(2, 4, Operation.Milti);
            matSum(2, 4, Operation.Sub);

            Console.WriteLine("\tУрок 19: Рекурсивные функции");
                            static int Factorial(int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    return n * Factorial(n - 1);
                }
            }

            static int Fibonachi(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            }
            Console.WriteLine("Факториал - "+Factorial(4));
                            Console.WriteLine("Фибоначи - "+Fibonachi(4));

                            Console.WriteLine("\tУрок 18: Массив параметров и ключевое слово \"Params\"");
                            static void Addition(params int[] Masisv)
            {
                int Sum = 0;
                for (int i = 0; i < Masisv.Length; i++)
                {
                    Sum += Masisv[i];
                }
                Console.WriteLine($"Сумма элементов массива = {Sum}");
            }
            int[] massiv_in_Main = new int[] { 2, 4, 6, 8 };

            Addition();
            Addition(1, 2, 3, 4);
            Addition(massiv_in_Main);

            Console.WriteLine("\tУрок 17: Передача параметров по ссылке");

                            static void Peri(int a, int b)
            {
                a = a + b;
                Console.WriteLine($"a + b (обычная) = {a}");
            }
            static void PeriRef(ref int a, int b)
            {
                a = a + b;
                Console.WriteLine($"a + b (ref) = {a}");
            }
            static void Rerk(int a, int b, out int z)
            {

                z = a + b;
            }

            int z = 4;
            int b = 6;
            int aq;
            Console.WriteLine($"Изначальная z = {z}, b = {b}");
                            Rerk(z, b, out aq);
            Console.WriteLine($"aq before ref = {aq}");
                            Peri(z, b);

            Console.WriteLine($"z = {z}");
                            PeriRef(ref z, b);

            Console.WriteLine($"z = {z}");

                            Rerk(z, b, out aq);
            Console.WriteLine($"aq after ref = {aq}");

                            Console.WriteLine("\tУрок 16: Методы");
                            static void Prima()
            {
                int a = 5;
                int b = 6;
                if (a + b > 10)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("5+6 >10?");
                }
            }
            static void SayHello() => Console.WriteLine("It's work");
            Prima();
            SayHello();

            Console.WriteLine("\tУрок 15: Сортировка массива");

                            int[] num = new int[7];
                            for (int i = 0; i<num.Length; i++)
                            {
                                Console.Write("{0}-е число: ", i + 1);
                                num[i] = Int32.Parse(Console.ReadLine());

                            }
                            int temp;
                            for (int i = 0; i<num.Length - 1; i++)
                            {
                                for (int j = i + 1; j<num.Length; j++)
                                {
                                    if (num[i] > num[j])
                                    {
                                        temp = num[i];
                                        num[i] = num[j];
                                        num[j] = temp;
                                    }
                                }
                            }
                            for (int i = 0; i<num.Length; i++)
                            {
                                Console.WriteLine(num[i]);
                            }

                            Console.WriteLine("\tУрок 14: Инверсия массива");
                            int[] num = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int n = num.Length;
            int k = n / 2;
            int temp;
                            for (int i = 0; i<k; i++)
                            {
                                temp = num[i];
                                num[i] = num[n - i - 1];
                                num[n - i - 1] = temp;
                            }
                            foreach (int Nu in num)
                            {
                                Console.WriteLine(Nu);
                            }  

                            Console.WriteLine("\tУрок 13: Многомерные массивы");
                            int[,] num = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };

            int[][] numer = new int[3][];
            numer[0] = new int[2] { 1, 2 };
                            numer[1] = new int[3] { 1, 2, 3 };
                            numer[2] = new int[5] { 1, 2, 3, 4, 5 };

                            Console.WriteLine("\tУрок 12: Массивы и foreach"); 
                            int[] num = new int[4] { 1, 5, 3, 4 };
            int[] num2 = new int[] { 1, 2, 3, 4 };
            int[] num3 = new[] { 1, 2, 3, 4 };
            int[] num4 = { 1, 2, 3, 4 };
            int[] num5 = new int[4];
            num5[0] = 1;
                            num5[1] = 2;
                            num5[2] = 3;
                            num5[3] = 4;

                            foreach (int i in num)
                            {
                                Console.Write(i);
                            }
                            Console.WriteLine();
                            for (int i=0; i<num.Length;i++)
                            {
                                Console.Write(num[i]);
                            }

                            Console.WriteLine("\tУрок 11: Циклы");

                            int j = 0, k = 0;

                            for (int i = 0; i<9;i++)
                            {
                                Console.Write($"{i} ");
                            }
                            Console.WriteLine();

                            while (j<9)
                            {
                                Console.Write($"{j} ");
                                j++;
                            }
                            Console.WriteLine();

                            do
                            {
                                Console.Write($"{k} ");
                                k++;
                            }
                            while (k<9);
                            Console.WriteLine();

                            for (int i = 0; i< 9; i++)
                            {
                                Console.Write($"{i} ");
                                if (i == 5) break;
                            }

                            Console.WriteLine("\tУрок 10: Условные конструкции");
                            int num1 = 8;
            int num2 = 10;
                            if (num1<num2)
                            {
                                Console.WriteLine("8<10");
                            }
                            else
                            {
                                Console.WriteLine("8>10");
                            }

                            if (true)
                            {
                                Console.WriteLine("True");
                            }

                            string select = Console.ReadLine();
                            switch (select)
                            {
                                case "A":
                                    Console.WriteLine("A");
                                    break;
                                case "B":
                                    Console.WriteLine("B");
                                    break;
                                default:
                                    Console.WriteLine("Breake");
                                    break;
                            }

                            int num3 = 1;
                            switch (num3)
                            {
                                case 1:
                                    Console.WriteLine("1 case");
                                    goto case 5;
                                case 5:
                                    Console.WriteLine("5 case");
                                    break;
                                default:
                                    break;
                            }

                            Console.WriteLine("\tУрок 9: Условные выражения и логические операции");
                            int a = 10;
            int b = 15;
            bool c = a == b;
            bool c1 = a != b;
            bool c2 = a < b;
            bool c3 = a > b;
            bool c4 = a <= b;
            bool c5 = a >= b;
            Console.WriteLine($"a={a}, b={b}\n" +
                                $"a == b = {c}\n" +
                                $"a != b = {c1}\n" +
                                $"a < b = {c2}\n" +
                                $"a > b = {c3}\n" +
                                $"a <= b = {c4}\n" +
                                $"a >= b = {c5}\n");

                            bool x1 = (5 > 6) || (4 < 6);
            bool x2 = (5 > 6) || (4 > 6);
            bool x3 = (5 > 6) && (4 > 6);
            bool x4 = (5 < 6) && (4 < 6);
            bool Tru = true;
            bool Fal = !Tru;
            bool x5 = (5 > 6) ^ (4 < 6);
            bool x6 = (10 > 6) ^ (4 < 6);
            Console.WriteLine($"(5 > 6) || (4 < 6) = {x1}\n" +
                                $"(5 > 6) || (4 > 6) = {x2}\n" +
                                $"(5 > 6) && (4 > 6) = {x3}\n" +
                                $"(5 < 6) && (4 < 6) = {x4}\n" +
                                $"(5 > 6) ^ (4 < 6) = {x5}\n" +
                                $"(5 > 6) || (4 > 6) = {x6}\n" +
                                $"Tru = true   - {Tru} \n" +
                                $"Fal = !Tru   - {Fal}");

                            Console.WriteLine("\tУрок 8: Операции присваивания");
                            int a = 10;
            Console.WriteLine($"a={a}\n" +
                                              $"a+=10 -> {a += 10}, сброс до {a = 10}\n" +
                                              $"a-=10 -> {a -= 10}, сброс до {a = 10}\n" +
                                              $"a*=10 -> {a *= 10}, сброс до {a = 10}\n" +
                                              $"a/= 10 -> {a /= 10}, сброс до {a = 10}\n" +
                                              $"a%= 10 -> {a %= 10}, сброс до {a = 10}\n" +
                                              $"a&= 10 -> {a &= 10}, сброс до {a = 10}\n" +
                                              $"a|= 10 -> {a |= 10}, сброс до {a = 10}\n" +
                                              $"a^= 10 -> {a ^= 10}, сброс до {a = 10}\n" +
                                              $"a<<= 2 -> {a <<= 2}, сброс до {a = 10}\n" +
                                              $"a>>= 2 -> {a >>= 2}\n");

                            Console.WriteLine("\tУрок 7: Поразрядные операции");
                            int x1 = 2;
            int x2 = 4;
            int y = 5;
            Console.WriteLine($"x1={x1}, x2={x2}, y={y}\n" +
                                              $"x1&y = {x1&y}\n" +
                                              $"x2&y = {x2 & y}\n" +
                                              $"x1|y = {x1 | y}\n" +
                                              $"x2|y = {x2 | y}\n" +
                                              $"~x1+1 = {~x1+1}\n" +
                                              $"~x2+1 = {~x2+1}\n" +
                                              $"~y+1 = {~y+1}\n");
                            int x = 45;
            int key = 102;
            int encrypt = x ^ key;
            Console.WriteLine($"Исходное число:{x}, ключ:{key}");
                            Console.WriteLine($"Зашифрованное число:{encrypt}");
                            Console.WriteLine($"Расшифрованное число:{encrypt ^ key}");

                            Console.WriteLine("\tУрок 6: Преобразование строк");
                            string s = "54";
            int res;
                            try
                            {
                                int a = int.Parse(s);
            Console.WriteLine("Конвертация Parse прошла успешно. ");
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Ошибка при конвертации Parse.");
                            }

                            bool result = int.TryParse(s, out res);
                            if (result)
                            {
                                Console.WriteLine("Конвертация TryParse прошла успешно.");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка при конвертации TryParse.");
                            }

                            Console.WriteLine("\tУрок 5: Арифметические операции");
                            int a = 18;
            int b = 10;
            int a1 = 18;
            int a2 = 18;
            Console.WriteLine($"a={a}, b={b}\n"+
                                              $"a+b={a+b}\n"+
                                              $"a-b={a-b}\n" +
                                              $"a/b={a/b}\n" +
                                              $"a*b={a*b}\n" +
                                              $"a%b={a%b}\n" +
                                              $"a++={a++}\n" +
                                              $"a--={a--}\n" +
                                              $"++a={++a}\n" +
                                              $"--a={--a}\n" +
                                              $"++a-b={++a2-b}\n" +
                                              $"(a++)-b={(a1++)-b}");

                            Console.WriteLine("\tУрок 4: Конвертация строк");
                            string bolcon = "true";
            string bolcon2 = "2";
            Convert.ToBoolean(bolcon);
                            Convert.ToInt32(bolcon2);
                            Console.Write("Введите целое число:");
                            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1)Возраст (значение типа int) = {age}\n" +
                                              $"2)Значение boolean = " + Convert.ToBoolean(bolcon));

                            Console.WriteLine("\tУрок 3: Вывод текста");
                            string name = "Jenua";
            int age = 22;
            Console.WriteLine($"1)Моё имя {name}, мой возраст {age}");
                            Console.WriteLine("2)Моё имя {0}, мой возраст {1}",name,age); 

                            Console.WriteLine("\tУрок 2: Типы данных");
                            bool isActive = true;
            bool isPassiv = false;
            byte byt = 255;
            sbyte sbytPlu = 127;
            sbyte sbytMin = -128;
            short shPlu = 32767;
            short shMin = -32768;
            ushort ush = 65535;
            int integerPL = 2147483647;
            int integerMin = -2147483648;
            uint uinteger = 4294967295;
            long lonPlu = 9223372036854775807;
            long lonMin = -9223372036854775808;
            ulong ulon = 18446744073709551615;
            float floPlu = 340000000000000000000000000000000000000.9F;
            float floMin = -150000000000000000000000000000000000000.9F;
            double douPlu = 1.7E+308;
            double douMin = 5.0E-324;
            char ch = 'c';
            string stri = "string";
            object obj = 9;
            object obj2 = "stroka";
            Console.WriteLine($"1) bool : {isActive} or {isPassiv}\n" +
                                              $"2) byte : 0.. {byt}\n" +
                                              $"3) sbyte : {sbytMin}..{sbytPlu}\n" +
                                              $"4) short : {shMin}..{shPlu}\n" +
                                              $"5) ushort : 0..{ush}\n" +
                                              $"6) int : {integerMin}..{integerPL}\n" +
                                              $"7) uint : 0..{uinteger}\n" +
                                              $"8) long : {lonMin}..{lonPlu}\n" +
                                              $"9) ulong : 0..{ulon}\n" +
                                              $"10) float : {floMin}..{floPlu}\n" +
                                              $"11) double : {douMin}..{douPlu}\n" +
                                              $"12) char : любой символ Unicode (например - {ch})\n" +
                                              $"13) string : любая строка ( например - {stri})\n" +
                                              $"14) object : значение любого типа (например - {obj} или {obj2})");

                            Console.WriteLine("\tУрок 1: Литералы");
                            double expPL = 3.2E3;
            double expMIN = 3.2E-3;
            int dv3 = 0b11;
            int dv11 = 0b1011;
            int sh10 = 0x0A;
            int sh255 = 0x0FF;
            int sh161 = 0xA1;
            Console.WriteLine($"Экспоненциафльная форма 3.2E3: {expPL}\nЭкспоненциафльная форма 3.2E-3: {expMIN}\nДвоичная форма 11: {dv3}\nДвоичная форма 1011: {dv11}\nШестнадцатеричная форма 0A: {sh10}\nШестнадцатеричная форма FF: {sh255}\nШестнадцатеричная форма A1: {sh161}\n");
                            Console.WriteLine("1)Табуляция(\"t\")\t и перенос строки (\"n\")\n2)Предложение в \"Кавычках\"");
            */


            Console.ReadKey();
        }
    }
}

