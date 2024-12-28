using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachingProject.User
{
    public interface IUser
    {
        void BuyDrink(string creditCardId, int quantity);

        void CreateCreditCard(int limit);

        void CreateDeposit(int initBalance);

        string GetRandomCreditCardId();

        string GetRandomDepositeId();

        int ChargeDeposite(string depostieId, int moneyToDeposite);
    }
}
