using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachingProject.transaction_manager;
using System.Diagnostics;


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
        private readonly string name;
    

        public VendingMachineV1(ITransactionManager tm, int price, string name, string depositeId)
        {
            this.stock = Random.Next(0, 101);
            this.totalSales = 0;
            createDate = DateTime.Now;
            lastRepairDate = createDate;
            this.price = price;
            this.tm = tm;
            this.depositeId = depositeId;
            this.name = name;
            Debug.WriteLine($"{name}자판기, 가격: {price}, 계좌번호: {depositeId}, 재고: {stock}");
        }


        public int AddStock(int numToAdd)
        {
            Debug.WriteLine($"[VendingMachineV1] AddStock called with NumToAdd: {numToAdd}");
            if (numToAdd <= 0)
            {
                Debug.WriteLine("[VendingMachineV1] Stock addition failed: Cannot add non-positive quantity.");
                return -1;
            }

            this.stock += numToAdd;
            Debug.WriteLine($"[VendingMachineV1] Stock successfully added. New Stock: {this.stock}");
            return this.stock;
        }

        public bool IsEnoughToPay(string creditCardID, int quantity)
        {
            Debug.WriteLine($"[VendingMachineV1] IsEnoughToPay called with CreditCardID: {creditCardID}, Quantity: {quantity}");

            if (!IsStockSufficient(quantity))
            {
                Debug.WriteLine($"[VendingMachineV1] Payment failed: Insufficient stock. Current Stock: {this.stock}");
                return false;
            }

            if (!tm.IsEnoughToPay(creditCardID, this.price * quantity))
            {
                Debug.WriteLine("[VendingMachineV1] Payment failed: Credit card limit exceeded.");
                return false;
            }

            Debug.WriteLine("[VendingMachineV1] Payment approved.");
            return true;
        }

        public bool TryServeDrink(string id, int quantity)
        {
            Debug.WriteLine($"[VendingMachineV1] ServeDrink called with Id: {id}, Quantity: {quantity}");
            int priceToPay = quantity * this.price;

            this.stock -= quantity;
            this.totalSales += priceToPay;

            Debug.WriteLine($"[VendingMachineV1] Stock updated. Remaining Stock: {this.stock}. Total Sales: {this.totalSales}");

            if (tm.IsCreditCard(id))
            {
                Debug.WriteLine("[VendingMachineV1] Processing payment with Credit Card...");
                tm.SendMoneyByCard(id, this.depositeId, priceToPay);
            }
            else
            {
                Debug.WriteLine("[VendingMachineV1] Processing payment with Deposit...");
                tm.SendMoneyByDeposite(id, this.depositeId, priceToPay);
            }

            Debug.WriteLine("[VendingMachineV1] ServeDrink completed.");
            return true;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetStock()
        {
            return this.stock;
        }

        private bool IsStockSufficient(int quntity)
        {
            if(this.stock < quntity)
            {
                return false;
            }

            return true;
        }

        public int GetTotalSales()
        {
            return this.totalSales;
        }

        public DateTime GetCreateDate()
        {
            return this.createDate;
        }

        public DateTime GetlastRepairDate()
        {
            return this.lastRepairDate;
        }

        public int GetPrice()
        {
            return this.price;
        }
    }
}
