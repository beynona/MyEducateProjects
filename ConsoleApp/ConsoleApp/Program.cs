using System;

namespace ConsoleApp
{

    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("\tУрок 33: null");
            
            
            /*
            
            
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
            var (namee, agee) = ("Tom", 23);

            var (sum, cout) = GetNuf(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Summ=" + sum);
            Console.WriteLine("Cout=" + cout);

            var (name, age) = GetAnotherAge(("Jenua", 23), 32);
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
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                num[i] = Int32.Parse(Console.ReadLine());

            }
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("\tУрок 14: Инверсия массива");
            int[] num = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int n = num.Length;
            int k = n / 2;
            int temp;
            for (int i = 0; i < k; i++)
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

            int j=0, k=0;

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

            for (int i = 0; i < 9; i++)
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
            double expPL  = 3.2E3;
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

