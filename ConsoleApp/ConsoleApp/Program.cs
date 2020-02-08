using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tУрок 9: ");

            /*
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
