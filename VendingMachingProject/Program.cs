using System;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.User;
using VendingMachingProject.users;
using VendingMachingProject.vendingmaching;
using VendingMachingProject.vendingmaching_manager;

namespace VendingMachingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 자판기 시스템 테스트 시작 ===");

            // Step 1: 트랜잭션 매니저 생성
            ITransactionManager transactionManager = new TransactionManagerV1();

            // Step 2: 자판기 관리자 생성
            IVendingMachineManager vendingMachineManager = new VendingMachineManagerV1(transactionManager);

            // Step 3: 자판기 생성 및 추가
            vendingMachineManager.CreateVendingMachineV1AndAdd("Machine1", 1500);
            

            // Step 4: 사용자 생성
            IUser user = new UserV1(transactionManager, vendingMachineManager.CreateVendingMachineV1AndAdd("Machine2", 2000));
            user.CreateCreditCard(5000);  // 카드 한도: 5000
            user.CreateDeposit(3000);    // 예금 잔액: 3000

            // Step 5: 자판기 재고 채우기
            vendingMachineManager.FillVendingMachine("Machine1", 50);
            vendingMachineManager.FillVendingMachine("Machine2", 30);

            // Step 6: 사용자 음료 구매
            string creditCardId = user.GetRandomCreditCardId();
            user.BuyDrink(creditCardId, 2);  // Machine1에서 2개의 음료 구매

            // Step 7: 자판기 상태 확인
            List<string> machineNames = vendingMachineManager.GetVendingMachineNames();
            Console.WriteLine("\n=== 자판기 목록 ===");
            foreach (var name in machineNames)
            {
                Console.WriteLine($"- {name}");
            }

            // Step 8: 재고 임계값 이하 자판기 확인
            List<string> lowStockMachines = vendingMachineManager.GetVendingMachinesWithStockBelow(10);
            Console.WriteLine("\n=== 재고가 임계값 이하인 자판기 ===");
            foreach (var name in lowStockMachines)
            {
                Console.WriteLine($"- {name}");
            }

            // Step 9: 수리가 필요한 자판기 확인 (미구현된 메서드는 예외 처리)
            try
            {
                List<string> needingRepair = vendingMachineManager.GetVendingMachinesNeedingRepair(6);
                Console.WriteLine("\n=== 수리가 필요한 자판기 ===");
                foreach (var name in needingRepair)
                {
                    Console.WriteLine($"- {name}");
                }
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("\n[경고] 수리가 필요한 자판기 조회는 아직 구현되지 않았습니다.");
            }

            // Step 10: 총 매출 확인
            int totalSales = vendingMachineManager.GetTotalSale();
            Console.WriteLine($"\n총 매출: {totalSales}원");

            // Step 11: 자판기 삭제 테스트
            bool isDeleted = vendingMachineManager.TryDeleteVendingMachine("Machine1");
            Console.WriteLine($"\nMachine1 삭제 결과: {(isDeleted ? "성공" : "실패")}");

            // Step 12: 최종 자판기 목록 확인
            machineNames = vendingMachineManager.GetVendingMachineNames();
            Console.WriteLine("\n=== 최종 자판기 목록 ===");
            foreach (var name in machineNames)
            {
                Console.WriteLine($"- {name}");
            }

            Console.WriteLine("\n=== 자판기 시스템 테스트 종료 ===");
        }
    }
}