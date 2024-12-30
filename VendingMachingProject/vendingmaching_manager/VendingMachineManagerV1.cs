using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.vendingmaching;
using System.Diagnostics;

namespace VendingMachingProject.vendingmaching_manager
{
    public class VendingMachineManagerV1 : IVendingMachineManager
    {

        // 보유한 자판기
        private readonly IList<IVendingMachine> vendingMachines = new List<IVendingMachine>();
        private readonly ITransactionManager tm;
        private string depositeId;
        
        // 생성자
        public VendingMachineManagerV1(ITransactionManager tm)
        {
            this.tm = tm;
            this.depositeId = tm.CreateDeposit(0);
            Debug.WriteLine($"자판기매니져 생성, 계좌번호: {depositeId}");
        }

        public IVendingMachine AddVendingMachine(IVendingMachine vm)
        {
            vendingMachines.Add(vm);
            Debug.WriteLine($"자판기 추가 완료");
            return vm;
        }

        public IVendingMachine CreateVendingMachineV1AndAdd(string NameOfVendingMachine, int price)
        {
            return AddVendingMachine(new VendingMachineV1(tm, price, NameOfVendingMachine, this.depositeId));
        }

        public void FillVendingMachine(string name, int quantityToFill)
        {
            foreach (IVendingMachine vendingMachine in vendingMachines)
            {
                if(vendingMachine.GetName().Equals(name))
                {
                    int curStock = vendingMachine.AddStock(quantityToFill);
                    Debug.WriteLine($"{name}자판기 충전 후 수량= {curStock}.");
                    return;
                }
            }
            Debug.WriteLine($"{name} 자판기는 존재하지 않습니다.");
        }

        public void FillVendingMachines(int quantityToFill, int threshold)
        {
            List<string> vendingMachines = GetVendingMachinesWithStockBelow(threshold);
            foreach (string name in vendingMachines) {
                IVendingMachine vm = GetVendingMachineByName(name);
                int curStock = vm.AddStock(quantityToFill);
                Debug.WriteLine($"{name}자판기 충전 후 수량: {curStock}");
            }
        }

        public List<string> GetVendingMachineNames()
        {
            List<string> names = new List<string>();
            foreach (IVendingMachine vm in vendingMachines)
            {
                names.Add(vm.GetName());
            }
            return names;
        }

        public List<string> GetVendingMachinesNeedingRepair(int monthsSinceLastRepair)
        {
            throw new NotImplementedException();
        }

        public List<string> GetVendingMachinesNeedingReplacement(int yearsSinceInstallation)
        {
            throw new NotImplementedException();
        }

        public List<string> GetVendingMachinesWithStockBelow(int threshold)
        {
            List<string> names = new List<string>();
            foreach (IVendingMachine vm in vendingMachines)
            {
                if(vm.GetStock() <= threshold)
                {
                    names.Add(vm.GetName());
                    Debug.WriteLine($"{vm.GetName()}자판기 현재 수량: {vm.GetStock()}, threshold: {threshold}");
                }
            }

            return names;
        }

        public bool TryDeleteVendingMachine(string name)
        {
            for (int i = 0; i < vendingMachines.Count; i++)
            {
                if (vendingMachines[i].GetName().Equals(name))
                {
                    vendingMachines.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int GetTotalSale()
        {
            return tm.GetBalance(this.depositeId);
        }

        public IVendingMachine GetVendingMachineByName(string name)
        {
            foreach (IVendingMachine vm in vendingMachines)
            {
                if(vm.GetName().Equals(name))
                {
                    return vm;
                }
            }

            throw new InvalidOperationException($"{name}라는 자판기는 없습니다.");
        }

        public bool RemoveVendingMachineByName(string name)
        {

            return vendingMachines.Remove(GetVendingMachineByName(name));
        }
    }
}
