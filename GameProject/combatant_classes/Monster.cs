using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class Monster : Combatant
    {
        public bool boss { get; private set; }
        public List<string> dropItems { get; private set; } = new List<string>();

        // 생성자
        public Monster(int id, int healthPoint, int attackPoint, bool isBoss, string dropItem) : base(id, healthPoint, attackPoint)
        {
            this.boss = isBoss;
            this.dropItems.Add(dropItem);
            Console.WriteLine($"[Monster - 생성자] isBoss: {isBoss}, dropItem: {dropItem}");
        }

        public override void Attack(Combatant combatant)
        {
            base.coreAttack(this.attackPoint);
        }

        public override void Talk()
        {
            Console.Write("안녕 난 몬스터 타입의 ");
        }
        
    }
}

