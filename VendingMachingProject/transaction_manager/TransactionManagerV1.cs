using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachingProject.transaction_manager
{
    public class TransactionManagerV1 : ITransactionManager
    {

        private readonly Dictionary<string, int[]> creditCardMap = new Dictionary<string, int[]>();
        private readonly Dictionary<string, int> depositeMap = new Dictionary<string, int>();

        public int AddMontyToDeposite(string depositeId, int money)
        {
            Console.WriteLine($"[TransactionManagerV1] AddMontyToDeposite called with DepositeId: {depositeId}, Money: {money}");
            if (money <= 0)
            {
                Console.WriteLine("[TransactionManagerV1] Deposit failed: Cannot add non-positive amount.");
                return -1;
            }

            int updatedBalance = depositeMap[depositeId] += money;
            Console.WriteLine($"[TransactionManagerV1] Deposit successful. New Balance: {updatedBalance}");
            return updatedBalance;
        }

        public string CreateCreditCard(int limit)
        {
            string creditCardId = Guid.NewGuid().ToString();
            creditCardMap.Add(creditCardId,new int[2]{ 0, limit });
            return creditCardId;
        }

        public string CreateDeposit(int init)
        {
            string depositeId = Guid.NewGuid().ToString();
            depositeMap.Add(depositeId, init);
            return depositeId;
        }

        public bool IsEnoughToPay(string id, int priceToPay)
        {
            Console.WriteLine($"[TransactionManagerV1] IsEnoughToPay called with Id: {id}, PriceToPay: {priceToPay}");

            if (depositeMap.ContainsKey(id))
            {
                Console.WriteLine("[TransactionManagerV1] Checking deposit balance...");
                if (GetBalanceOfDeposite(id) < priceToPay)
                {
                    Console.WriteLine("[TransactionManagerV1] Payment failed: Insufficient deposit balance.");
                    return false;
                }
                Console.WriteLine("[TransactionManagerV1] Payment approved for deposit.");
                return true;
            }
            else if (creditCardMap.ContainsKey(id))
            {
                Console.WriteLine("[TransactionManagerV1] Checking credit card limit...");
                if (GetLimitOfCard(id) < GetCurExpenditureOfCard(id) + priceToPay)
                {
                    Console.WriteLine("[TransactionManagerV1] Payment failed: Credit card limit exceeded.");
                    return false;
                }
                Console.WriteLine("[TransactionManagerV1] Payment approved for credit card.");
                return true;
            }
            else
            {
                Console.WriteLine("[TransactionManagerV1] Payment failed: Unknown id.");
                return false;
            }
        }

        public bool SendMoneyByCard(string fromId, string toId, int moneyToSend)
        {
            if(Expend(fromId, moneyToSend) == -1)
            {
                return false;
            }
            if(Deposite(toId, moneyToSend) == -1)
            {
                // 롤백하고
                RollBackExpend(fromId, moneyToSend);
                return false;
            };

            return true;
        }

        public bool SendMoneyByDeposite(string fromId, string toId, int moneyToSend)
        {
            // 예금 계좌에서, 에금 계좌로
            if(Draw(fromId, moneyToSend) == -1)
            {
                return false;
            };

            if(Deposite(toId, moneyToSend) == -1)
            {
                Deposite(fromId, moneyToSend);
                return false;
            }
            ;

            return true;

        }

        public void UpdateLimit(string creditCard, int limit)
        {
            creditCardMap[creditCard][1] = limit;
        }

        private int GetLimitOfCard(string creditCardId)
        {
            return creditCardMap[creditCardId][1];
        }

        private int GetCurExpenditureOfCard(string creditCardId)
        {
            return creditCardMap[creditCardId][0];
        }

        private int GetBalanceOfDeposite(string depositeId)
        {
            return depositeMap[depositeId];
        }

        private int Draw(string depositId, int moneyToDraw)
        {
            if(!depositeMap.ContainsKey(depositId))
            {
                Console.WriteLine("입력하신 id는 예금계좌가 아닙니다.");
                return -1;
            }

            depositeMap[depositId] -= moneyToDraw;
            return moneyToDraw;
        }

        private int Deposite(string depositId, int moneyToDeposite)
        {
            if(!depositeMap.ContainsKey(depositId))
            {
                Console.WriteLine("입력하신 id는 예금계좌가 아닙니다.");
                return -1;
            }

            return depositeMap[depositId] += moneyToDeposite;
        }

        private int Expend(string creditCardId, int moneyToExpend)
        {
            if(!creditCardMap.ContainsKey(creditCardId))
            {
                Console.WriteLine("입력하신 id는 카드가 아닙니다.");
                return -1;
            }

            return creditCardMap[creditCardId][0] += moneyToExpend;
        }

        private int RollBackExpend(string creditCardId, int moneyToExpend)
        {
            if (!creditCardMap.ContainsKey(creditCardId))
            {
                Console.WriteLine("입력하신 id는 카드가 아닙니다.");
                return -1;
            }

            return creditCardMap[creditCardId][0] -= moneyToExpend;
        }

        public bool IsCreditCard(string id)
        {
            return creditCardMap.ContainsKey(id);
        }

        public bool IsDeposite(string id)
        {
            return depositeMap.ContainsKey(id);
        }
    }
}
