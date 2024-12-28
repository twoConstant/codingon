using System;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.User;
using VendingMachingProject.users;
using VendingMachingProject.vendingmaching;

namespace VendingMachingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            ITransactionManager tm = new TransactionManagerV1();
            IVendingMachine vm = new VendingMachineV1(tm, 10000);
            IUser user = new UserV1(tm, vm, 500000, 500000);

            user.BuyDrink(user.GetRandomCreditCardId(), 3);

            Console.WriteLine("프로그램 종료");
        }
    }
}