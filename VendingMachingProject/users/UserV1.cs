using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.User;
using VendingMachingProject.vendingmaching;

namespace VendingMachingProject.users
{
    public class UserV1 : IUser
    {
        private readonly Random random = new Random(); 
        private readonly ITransactionManager tm;
        private IVendingMachine vm;
        private List<string> creditCards = new List<string>();
        private List<string> deposites = new List<string>();

        // 생성자
        public UserV1(ITransactionManager tm, IVendingMachine vm)
        {
            this.tm = tm;
            this.vm = vm;
        }

        // 카드 계좌와 예금 잔액을 생성하며 시작
        public UserV1(ITransactionManager tm, IVendingMachine vm, int limit, int initBalance)
        {
            this.tm = tm;
            this.vm = vm;
            creditCards.Add(tm.CreateCreditCard(limit));
            deposites.Add(tm.CreateDeposit(initBalance));
        }



        public void BuyDrink(string creditCardId, int quantity)
        {
            Console.WriteLine($"[UserV1] BuyDrink called with CreditCardId: {creditCardId}, Quantity: {quantity}");

            if (!vm.IsEnoughToPay(creditCardId, quantity))
            {
                Console.WriteLine("[UserV1] Purchase failed: Insufficient funds or stock.");
                return;
            }

            Console.WriteLine("[UserV1] Purchase approved. Proceeding to ServeDrink...");
            vm.ServeDrink(creditCardId, quantity);
            Console.WriteLine("[UserV1] Purchase completed successfully.");
        }

        public int ChargeDeposite(string depostieId, int moneyToDeposite)
        {
            Console.WriteLine($"[UserV1] ChargeDeposite called with DepositeId: {depostieId}, MoneyToDeposite: {moneyToDeposite}");
            return tm.AddMontyToDeposite(depostieId, moneyToDeposite);
        }

        public void CreateCreditCard(int limit)
        {
            creditCards.Add(tm.CreateCreditCard(limit));
        }

        public void CreateDeposit(int initBalance)
        {
            deposites.Add(tm.CreateDeposit(initBalance));
        }

        public string GetRandomCreditCardId()
        {
            // 카드의 리스트 사이즈 내에서 선택
            return creditCards[random.Next(0, creditCards.Count)];
        }

        public string GetRandomDepositeId()
        {
            return deposites[random.Next(0, deposites.Count)];
        }

        public List<string> getCreditCards()
        {
            return creditCards;
        }

        public List<string> getDeposites()
        {
            return deposites;
        }
    }
}
