using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Generics
    {
        //Обобщенные типы позволяют указать конкретный тип, который будет использоваться.
        //Угловые скобки в описании class Account<T> указывают, что класс является обобщенным, 
        //а тип T, заключенный в угловые скобки, будет использоваться этим классом.
        //для Account<string> и для Account<int> будет создана своя переменная.

        //Присвоить переменным универсальных параметров некоторое начальное значение, в том числе и null.
        //В этом случае нам надо использовать оператор default(T). 
        //Он присваивает ссылочным типам в качестве значения null, а типам значений - значение 
        //Например:  class Account<T> {T id = default(T);}
    void Print()
        {
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

        }
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    } //Обобщения
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

}
