using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachingProject.transaction_manager
{
    public interface ITransactionManager
    {
        bool IsEnoughToPay(string id, int priceToPay);

        bool SendMoneyByCard(string fromId, string toId, int moneyToSend);

        bool SendMoneyByDeposite(string fromId, string toId, int moneyToSend);

        bool IsCreditCard(string id);

        bool IsDeposite(string id);

        string CreateCreditCard(int limit);

        string CreateDeposit(int initBalance);

        int AddMontyToDeposite(string depositeId, int money);

        void UpdateLimit(string creditCard, int limit);

    }
}
