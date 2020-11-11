using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;
using System.Threading;

namespace ConsoleApp
{
   
    class NewLesson 
    {
        

        static void Main(string[] args)
        {





            /* 
           Console.WriteLine("\tУрок 85: Таймеры");
            int num = 10;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 2000);
            public static void Count(object obj)
            {
                int x = (int)obj;
                for (int i = 1; i < 9; i++, x++)
                {
                    Console.WriteLine($"{x * i}");
                }
            }
            Console.WriteLine("\tУрок 84: Семафоры");
                for (int i = 1; i < 6; i++)
                {
                    Reader reader = new Reader(i);
                }
                 class Reader
            {
                // создаем семафор
                static Semaphore sem = new Semaphore(3, 3);
                Thread myThread;
                int count = 3;// счетчик чтения

                public Reader(int i)
                {
                    myThread = new Thread(Read);
                    myThread.Name = $"Читатель {i.ToString()}";
                    myThread.Start();
                }

                public void Read()
                {
                    while (count > 0)
                    {
                        sem.WaitOne();

                        Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                        Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                        Thread.Sleep(1000);

                        Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                        sem.Release();

                        count--;
                        Thread.Sleep(1000);
                    }
                }
            }
                Console.WriteLine("\tУрок 83: Мьютексты");
            static Mutex mutexObj = new Mutex();
            static int x = 0;
            public static void Count()
            {
                mutexObj.WaitOne();
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
                mutexObj.ReleaseMutex();
            }
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }
            Console.WriteLine("\tУрок 82: Класс AutoResetEvent");
            static AutoResetEvent waitHandler = new AutoResetEvent(true);
            static int x = 1;
            public static void Count()
            {
                waitHandler.WaitOne();
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                     Thread.Sleep(100);
                }
                waitHandler.Set();
            }
            for (int i = 1; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Поток {i.ToString()}";
                myThread.Start();
            }

            Console.WriteLine("\tУрок 81: Синхронизация. Ключевое слово lock");

            static int x = 0;
            static object locker = new object();
            public static void Count()
            {
                lock (locker)
                {
                    x = 1;
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                    }
                }

            }

            for (int i = 1; i < 9; i++)
            {
                Thread thread = new Thread(Count);
                thread.Name = "Поток " + i.ToString();
                thread.Start();
            }
             Console.WriteLine("\tУрок 80: Потоки с параметрами");
             class Counter
        {
            private int x;
            private int y;
            public Counter(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }
            public void Count()
            {
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine($"Второй поток i*x*y={i * x * y}");
                    Thread.Sleep(400);
                }
            }
        }
        public static void Count(object x)
        {
            for (int i = 1; i < 9; i++)
            {
                int n = (int)x;
                Console.WriteLine($"Первый поток i*n={i * n}");
                Thread.Sleep(400);
            }
        }
        //1 поток
        int number = 5;
            Thread thread1 = new Thread(new ParameterizedThreadStart(Count));
            thread1.Start(number);

            //2 поток
            Counter counter = new Counter(2, 5);
            Thread thread2 = new Thread(counter.Count);
            thread2.Start();
            Console.WriteLine("\tУрок 79: Создание потоков");
            public static void Count()
            {
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("Второй поток:");
                    Thread.Sleep(400);
                }
            }
            public static void Count2()
            {
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("Третий поток:");
                    Thread.Sleep(500);
                }
            }
            Thread thread = new Thread(Count);
            Thread thread2 = new Thread(Count2);

            thread.Start();
            thread2.Start();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Первый поток:");

                Thread.Sleep(400);
            }
            Console.WriteLine("\tУрок 78:  Потоки");

            Thread t = Thread.CurrentThread;// получаем текущий поток
            Console.WriteLine($"Имя потока до Name: {t.Name}");//получаем имя потока
            t.Name = "Метод Main";
            Console.WriteLine($"Имя потока после Name: {t.Name}");
            Console.WriteLine($"CurrentCulture: {t.CurrentCulture}");
            Console.WriteLine($"Фоновый ли поток: {t.IsBackground}");
            Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");
            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}"); // получаем домен приложения
            Console.WriteLine("\tУрок 77:  Span");
            //Example 1
            string[] people = new string[] { "Tom", "Bob", "Jorj" };
            Span<string> peopleSpan = people; //Span<string> peopleSpan = new Span<string>(people);
            peopleSpan[1] = "Ann";              // переустановка значения элемента
            Console.WriteLine(peopleSpan[2]);   // получение элемента
            Console.WriteLine(peopleSpan.Length);   // получение длины Span
            foreach (var s in peopleSpan) // перебор Span
            {
                Console.WriteLine(s);
            }
            //Example 2
            int[] temperatures = new int[]
            {
                10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
                18, 16, 15, 16, 17, 14,  9,  8, 10, 11,
                12, 14, 15, 15, 16, 15, 13, 12, 12, 11
            };
            Span<int> temperaturesSpan = temperatures;
            Span<int> firstDecade = temperaturesSpan.Slice(0, 10);    // нет выделения памяти под данные
            Span<int> lastDecade  = temperaturesSpan.Slice(20, 10);   // нет выделения памяти под данные
            Console.WriteLine("\tУрок 76:  Array");
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            Array.Reverse(numbers);       // расположим в обратном порядке                 
            Array.Resize(ref numbers, 4); // уменьшим массив до 4 элементов
            foreach (int number in numbers)
            {
                Console.Write($"{number} \t");
            }
            int[] numbers2 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int[] numbers3 = new int[5];
            Array.Copy(numbers2, 2, numbers3, 0, 5);// копируем из numbers с 2-го индекса 5 элементов и поместим их в массив numbers2, начиная с 0-го индекса
            foreach (int number in numbers3)
            {
                Console.Write($"{number} \t");
            }
            Console.WriteLine();
            Array.Sort(numbers2);
            foreach (int number in numbers2)
            {
                Console.Write($"{number} \t");
            }
            Console.WriteLine("\tУрок 75:  Convert");
            //Parse
            int a = int.Parse("21");
            Console.WriteLine($"int a = {a}, ++a = {++a}");
            double b = double.Parse("21,12");
            Console.WriteLine($"double b = {b}, ++b = {++b}");
            byte c = byte.Parse("3");
            Console.WriteLine($"byte c = {c}, ++c = {++c}");
            //Задание формата
            IFormatProvider format = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double fo = double.Parse("12,21", format);
            double ro = double.Parse("12.21", format);
            Console.WriteLine($",={fo} ; .={ro}");
            //TryParse
            double number;
            bool result = double.TryParse("21", out number);
            if (result)
            {
                Console.WriteLine($"Top {number}");
            }
            else
            {
                Console.WriteLine($"Lose {number}");
            }
            //Convert 
             int n = Convert.ToInt32("23");
            bool b = true;
            double d = Convert.ToDouble(b);
            Console.WriteLine($"n={n}  d={d}");
            int fg = Convert.ToInt32("12");
            Console.WriteLine("\tУрок 74:  Math");
            double result = Math.Abs(-12.4); // 12.4
            double result2 = Math.BigMul(100, 9340); // 934000
            double result3 = Math.Floor(2.56); // 2
            double result4 = Math.Ceiling(2.34); // 3
            double result5 = Math.IEEERemainder(26, 4);
            double result6 = Math.Round(20.56); // 21
            double result7 = Math.Round(20.46); //20
            double result8 = Math.Sqrt(16); // 4
            double result9 = Math.Truncate(16.89); // 16
            double result10 = Math.E;
            double result11 = Math.PI;
            int result12 = Math.Sign(15); // 1
            int result13 = Math.Sign(-5); //-1
            Console.WriteLine("\tУрок 73:  Форматирование даты и времени");
            DateTime now = DateTime.Now;
            Console.WriteLine("D: " + now.ToString("D"));
            Console.WriteLine("d: " + now.ToString("d"));
            Console.WriteLine("F: " + now.ToString("F"));
            Console.WriteLine("f: {0:f}", now);
            Console.WriteLine("G: {0:G}", now);
            Console.WriteLine("g: {0:g}", now);
            Console.WriteLine("M: {0:M}", now);
            Console.WriteLine("O: {0:O}", now);
            Console.WriteLine("o: {0:o}", now);
            Console.WriteLine("R: {0:R}", now);
            Console.WriteLine("s: {0:s}", now);
            Console.WriteLine("T: {0:T}", now);
            Console.WriteLine("t: {0:t}", now);
            Console.WriteLine("U: {0:U}", now);
            Console.WriteLine("u: {0:u}", now);
            Console.WriteLine("Y: {0:Y}", now);
            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd.MM.yyyy"));
            Console.WriteLine("\tУрок 72:  Работа с датами и временем");
            DateTime date = new DateTime(2015,11,15,15,14,51); // год - месяц - день - час - минута - секунда
            Console.WriteLine(date);
            Console.WriteLine(DateTime.Now); //Сейчас - время компьютера
            Console.WriteLine(DateTime.UtcNow); //дата и время относительно времени по Гринвичу (GMT)
            Console.WriteLine(DateTime.Today); // Только текущая дата
            //Операции с датой
            DateTime date5 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            Console.WriteLine(date5.AddHours(3)); // 20.07.2015 21:30:25
            DateTime date3 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            DateTime date4 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
            Console.WriteLine(date3.Subtract(date4)); // 03:00:00
            //Форматировние
            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25);
            Console.WriteLine(date1.ToLocalTime()); // 20.07.2015 21:30:25
            Console.WriteLine(date1.ToUniversalTime()); // 20.07.2015 15:30:25
            Console.WriteLine(date1.ToLongDateString()); // 20 июля 2015 г.
            Console.WriteLine(date1.ToShortDateString()); // 20.07.2015
            Console.WriteLine(date1.ToLongTimeString()); // 18:30:25
            Console.WriteLine(date1.ToShortTimeString()); // 18:30
            Console.WriteLine("\tУрок 71:  Класс StringBuilder");
            StringBuilder text = new StringBuilder("Привет мир");
            Console.WriteLine($"Длина строки: {text.Length}"); //длина строки
            Console.WriteLine($"Емкость памяти: {text.Capacity}"); //ёмкость выделенной памяти.
            text.Append(" конец строки"); //добавляет подстроку
            Console.WriteLine($"Длина строки: {text.Length}"); //22
            Console.WriteLine($"Емкость памяти: {text.Capacity}"); // 32
            //вставляет подстроку в объект StringBuilder, начиная с определенного индекса
            text.Insert(7, " (текст с 7 символа) "); 
            Console.WriteLine(text);
            // удаляем 13 символов, начиная с 7-го
            text.Remove(7, 20);
            Console.WriteLine(text);
            // получаем строку из объекта StringBuilder
            string s = text.ToString();
            Console.WriteLine(s);

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

            
             
                */


            Console.ReadKey();
        }
    }
}

