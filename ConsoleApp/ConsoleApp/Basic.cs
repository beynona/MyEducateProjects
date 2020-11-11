using System;
using System.Collections.Generic;
using System.Text;
//Объявление псевдонима
using printer = System.Console;
namespace ConsoleApp
{
    class Basic
    {
        void Literals()
        {
            double expPL = 3.2E3;
            double expMIN = 3.2E-3;
            int dv3 = 0b11;
            int dv11 = 0b1011;
            int sh10 = 0x0A;
            int sh255 = 0x0FF;
            int sh161 = 0xA1;
            Console.WriteLine($"Экспоненциафльная форма 3.2E3: {expPL}\nЭкспоненциафльная форма 3.2E-3: {expMIN}\nДвоичная форма 11: {dv3}\nДвоичная форма 1011: {dv11}\nШестнадцатеричная форма 0A: {sh10}\nШестнадцатеричная форма FF: {sh255}\nШестнадцатеричная форма A1: {sh161}\n");
            Console.WriteLine("1)Табуляция(\"t\")\t и перенос строки (\"n\")\n2)Предложение в \"Кавычках\"");
        } //Литералы
        void DataTypes()
        {
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
            //Все наследуется от object
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
        } //Типы данных
        void OuputText()
        {
            string name = "Jenua";
            int age = 22;
            //При помощи $
            Console.WriteLine($"1)Моё имя {name}, мой возраст {age}");
            //При помощи {}
            Console.WriteLine("2)Моё имя {0}, мой возраст {1}", name, age);
        } //Вывод текста
        void Conversion()
        {
            string bolcon = "true";
            string bolcon2 = "2";
            //String -> boolean
            Convert.ToBoolean(bolcon);
            //String -> Int
            Convert.ToInt32(bolcon2);
            //Конвертация введеного числа
            Console.Write("Введите целое число:");
            int age = Convert.ToInt32(Console.ReadLine());
            //Вывод результатов
            Console.WriteLine($"1)Возраст (значение типа int) = {age}\n" +
                              $"2)Значение boolean = " + Convert.ToBoolean(bolcon));
        } //Конвертация строк
        void ArithmeticOperations()
        {
            int a = 18;
            int b = 10;
            int a1 = 18;
            int a2 = 18;
            Console.WriteLine($"a={a}, b={b}\n" +
                              $"a + b={a + b}\n" +
                              $"a - b={a - b}\n" +
                              $"a / b={a / b}\n" +
                              $"a * b={a * b}\n" +
                              $"a % b={a % b}\n" +
                              $"a++ ={a++}\n" +
                              $"a-- ={a--}\n" +
                              $"++a ={++a}\n" +
                              $"--a ={--a}\n" +
                              $"++a - b ={++a2 - b}\n" +
                              $"(a++) - b ={(a1++) - b}");
        } //Арифметические операции
        void ParseString()
        {
            string s = "54";
            int res;
            //Parse
            try
            {
                int a = int.Parse(s);
                Console.WriteLine("Конвертация Parse прошла успешно. ");
            }
            catch (Exception)
            {

                Console.WriteLine("Ошибка при конвертации Parse.");
            }
            //TryParse -> true/false
            bool result = int.TryParse(s, out res);
            if (result)
            {
                Console.WriteLine("Конвертация TryParse прошла успешно.");
            }
            else
            {
                Console.WriteLine("Ошибка при конвертации TryParse.");
            }
        } //Преобразование строк, ключелове слово Parse
        void BitwiseOperations()
        {
            int x1 = 2;
            int x2 = 4;
            int y = 5;
            Console.WriteLine($"x1 = {x1}, x2 = {x2}, y = {y}\n" +
                              $"x1 & y = {x1 & y}\n" +
                              $"x2 & y = {x2 & y}\n" +
                              $"x1 | y = {x1 | y}\n" +
                              $"x2 | y = {x2 | y}\n" +
                              $"~x1 + 1 = {~x1 + 1}\n" +
                              $"~x2 + 1 = {~x2 + 1}\n" +
                              $"~y + 1 = {~y + 1}\n");
            int x = 45;
            int key = 102;
            int encrypt = x ^ key;
            Console.WriteLine($"Исходное число:{x}, ключ:{key}");
            Console.WriteLine($"Зашифрованное число:{encrypt}");
            Console.WriteLine($"Расшифрованное число:{encrypt ^ key}");
        } //Поразрядные операции
        void AssignmentOperations()
        {
            int a = 10;
            Console.WriteLine($"a = {a}\n" +
                              $"a += 10 -> {a += 10}, сброс до {a = 10}\n" +
                              $"a -= 10 -> {a -= 10}, сброс до {a = 10}\n" +
                              $"a *= 10 -> {a *= 10}, сброс до {a = 10}\n" +
                              $"a /= 10 -> {a /= 10}, сброс до {a = 10}\n" +
                              $"a %= 10 -> {a %= 10}, сброс до {a = 10}\n" +
                              $"a &= 10 -> {a &= 10}, сброс до {a = 10}\n" +
                              $"a |= 10 -> {a |= 10}, сброс до {a = 10}\n" +
                              $"a ^= 10 -> {a ^= 10}, сброс до {a = 10}\n" +
                              $"a <<= 2 -> {a <<= 2}, сброс до {a = 10}\n" +
                              $"a >>= 2 -> {a >>= 2}\n");
        } //Операции присваивания
        void LogicOperation()
        {
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
        }  //Условные выражения и логические операции
        void Pseudonim()
        {
            //Console имеет псевдоним printer
            printer.WriteLine();
        } //Псевдонимы
        void TryCetchFinally()
        {
            try
            {
                //Место где может быть ошибка
                string mess = Console.ReadLine();
                if (mess.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
            }
            catch (Exception ex)
            {
                //Обработка ошибки
                Console.WriteLine($"Error:{ex.Message}");
            }
            finally
            {
                //Завершающая операция вне зависимости от возниконовения ошибки
            }
        } //Обработка исключений
    } //Базовые операции
    class Methods
    {
        void Method()
        {
            Console.WriteLine("\tМетоды");
            //Вызов методов
            Prima();
            SayHello();
        }
        //Объявление 1 методы
        static void SayHello() => Console.WriteLine("It's work");
        //Объявление 2 метода
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
    } //Определение понятия метод
    class ParametersByReference
    {
        void Reference()
        {
            Console.WriteLine("\tПередача параметров по ссылке");

            int z = 4;
            int b = 6;
            int aq;
            // изначальные данные
            Console.WriteLine($"Изначальная z = {z}, b = {b}, aq = 0");
            //по ссылке с выходным параметром до изменения входных параметров
            Rerk(z, b, out aq);
            Console.WriteLine($"aq до ref = {aq}");
            Peri(z, b);
            //по ссылке с входным параметром
            Console.WriteLine($"z = {z}");
            PeriRef(ref z, b);
            Console.WriteLine($"z = {z}");
            //по ссылке с выходным параметром после изменения входных параметров
            Rerk(z, b, out aq);
            Console.WriteLine($"aq после ref = {aq}");
        }
        //метод без ссылки 
        static void Peri(int a, int b)
        {
            a = a + b;
            Console.WriteLine($"a + b (обычная) = {a}");
        }
        //метод с входным параметром по ссылке 
        static void PeriRef(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine($"a + b (ref) = {a}");
        }
        //метод с выходным параметром по ссылке 
        static void Rerk(int a, int b, out int z)
        {
            z = a + b;
        }
    } //ключевые слова ref, out
    class Enum
    {
       //Вывод результата на экран
       void Print()
        {
            //Вызов методов 
            matSum(2, 4, Operation.Add);
            matSum(2, 4, Operation.Div);
            matSum(2, 4, Operation.Milti);
            matSum(2, 4, Operation.Sub);
        }
       //Перечисления enum
       enum Operation
        {
            Add,
            Sub,
            Milti,
            Div
        }
       //Реализация перечисления enum
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
    } //Перечисления enum
    class Kortej 
    {
        void Print()
        {
            //Объявление простых неявных кортежей
            var Prostoj = (1, "Tom");
            Console.WriteLine($"1 элемент:{Prostoj.Item1}");
            Console.WriteLine($"2 элемент:{Prostoj.Item1}");
            //Объявление сложных неявных кортежей
            var Slojnij = (id: 1, name: "Tom");
            Console.WriteLine($"1 элемент:{Slojnij.id}");
            Console.WriteLine($"2 элемент:{Slojnij.name}");
            //Объявление простых явных кортежей
            (string, int, double) Personaj = ("riki", 12, 32.2);
            Console.WriteLine($"1 элемент:{Personaj.Item1}");
            //Объявление кортежей с присваиванием переменной
            var (namee, agee) = ("Tom", 23);
            Console.WriteLine($"1 элемент:{namee}");
            Console.WriteLine($"2 элемент:{agee}");
            //Вызов метода и использованием кортежа и массивом в виде параметра
            var (sum, cout) = GetNuf(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Summ=" + sum);
            Console.WriteLine("Cout=" + cout);
            //Вызов метода с передачей параметров в кортеж
            var (name, age) = GetAnotherAge(("Jenua", 23), 32);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Age=" + age);
            //Вызов метода с встроенным кортежем
            GetSecretsValue();
        }
        //Метод с встроенным кортежем
        private static (int, string) GetSecretsValue()
        {
            var SecretsValue = (23, "Zenua");
            return SecretsValue;
        }
        //Метод и использованием кортежа и массивом в виде параметра
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
        //Метод с передачей параметров в кортеж
        private static (string name, int age) GetAnotherAge((string n, int a) personaj, int fu)
        {
            var results = (name: personaj.n, age: personaj.a + fu);
            return results;
        }

    } //Кортежи
    class Structure
    {
        void Print()
        {
            //Объявление структуры с конструктором
            User bob = new User();
            bob.DisplayInfo();
            //Объявление структуры без конструктора (при таком подходе необходимо проинициализировать поля) 
            User tom;
            tom.name = "Toma";
            tom.age = 21;
            tom.DisplayInfo();
        }
        struct User
        {
            public string name;
            public int age;

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}  Age: {age}");
            }
        }

    } //Структуры
    class Access
    {
        public int a; //Доступен везде
        private int b; //Доступен только в данном классе
        protected int c; //Доступен только в данном классе и в наследниках
        internal int d; //Доступен только в данном пространстве имён
        protected internal int e; //Доступен только в данном пространстве имён и в классах наследниках  
    } //Модификаторы доступа
    class Overload
    {
        public void Add(int a, int b) { }
        public void Add(int a, int b, int c) { }
        public void Add(double a, double b) { }
    } //Перегрузка методов
    class OverloadOperators
    {
            public int Value { get; set; }
            public static OverloadOperators operator /(OverloadOperators c1, OverloadOperators c2)
            {
                return new OverloadOperators { Value = c1.Value / c2.Value };
            }
            public static int operator +(OverloadOperators c1, int val)
            {
                return c1.Value + val;
            }
            public static OverloadOperators operator ++(OverloadOperators c1)
            {
                return new OverloadOperators { Value = c1.Value + 10 };
            }
            public static bool operator true(OverloadOperators c1)
            {
                return c1.Value != 0;
            }
            public static bool operator false(OverloadOperators c1)
            {
                return c1.Value == 0;
            }
        
    } //Перегрузка операторов
    class Constants
    {
        const double PI = 3.14;
        public readonly double k = 23;
    } //Константы и поля для чтения
}
