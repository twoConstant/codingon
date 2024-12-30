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

        bool TryServeDrink(string id, int quantity);

        string GetName();

        int GetStock();

        int GetPrice();

        int GetTotalSales();

        DateTime GetCreateDate();

        DateTime GetlastRepairDate();
    }
}
