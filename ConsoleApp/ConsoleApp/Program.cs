using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
       
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tУрок 71:  Класс StringBuilder");
            /* 
           
             Console.WriteLine("\tУрок 70:  Форматирование и интерполяция строк");
            Person person = new Person { Name = "Jen", Age = 12};
            string output = ($"Имя: {person.Name}  Возраст: {person.Age}");
            Console.WriteLine(output);
            decimal number = 0.15345m;
            Console.WriteLine($"{number:P}");// 15.3%
            //формат 
            long number1 = 19876543210;
            string result = String.Format("{0:+# (###) ###-##-##}", number1);
            Console.WriteLine(result); // +1 (987) 654-32-10
            // условие ?? по умолчанию
            person = null;
            string output2 = $"{person?.Name ?? "Имя по умолчанию"}";  
            Console.WriteLine(output2);
            //добавление пробелов 
            Console.WriteLine($"Имя: {person.Name,-5} Возраст: {person.Age}"); // пробелы после
            Console.WriteLine($"Имя: {person.Name,5} Возраст: {person.Age}"); // пробелы до
            Console.WriteLine("\tУрок 69:  Класс String и операции со строками");
            //0. Объявление строк
            string s1 = "hello";
            string s2 = null;
            string s3 = new String('a', 6); // результатом будет строка "aaaaaa"
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            //1. Конкатенация
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // результат: строка "hello world"
            string s4 = String.Concat(s3, "!!!"); // результат: строка "hello world!!!"
             Console.WriteLine(s4);
            //2. Сложная конкатенация string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            String s10 = String.Join(" ", values);  // результат: строка "apple a day keeps a doctor away"
            //3. Сравнение строк
            string s1 = "hello";
            string s2 = "world";
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }     // результатом будет "Строка s1 перед строкой s2"
            //4. Поиск в строке
            string s1 = "hello world";
            char ch = 'o';
            int indexOfChar = s1.IndexOf(ch); // равно 4
            Console.WriteLine(indexOfChar);
            string subString = "wor";
            int indexOfSubstring = s1.IndexOf(subString); // равно 6
            Console.WriteLine(indexOfSubstring);
            //5. начинается или заканчивается ли строка на определенную подстроку
            string path = @"C:\SomeDir";
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".exe"))
                    File.Delete(files[i]);
            }
            //6. Разделение строк
            string text = "И поэтому все так произошло";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            //7. Обрезка строки
            string text = " hello world ";
            text = text.Trim(); // результат "hello world"
            text = text.Trim(new char[] { 'd', 'h' }); // результат "ello worl"
            //8. Обрезать определенную часть строки позволяет функция Substring
            string text = "Хороший день";// обрезаем начиная с третьего символа
            text = text.Substring(2);// результат "роший день"
            Console.WriteLine(text);// обрезаем сначала до последних двух символов
            text = text.Substring(0, text.Length - 2);// результат "роший де"
            Console.WriteLine(text);
            //9. Вставка
            string text = "Хороший день";
            string subString = "замечательный ";
            text = text.Insert(8, subString);
            Console.WriteLine(text);
            //10. Удаление строк
            string text = "Хороший день";// индекс последнего символа
            int ind = text.Length - 1;// вырезаем последний символ
            text = text.Remove(ind);
            Console.WriteLine(text);// вырезаем первые два символа
            text = text.Remove(0, 2);
            //11. Замена
            string text = "хороший день";
            text = text.Replace("хороший", "плохой");
            Console.WriteLine(text);
            text = text.Replace("о", "");
            Console.WriteLine(text);
            //12. Смена регистра
            string hello = "Hello world!";
            Console.WriteLine(hello.ToLower()); // hello world!
            Console.WriteLine(hello.ToUpper()); // HELLO WORLD!
            
            Console.WriteLine("\tУрок 68:  Итераторы и оператор yield");
            class Numbers
            {
                public IEnumerator GetEnumerator()
                {
                    for (int i = 0; i < 6; i++)
                    {
                    yield return i;
                    }
                }
            }
            class Books
            {
                public Books(string name)
                {
                    Name = name;
                }
                public string Name { get; set; }
            }
            class Library
            {
                private Books[] books;
                public Library()
                {
                    books = new Books[] { new Books("Красная таблетка"), new Books("Славный парень") };
                }
                public int Lenght
                {
                    get { return books.Length; }
                }
                public IEnumerator GetEnumerator()
                {
                    for (int i = 0; i < Lenght; i++)
                    {
                        yield return books[i];
                    }
                }
            }
            //1 example
            Numbers numbers = new Numbers();
                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }
                //2 example
                Library library = new Library();
                foreach (Books b in library)
                {
                    Console.WriteLine(b.Name);
                }

                Console.WriteLine("\tУрок 67:  Коллекция Dictionary<T, V>");
                 class Person
            {
                public string Name { get; set; }
            }
            Console.WriteLine("1 Пример:");
                Dictionary<int, string> countries = new Dictionary<int, string>();
                countries.Add(1, "Russia");
                countries.Add(3, "Great Britain");
                countries.Add(2, "USA");
                countries.Add(4, "France");
                countries.Add(5, "China");
                countries[11] = "Volgardia";
                //KeyValuePair<TKey, TValue> - объект структуры
                foreach (KeyValuePair<int,string> item in countries)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
                //Получение элемента по ключу
                Console.WriteLine($"4 элемент по ключу = {countries[4]}");
                // Изменение объекта по ключу
                countries[4] = "Belarus";
                Console.WriteLine($"4 элемент по ключу после изменения = {countries[4]}");
                //Удаление по ключу
                countries.Remove(2);
                Console.WriteLine($"2 элемент по ключу удалён");

                //2 пример
                Console.WriteLine("2 Пример:");
                Dictionary<char, Person> peoples = new Dictionary<char, Person>();
                peoples.Add('E', new Person() { Name = "Evgeniy" });
                peoples.Add('V', new Person() { Name = "Valentin" });
                peoples.Add('A', new Person() { Name = "Aleksandr" });
                peoples['J'] = new Person() { Name = "Jordj" };
                // перебор ключей
                foreach (char c in peoples.Keys)
                {
                    Console.WriteLine(c);
                }

                // перебор по значениям
                foreach (Person p in peoples.Values)
                {
                    Console.WriteLine(p.Name);
                }

                Console.WriteLine("\tУрок 66:  Коллекция Stack<T>");
                  class Person
            {
                public string Name { get; set; }
            }
            Stack<int> numbers = new Stack<int>();

                numbers.Push(3); // в стеке 3
                numbers.Push(5); // в стеке 5, 3
                numbers.Push(8); // в стеке 8, 5, 3

                // так как вверху стека будет находиться число 8, то оно и извлекается
                int stackElement = numbers.Pop(); // в стеке 5, 3
                Console.WriteLine(stackElement);

                Stack<Person> persons = new Stack<Person>();
                persons.Push(new Person() { Name = "Tom" });
                persons.Push(new Person() { Name = "Bill" });
                persons.Push(new Person() { Name = "John" });

                foreach (Person p in persons)
                {
                    Console.WriteLine(p.Name);
                }

                // Первый элемент в стеке
                Person person = persons.Pop(); // теперь в стеке Bill, Tom
                Console.WriteLine(person.Name);

                Console.ReadLine();

                Console.WriteLine("\tУрок 65:  Очередь Queue<T>");
                 class Person
            {
                public string Name { get; set; }
            }

            Queue<int> numbers = new Queue<int>();
                numbers.Enqueue(3); // очередь 3
                numbers.Enqueue(5); // очередь 3, 5
                numbers.Enqueue(8); // очередь 3, 5, 8
                // получаем первый элемент очереди
                int queueFirst = numbers.Dequeue();
                Console.WriteLine($"Ваш элемент - {queueFirst}"); //теперь очередь 5, 8


                Queue<Person> people = new Queue<Person>();
                people.Enqueue(new Person() { Name = "Evjen" });
                people.Enqueue(new Person() { Name = "Oleg" });
                people.Enqueue(new Person() { Name = "Aleks" });
                // получаем первый элемент без его извлечения
                Person pp = people.Peek();
                Console.WriteLine($"Без удаления - {pp.Name}");
                Console.WriteLine("Сейчас в очереди {0} человека:", people.Count);
                // теперь в очереди 3 человека
                foreach (Person p in people)
                {
                    Console.WriteLine(p.Name);
                }

                // Извлекаем первый элемент в очереди - Tom
                Person person = people.Dequeue(); // теперь в очереди 2 человека
                Console.WriteLine($"C удалением из очереди - {pp.Name}");
                Console.WriteLine("Сейчас в очереди {0} человека", people.Count);

                Console.WriteLine("\tУрок 64:  Список List<T>");
                   class Person
                {
                    public string Name { get; set; }
                }

                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                Console.WriteLine($"Добавляет элемент 6");
                numbers.Add(6);
                Console.WriteLine($"Добавляет элементы 7 8 9");
                numbers.AddRange(new int[] { 7, 8, 9 });
                Console.WriteLine($"Заменяет 0 элемент на 666");
                numbers.Insert(0, 666);
                Console.WriteLine($"Удаляем 1 элемент ");
                numbers.RemoveAt(1);
                Console.Write($"Перебираем массив чисел:");
                foreach (var item in numbers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                List<Person> people = new List<Person>();
                people.Add(new Person() { Name = "jenua" });
                people.Add(new Person() { Name = "valentin" });
                people.Add(new Person() { Name = "aleksandr" });
                people.Add(new Person() { Name = "Forniy" });
                Console.Write("Работаем с именами людей: ");
                foreach (var item in people)
                {
                    Console.Write($"{item.Name} ");
                }

                Console.WriteLine("\tУрок 63: Глава 9: Коллекции. ArrayList");
                ArrayList arrayList = new ArrayList();
                arrayList.Add(5);
                arrayList.Add(4.5);
                arrayList.AddRange(new string[] { "Hello", "world" });
                //Перебор значений
                Console.Write("Значения в массиве:");
                foreach (var item in arrayList)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                //удаляем 1 элемент
                Console.WriteLine($"Удаляем элемент: {arrayList[0]}");
                arrayList.RemoveAt(0);
                //переворачивем список
                Console.WriteLine("Переворачиваем массив");
                arrayList.Reverse();
                //Перебор значений через for
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Console.WriteLine($"{i}){arrayList[i]}");
                }
                //получение элемента по индексу
                Console.WriteLine("0 элемент - "+arrayList[0]);

                Console.WriteLine("\tУрок 62: Ref");
                static ref int Find(int[] numbers, int number)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == number)
                        {
                            return ref numbers[i];
                        }
                    }
                    throw new Exception("Число не найдено");
                }
                int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                ref int nRef = ref Find(numbers, 3); //numbers[2]
                Console.WriteLine(Find(numbers, 3));
                Console.WriteLine("\tУрок 61: Nullable");
                    struct State
            {
                public string Name { get; set; }
            }
            //Значемые
            int? a = null;
                a = 5;
                // Класс с ошибкой
                try
                {
                    State? StateNullable = null;
                    if (StateNullable.HasValue == true)
                    {
                        State state = StateNullable.Value;
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                // Класс без ошибки
                try
                {
                    State? StateNullable = new State { Name = "Narnia"};
                    if (StateNullable.HasValue == true)
                    {
                        State state = StateNullable.Value;
                        Console.WriteLine(state.Name);
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                 Console.WriteLine("\tУрок 60: Деконструкторы");
                class MyClass
            {
                public int Age { get; set; }
                public string Name { get; set; }
                public MyClass(int age, string name)
                {
                    Age = age;
                    Name = name;
                }
                //Объявление деконструктора  * public void Deconstruct(out тип имя) * 
                public void Deconstruct(out int age, out string name)
                {
                    name = this.Name;
                    age = this.Age;
                }
            }
            //Реализация деконструктора
            MyClass myClass = new MyClass(21, "Jenue");
            (int age, string name) = myClass;
                Console.WriteLine($"name {name}");
                Console.WriteLine($"age {age}");

                Console.WriteLine("\tУрок 59: Локальные функции");
                static int GetResult(int[] numbers)
                {
                    int limit = 0;
                    //локальная функция
                    bool isMoreThen(int number)
                    {
                        return number > limit;
                    }
                    //summ
                    int result = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (isMoreThen(numbers[i]))
                        {
                            result += numbers[i];
                        }

                    }
                    return result;
                }
                var result = GetResult(new int[] { 3, 2, 1, 3, 2, -2 }); 
                 Console.WriteLine("\tУрок 58: Анонимные типы");
                //Одиночные
                var user = new { Name = "Tom", Age = 34 };
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Age);

                Console.WriteLine();
                //Массивы
                var people = new[]
                {
                    new {Name ="Tom", Age =23},
                     new {Name ="Fas", Age =41},
                      new {Name ="DAS", Age =12}
                };
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }


                Console.WriteLine("\tУрок 57: Частичные классы");
                //1 кусочек класса
             public partial class Client
            {
                public void Eat()
                {
                    Console.WriteLine("I am eat");
                }

            }
            //2 кусочек класса
            public partial class Client
            {
                public void Move()
                {
                    Console.WriteLine("I am moving");
                }
            }
            //1 и 2 кусочки объединяются
            Client client = new Client();
                client.Eat();
                client.Move();

                 Console.WriteLine("\tУрок 56: Поиск символа в строке");

                    public static class StringExtension
            {
                public static int CharCount(this string str, char c)
                {
                    int counter = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == c)
                            counter++;
                    }
                    return counter;
                }
            }

            string s = "Привет мир люди, ав";
                char c = 'и';
                int i = s.CharCount(c);
                Console.WriteLine(i);

                Console.Read();

                 Console.WriteLine("\tУрок 55: Интерфейс сортировки IComparable");
                  class Person : IComparable
            {
                public int Age { get; set; }
                public string Name { get; set; }
                public int CompareTo(object obj)
                {
                    Person p = obj as Person;
                    if (p != null)
                    {
                        return this.Name.CompareTo(p.Name);
                    }
                    else
                    {
                        throw new Exception("Невозможно отсортировать");
                    }
                }
            }
            Person p1 = new Person { Name = "Jaq", Age = 23 };
                Person p2 = new Person { Name = "Gd", Age = 23 };
                Person p3 = new Person { Name = "Fas", Age = 23 };
                Person p4 = new Person { Name = "Русский", Age = 23 };
                Person p5 = new Person { Name = "НеРусский", Age = 23 };
                Person p6 = new Person { Name = "21", Age = 23 };
                Person p7 = new Person { Name = "19", Age = 23 };
                Person[] people = new Person[] { p1, p2, p3, p4, p5,p6,p7 };
                Array.Sort(people);
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }

                Console.WriteLine("\tУрок 54: Интерфейсы в обобщениях");
                interface IAccount
            {
                int CurentSum { get; }
                void Put(int sum);
                void Withdraw(int sum);
            }
            interface IClient
            {
                string Name { get; set; }
            }
            class Client : IAccount, IClient
            {
                public string Name { get; set; }
                int _sum;

                public Client(string name, int money)
                {
                    Name = name;
                    _sum = money;
                }

                public int CurentSum { get { return _sum; } }

                public void Put(int sum)
                {
                    _sum += sum;
                }

                public void Withdraw(int sum)
                {
                    if (_sum > sum)
                    {
                        _sum -= sum;
                    }
                }
            }
            class Transaction<T> where T : IAccount, IClient
            {
                public void Operation(T acc1, T acc2, int sum)
                {
                    acc1.Withdraw(sum);
                    acc2.Put(sum);
                    Console.WriteLine($"{acc1.Name}:{acc1.CurentSum} - {acc2.Name}:{acc2.CurentSum}");

                }
            }
            Client jane = new Client("Jane", 1000);
                Client aleks = new Client("Aleksandr", 2000);
                Transaction<Client> transaction = new Transaction<Client>();   
                transaction.Operation(jane, aleks, 300);

                 Console.WriteLine("\tУрок 53: Интерфейсы");
                interface IHuman
            {
                string Name { get; set; }
                void Hello();
            }
            interface IAlien
            {
                string Name { get; set; }
                void Hello();
            }
            class Human : IHuman
            {
                public Human(string name)
                {
                    nameHuman = name;
                }
                string nameHuman;
                public string Name { get => nameHuman; set => nameHuman = value; }
                public void Hello()
                {
                    Console.WriteLine($"I am Human, my name is:{nameHuman}");
                }
            }
            class Child : IHuman
            {
                public Child(string name)
                {
                    nameChild = name;
                }
                string nameChild;
                public string Name { get => nameChild; set => nameChild = value; }

                public void Hello()
                {
                    Console.WriteLine($"I am Child, my name is:{nameChild}");
                }
            }
            class Alien : IAlien
            {
                public Alien(string name)
                {
                    nameAlien = name;
                }
                string nameAlien;
                public string Name { get => nameAlien; set => nameAlien = value; }

                public void Hello()
                {
                    throw new NotImplementedException();
                }
            }
            class Turell
            {
                public void WhoIsThis(object unknown)
                {
                    if (unknown is IHuman)
                    {
                        Skip(unknown as IHuman);
                    }
                    else
                    {
                        DestroyObject(unknown as IAlien);
                    }
                }
                public void DestroyObject(IAlien alien)
                {
                    Console.WriteLine($"Это {alien.GetType().Name}, его имя {alien.Name}");
                }
                public void Skip(IHuman human)
                {
                    Console.WriteLine($"People is {human.Name} - {human.GetType().Name}");
                }
            }
            Human human = new Human("Jena");
                Child child = new Child("Sanua");
                Alien alien = new Alien("Vrag");
                Turell turell = new Turell();
                turell.WhoIsThis(human);
                turell.WhoIsThis(child);
                turell.WhoIsThis(alien);

                Console.WriteLine("\tУрок 52:Ковариантность и контравариантность делегатов");
                class Person
            {
                public string Name { get; set; }
            }
            class Client : Person
            {

            }
            delegate Person Personoj(string name);
            private static Client BuiltClient(string name)
            {
                return new Client { Name = name };
            }
            Personoj personoj;
                personoj = BuiltClient;
                Client p = BuiltClient("Jan");

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

