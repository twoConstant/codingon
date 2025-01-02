using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GameProject.classes
{
    public class Character : Combatant
    {
        public string name { get; private set; }

        // 생성자
        public Character(int id, string name, int healthPoint, int attackPoint) : base(id, healthPoint, attackPoint)
        {
            this.name = name;
            Console.WriteLine($"[Character - 생성자] name: {name}");

        }

        public override void Attack(Combatant combatant)
        {
            base.CoreAttack(this.attackPoint);
        }

        public override void Talk()
        {
            Console.Write("안녕 난 캐릭터 타입의 ");
        }
    }
}
