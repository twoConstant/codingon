using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.vendingmaching;

namespace VendingMachingProject.vendingmaching_manager
{
    public interface IVendingMachineManager
    {
        // V1자판기 생성
        IVendingMachine CreateVendingMachineV1AndAdd(string NameOfVendingMachine, int price);

        // 자판기 추가
        IVendingMachine AddVendingMachine(IVendingMachine vm);

        // 자판기 삭제
        bool RemoveVendingMachineByName(string name);

        // 전체 자판기 조회
        List<string> GetVendingMachineNames();

        // 재고가 특정 임계값 이하인 자판기 조회
        List<string> GetVendingMachinesWithStockBelow(int threshold);

        // 재고 일괄 채우기
        void FillVendingMachines(int quantityToFill, int threshold);

        // 재고 단일 채우기
        void FillVendingMachine(string name, int quantityToFill);

        // 자판기 삭제
        bool TryDeleteVendingMachine(string name);

        // 수리가 필요한 자판기 조회 매개변수 : 단위 개월 수
        List<string> GetVendingMachinesNeedingRepair(int monthsSinceLastRepair);

        // 교체가 필요한 자판기 조회 매개변수 : 단위 연수
        List<string> GetVendingMachinesNeedingReplacement(int yearsSinceInstallation);

        int GetTotalSale();

        // 이름으로 자판기 객체 조회
        IVendingMachine GetVendingMachineByName(string name);

    }
}
