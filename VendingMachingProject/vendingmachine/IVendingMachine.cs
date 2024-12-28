using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachingProject.vendingmaching
{
    public interface IVendingMachine
    {
        bool IsEnoughToPay(string Id, int quantity);

        int AddStock(int numToAdd);

        void ServeDrink(string id, int quantity);
    }
}
