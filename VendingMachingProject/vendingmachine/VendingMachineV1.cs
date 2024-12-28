using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachingProject.transaction_manager;


namespace VendingMachingProject.vendingmaching
{
    public class VendingMachineV1 : IVendingMachine
    {
        private readonly Random Random = new Random();
        private ITransactionManager tm;

        // 속성 정의
        private int stock;
        private int totalSales;
        private readonly DateTime createDate;
        private DateTime lastRepairDate;
        private int price;
        // 사업주 계좌 이후에 Manager가부여하거나 관리 하는거임
        private string depositeId;
    

        public VendingMachineV1(ITransactionManager tm, int price) 
        {
            this.stock = Random.Next(0, 101);
            this.totalSales = 0;
            createDate = DateTime.Now;
            lastRepairDate = createDate;
            this.price = price;
            this.tm = tm;
            this.depositeId = tm.CreateDeposit(0);
        }


        public int AddStock(int numToAdd)
        {
            Console.WriteLine($"[VendingMachineV1] AddStock called with NumToAdd: {numToAdd}");
            if (numToAdd <= 0)
            {
                Console.WriteLine("[VendingMachineV1] Stock addition failed: Cannot add non-positive quantity.");
                return -1;
            }

            this.stock += numToAdd;
            Console.WriteLine($"[VendingMachineV1] Stock successfully added. New Stock: {this.stock}");
            return this.stock;
        }

        public bool IsEnoughToPay(string creditCardID, int quantity)
        {
            Console.WriteLine($"[VendingMachineV1] IsEnoughToPay called with CreditCardID: {creditCardID}, Quantity: {quantity}");

            if (!IsStockSufficient(quantity))
            {
                Console.WriteLine($"[VendingMachineV1] Payment failed: Insufficient stock. Current Stock: {this.stock}");
                return false;
            }

            if (!tm.IsEnoughToPay(creditCardID, this.price * quantity))
            {
                Console.WriteLine("[VendingMachineV1] Payment failed: Credit card limit exceeded.");
                return false;
            }

            Console.WriteLine("[VendingMachineV1] Payment approved.");
            return true;
        }

        public void ServeDrink(string id, int quantity)
        {
            Console.WriteLine($"[VendingMachineV1] ServeDrink called with Id: {id}, Quantity: {quantity}");
            int priceToPay = quantity * this.price;

            this.stock -= quantity;
            this.totalSales += priceToPay;

            Console.WriteLine($"[VendingMachineV1] Stock updated. Remaining Stock: {this.stock}. Total Sales: {this.totalSales}");

            if (tm.IsCreditCard(id))
            {
                Console.WriteLine("[VendingMachineV1] Processing payment with Credit Card...");
                tm.SendMoneyByCard(id, this.depositeId, priceToPay);
            }
            else
            {
                Console.WriteLine("[VendingMachineV1] Processing payment with Deposit...");
                tm.SendMoneyByDeposite(id, this.depositeId, priceToPay);
            }

            Console.WriteLine("[VendingMachineV1] ServeDrink completed.");
        }


        private bool IsStockSufficient(int quntity)
        {
            if(this.stock < quntity)
            {
                return false;
            }

            return true;
        }

        
    }
}
