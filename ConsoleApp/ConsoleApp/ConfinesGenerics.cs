using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    //У класса Account может быть много наследников: DepositAccount (депозитный счет), DemandAccount (счет до востребования) и т.д. 
    //И мы не можем знать, какие именно типы счетов будут использоваться в классе Transaction. 
    //Возможно, транзакции будут проводиться только между счетами до востребования. 
    //И в этом случае в качестве универсального параметра можно установить тип Account

    //С помощью выражения where T : Account мы указываем, что используемый тип T обязательно должен быть классом Account или его наследником. 
    //Благодаря подобному ограничению мы можем использовать внутри класса Transaction все объекты типа T именно как объекты Account и соответственно обращаться к их свойствам и методам.

    //Следует учитывать, что только один класс может использоваться в качестве ограничения.
    //В качестве ограничения также может выступать и обобщенный класс
    class ConfinesGenerics
    {
        void Print()
        {
            AccountG acc1 = new AccountG(23) { Sum = 4500 };
            AccountG acc2 = new AccountG(55) { Sum = 5000 };

            TransactionG<AccountG> t1 = new TransactionG<AccountG>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 500
            };
            t1.Execute();

        }
    } //Ограничения обобщений
    class AccountG
    {
        public int ID { get; set; }
        public int Sum { get; set; }
        public AccountG(int _id)
        {
            ID = _id;
        }
    }
    class TransactionG<T> where T : AccountG
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
}
